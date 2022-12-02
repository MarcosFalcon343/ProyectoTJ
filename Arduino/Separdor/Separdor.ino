#include "DHT.h"
#define DHTPIN 2
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);



void setup() {
    Serial.begin(9600);
    dht.begin();

}

void loop() {
  if(Serial.available() > 0){
    String dato = Serial.readString();
    Serial.println(dato);
    Serial.println(separarValor(dato));
  }
}


double separarValor(String datos){
  String valor = "-1";
  int index = datos.length();
  bool check = false;

  for(int i = 0; i < datos.length(); i++){
    if(check){
      valor = valor + datos.charAt(i);
    }else if(datos.charAt(i) == '-'){
      valor = "";
      check = true;
    }
  }
  return valor.toDouble();
}


