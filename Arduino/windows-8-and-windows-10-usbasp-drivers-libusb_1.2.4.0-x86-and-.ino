#include <ESP8266WiFi.h>  
WiFiClient client;
WiFiServer server(80);
const char* ssid = "Abo kamel";
const char* password = "123456aa";
String  data ="";
int leftMotorForward = 2;     /* GPIO2(D4) -> IN3   */
int rightMotorForward = 15;   /* GPIO15(D8) -> IN1  */
int leftMotorBackward = 0;    /* GPIO0(D3) -> IN4   */
int rightMotorBackward = 13;  /* GPIO13(D7) -> IN2  */

void setup() {
   Serial.begin(9600);
  delay(10);
  pinMode(D4, OUTPUT);
  pinMode(D5, OUTPUT);
  pinMode(D6, OUTPUT);
  pinMode(D7, OUTPUT);
  pinMode(D8, OUTPUT);
  //digitalWrite(D5,1);
    /* Connect to WiFi network */
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
  /* start server communication */
  server.begin();
  Serial.println("Server started");
 
  /* print the IP address */
  Serial.print("Use this URL to connect: ");
  Serial.print("http://");
  Serial.print(WiFi.localIP());
  Serial.println("/");
 
}

void loop() {
   
  /* If the server available, run the "checkClient" function */  
    client = server.available();
    if (!client) return; 
    data = checkClient ();

/************************ Run function according to incoming data from application *************************/

      if(data=="f")
 {  analogWrite(D8,700);
 analogWrite(D7,0);
 analogWrite(D6,700);
 analogWrite(D5,0);
 digitalWrite(D4,1);
 delay(500);
 stop();
   Serial.println("  forward is Ok"); }
  else  if(data=="b")
 {  analogWrite(D8,0);
 analogWrite(D7,700);
 analogWrite(D6,0);
 analogWrite(D5,700);
 delay(500);
 stop();
   Serial.println("  back is Ok"); }
 else if(data=="r")
 {  analogWrite(D8,900);
 analogWrite(D7,0);
 analogWrite(D6,0);
 analogWrite(D5,0);
 delay(500);
 stop();
   Serial.println("  right is Ok"); }
else  if(data=="l")
 {  analogWrite(D8,0);
 analogWrite(D7,0);
 analogWrite(D6,900);
 analogWrite(D5,0);
 delay(500);
 stop();
   Serial.println("  left is Ok"); }
    else stop();
 ///----------------------------------------------------------------------

    /* If the incoming data is "forward", run the "MotorForward" function */
     if (data == "forward") MotorForward();
    /* If the incoming data is "backward", run the "MotorBackward" function */
    else if (data == "backward") MotorBackward();
    /* If the incoming data is "left", run the "TurnLeft" function */
    else if (data == "left") TurnLeft();
    /* If the incoming data is "right", run the "TurnRight" function */
    else if (data == "right") TurnRight();
    /* If the incoming data is "stop", run the "MotorStop" function */
    else if (data == "stop") MotorStop();
    else MotorStop();
  /* Web Browser */
  client.println("HTTP/1.1 200 OK");
  client.println("Content-Type: text/html");
  client.println("");
  client.println("<!DOCTYPE HTML>");
  client.println("<html>");
  client.println("<head>");
  client.println("<title> MERT ARDUINO and TECH </title>");
  client.println("</head>");
  client.println("<body>");
  client.println("<center>");
  client.println("<h2> WiFi CONTROLLED TANK via ESP8266 </h2>");
  client.println("<br><br>");
  client.println("<hr>");

  /* Buttons */
  client.println("<br><br>");
  client.println("<a href=\"/forward\"\"><button>FORWARD </button></a>");
  client.println("<a href=\"/backward\"\"><button>BACKWARD </button></a><br />");
  client.println("<br><br>");
  client.println("<a h]ref=\"/left\"\"><button>LEFT </button></a>");
  client.println("<a href=\"/right\"\"><button>RIGHT </button></a><br />");
  client.println("<br><br>");
  client.println("<a href=\"/stop\"\"><button>STOP </button></a><br />");

  client.println("<br><br>");
  client.println("<hr>");
  client.println("<br><br>");
  client.println("<pre><h3>Mert Arduino and Tech - YouTube</br> WiFi controlled Tank via Web Browser (WiFibot/Web/WiFi/IoT/ESP8266)</br> NodeMCU ESP8266 Project</br></h3></pre>");
  client.println("</center>");
  client.println("</body>");
  client.println("</html>");
  data="hhhhh";
}

/********************************************* FORWARD *****************************************************/
void MotorForward(void)   
{
  digitalWrite(D6,HIGH);
  digitalWrite(D8,HIGH);
  digitalWrite(D5,LOW);
  digitalWrite(D7,LOW);
}

/********************************************* BACKWARD *****************************************************/
void MotorBackward(void)   
{
  digitalWrite(D5,HIGH);
  digitalWrite(D7,HIGH);
  digitalWrite(D6,LOW);
  digitalWrite(D8,LOW);
}

/********************************************* TURN LEFT *****************************************************/
void TurnLeft(void)   
{
  digitalWrite(leftMotorForward,LOW);
  digitalWrite(rightMotorForward,HIGH);
  digitalWrite(rightMotorBackward,LOW);
  digitalWrite(leftMotorBackward,HIGH);  
}

/********************************************* TURN RIGHT *****************************************************/
void TurnRight(void)   
{
  digitalWrite(leftMotorForward,HIGH);
  digitalWrite(rightMotorForward,LOW);
  digitalWrite(rightMotorBackward,HIGH);
  digitalWrite(leftMotorBackward,LOW);
}

/********************************************* STOP *****************************************************/
void MotorStop(void)   
{
  digitalWrite(D8,LOW);
  digitalWrite(D7,LOW);
  digitalWrite(D6,LOW);
  digitalWrite(D5,LOW);
}

/********************************** RECEIVE DATA FROM the WEB ******************************************/
String checkClient (void)
{
  while(!client.available()) delay(1); 
  String request = client.readStringUntil('\r');
  request.remove(0, 5);
  request.remove(request.length()-9,9);
  return request;
}
void stop(void)   
{
 digitalWrite(D5,0);
 digitalWrite(D6,0);
 digitalWrite(D7,0);
 digitalWrite(D8,0);
 digitalWrite(D4,0);
  Serial.print("  stop is Ok");
}
