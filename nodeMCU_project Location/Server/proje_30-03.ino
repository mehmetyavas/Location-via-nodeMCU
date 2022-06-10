#include "ESP8266WiFi.h"
//*********************************************
int adb1;
int adb2;
void prinScanResult(int networksFound)
{
  for (int i = 0; i < networksFound; i++)
  {
      String a=WiFi.SSID(i);
      int adb=WiFi.RSSI(i);
      if(a=="BelesWifi")
      {
        adb1=adb;
     }
     if(a=="TAKEONE")
      {
        adb2=adb;
     }

  }
}
 
const char* ssid = "BUMMM";
const char* password = "mehmett123";
 
WiFiServer server(80);
 
void setup() {
Serial.begin(115200);
delay(10);
  WiFi.mode(WIFI_STA);
  WiFi.disconnect();
  delay(100); 
 
// Wifi bağlantısı
Serial.println();
Serial.println();
Serial.print("Connecting to ");
Serial.println(ssid);
 
WiFi.begin(ssid, password);
 
while (WiFi.status() != WL_CONNECTED) {
delay(500);
Serial.print(".");
}
Serial.println("");
Serial.println("WiFi connected");
 
// server baslatılıyor
server.begin();
Serial.println("Server started");
 
// baglantı saglandıktan sonra serial monitorde bize ip adresini gösterecek
Serial.print("Use this URL to connect: ");
Serial.print("http://");
Serial.print(WiFi.localIP());
Serial.println("/");
 
}

 

void loop() {
// bir clien istemci baglı olup olmadığını kontrol ediyoruz
WiFiClient client = server.available();
if (!client) {
return;
}


// client ın bir data gondermesini bekliyoruz
Serial.println("new client");
while(!client.available()){
delay(1);
}
 
 
client.println("HTTP/1.1 200 OK");
client.println("Content-Type: text/html");
client.println(""); 
client.println("<!DOCTYPE HTML>");
client.println("<html>");
  WiFi.scanNetworksAsync(prinScanResult);
  
  client.println("<div class=\"rssi\">");
   Serial.println(adb1);
   client.print("RSSI1= ");
   client.print(adb1);
   client.println("</div>");
   client.print("<br>");
   
  client.println("<div class=\"rssi1\">");
   Serial.println(adb2);
   //adb2
   client.print("RSSI2= ");
   client.print(adb2);
   client.println("</div>");
   //delay(50);

delay(600);

   
//client.print("<meta http-equiv=\"refresh\"content=\"1.4\">");


client.println("</html>");
 
delay(1);
 
}
