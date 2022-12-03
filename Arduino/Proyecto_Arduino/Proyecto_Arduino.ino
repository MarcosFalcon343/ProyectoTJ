#include <Separador.h>
#include "DHT.h"

#define DHTPIN 2
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

Separador s;

//ENTRADAS SALIDAS
int MOTOR = 5;
int LEDDatos = 13;

//RANGOS
int MQ3RangoMax;
int MQ3RangoMin;
int TemRangoMax;
int TemRangoMin;
int HumRangoMax;
int HumRangoMin;
int timeDelay;

//BANDERAS
char Modo;
char AM;
bool ini = false;

//LECTURAS
float MQ3Valor;
float TemValor;
float HumValor;

//VARIABLES
int pwm;

void setup() {
  Serial.begin(9600);
  dht.begin();
  pinMode(MOTOR,OUTPUT); 

  pinMode(LEDDatos,OUTPUT);
  digitalWrite(LEDDatos,HIGH);

}

void loop() {
  if(ini){
      if(Serial.available()){
      serialEvent();
      }
    //leer sensores
    MQ3Valor = analogRead(A0);
    TemValor = dht.readTemperature();
    HumValor = dht.readHumidity() + 100;

    //Procedimientos

    //Activar Motor
    switch(Modo){
      case 'A':
        pwm = potencia(TemValor,MQ3Valor);
        analogWrite(MOTOR,pwm);
        break;
      case 'M':
        pwm = activarMotor(AM);
        analogWrite(MOTOR,pwm);
        break;
    }
    if(pwm > 0) AM = 'A';
    else AM = 'D';
    enviarDatos();
    delay(timeDelay);
  }
}

void serialEvent(){
  String datos = Serial.readString();

  MQ3RangoMax = s.separa(datos, ',', 0).toInt();
  MQ3RangoMin = s.separa(datos, ',', 1).toInt();
  TemRangoMax = s.separa(datos, ',', 2).toInt();
  TemRangoMin = s.separa(datos, ',', 3).toInt();
  HumRangoMax = s.separa(datos, ',', 4).toInt();
  HumRangoMin = s.separa(datos, ',', 5).toInt();
  timeDelay = s.separa(datos, ',', 6).toInt() * 1000;
  Modo = s.separa(datos, ',', 7).charAt(0);
  AM = s.separa(datos, ',', 8).charAt(0);

  if(s.separa(datos, ',', 9).charAt(0) == 'I' && ini == false){
    ini = true;
    digitalWrite(LEDDatos,LOW);
  }

  
}

void enviarDatos(){
  Serial.print(MQ3Valor);
  Serial.print(",");
  Serial.print(TemValor);
  Serial.print(",");
  Serial.print(HumValor);
  Serial.print(",");
  Serial.print(pwm);
  Serial.print(",");
  Serial.println(AM);
}

int potencia(float Tem, float MQ3){
  int pwm = 0;
  int rango_temperatura;
  if(MQ3 > MQ3RangoMax){
      pwm = 255;
  }else{
    rango_temperatura = constrain(Tem,0,TemRangoMax);
    pwm = map(rango_temperatura, TemRangoMin, TemRangoMax, 0, 255);
    if(pwm > 255) pwm = 255;
    else if (pwm < 0) pwm = 0;
  }
  return pwm;
}

int activarMotor(char activar){
  if(activar == 'A'){
    pwm = 255;
  }else{
    pwm = 0;
  }
  return pwm;
}
