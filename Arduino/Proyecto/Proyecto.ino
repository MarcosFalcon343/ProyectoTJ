#include "DHT.h" //Carga la libreria DHT
#define DHTPIN 2 //DEfine la variable DHTPIN que representara el pin cuartro 
                //que recibira los datos del sensor
#define DHTTYPE DHT11 // Se selecciona el DHT22
 
DHT dht(DHTPIN, DHTTYPE); //  Se inicia la varibale que será utilizada por arduino para 
              // comunicarse con el sensor
//#define MOTORPIN 3  // Se define el puerto D3 para conectar el motor mot-050
//#define MQ3PIN 0
 
#define delayTime 100 // fading time between colors
#define TEMPERATURA 'T'
#define HUMEDAD 'H'
#define CONCETRACION 'C'
#define MAXIMO 'M'
#define MINIMO 'm'
#define AUTOMATICO 'A'
#define MANUAL 'X'
#define VELOCIDAD 'V'
#define ENCENDIDO 1

char vectorChar[20];
bool finCadena = false;
int velocidad, temperatura_maxima, temperatura_minima, temperatura, humedad_maxima, humedad_minima;
int concentracion_maxima, concentracion_minima, modo, encendido, tiempo, humedad, concentracion;
 
String cadena = "TM";
String t1;
String h1;
int dato;
int MOTOR = 5;
int pwm;
int rango_temperatura;

void setup()
{
    Serial.begin(9600);
    dht.begin();
    pinMode(MOTOR,OUTPUT); 
    tiempo = 1000;
    //temperatura_maxima = "TM";
}

void serialEvent(){
  char tipo_dato, rango, modo;
  cadena="";
  //Recepción de datos Seriales
  if (Serial.available()) {              //Si existen datos seriales,
    cadena = Serial.readString();
    //  Serial.print(",");
    tipo_dato = Serial.read();           // lee el primer caracter a todos
    switch (tipo_dato){
      case AUTOMATICO:
      case MANUAL:
        modo = tipo_dato; break;
      case VELOCIDAD:
        velocidad = siguiente_valor();
        break;
      case TEMPERATURA:
        rango = Serial.read(); 
        if (rango==MAXIMO)
          temperatura_maxima = siguiente_valor();
        else
          if (rango==MINIMO)
           temperatura_minima = siguiente_valor();
          else
           //error
        break;
      case HUMEDAD:
        rango = Serial.read(); 
        if (rango==MAXIMO)
          humedad_maxima = siguiente_valor();
        else
          humedad_minima = siguiente_valor();
        break;
      case CONCETRACION:
        rango = Serial.read(); 
        if (rango==MAXIMO)
          concentracion_maxima = siguiente_valor();
        else
          concentracion_minima = siguiente_valor();
        break;
     }
  }     
}
 
int siguiente_valor(){ 
  char vectorChar[20];
  String cadenaCharEntrada = "";  
  while(Serial.available()){
    char CaracterEntrada = Serial.read();   //Leer 1 byte serial recibido
    if (CaracterEntrada == '\n') {          //Si el char o byte recibido es un fin de linea, activa la bandera
      finCadena = true;                        //Si la bandera finCadena = 1, entonces la transmision esta completa
    }
    else
    {
       cadenaCharEntrada += CaracterEntrada;   //Agregar el nuevo char a una cadena String 
    }
  }
  cadenaCharEntrada.toCharArray(vectorChar,20);   //Convertimos el string a un vectorChar
  int dato = atoi(vectorChar);  
  return dato;
}
 
 void loop(){ 
   delay(2000);
  //Serial.print(cadena);
  //delay(tiempo);
 // Serialprint(temperatura);
 // Serialprint(humedad);
 // Serialprint(concentracion);
 
float t = dht.readTemperature();
float h = dht.readHumidity()+100;

t1 = String (t);
  //Serial.print("Temperatura:");
  Serial.print(t);
  //Serial.print("\t");
  Serial.print(",");

  h1 = String (h);
  //Serial.print("Humedad:");
  Serial.print(h);  
  Serial.print(",");

  Serial.print(cadena);
  Serial.print("\n");
 

 //if (isnan(t)|| isnan(h)) {
    //Serial.println("Error al leer el sensor DHT!"); //Validamos si obtubimos resultados en las lecturas anteriores, si da error o no tenemos datos mostramos un error por consola
    //return; 
  //}

  //rango_temperatura = constrain(t,temperatura_minima,temperatura_maxima);
  //pwm = map(rango_temperatura,temperatura_minima,temperatura_maxima,0,255);

  //if(valor_alcohol > valor_limite){
       // pwm = 255;
  
}

//float concentration = getConcentration(rs_med/R0);   // Obtener la concentración
 
/*float readMQ(int mq_pin)
{
   float rs = 0;
   for (int i = 0;i<READ_SAMPLE_TIMES;i++) {
      //rs += getMQResistance(analogRead(analogPin));
      delay(READ_SAMPLE_INTERVAL);
   }
   return rs / READ_SAMPLE_TIMES;
}
 
// Obtener resistencia a partir de la lectura analogica
float getMQResistance(int raw_adc)
{
   return (((float)RL_VALUE / 1000.0*(1023 - raw_adc) / raw_adc));
}
 
// Obtener concentracion 10^(coord + scope * log (rs/r0)
float getConcentration(float rs_ro_ratio)
{
   return pow(10, coord + scope * log(rs_ro_ratio));
}
*/
