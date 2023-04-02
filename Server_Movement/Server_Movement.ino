#include <Servo.h>

Servo servo;
const int startAngle = 0;

void setup() 
{
  //basics
  Serial.begin(9600);
  servo.attach(6);
  
}

void loop() {
    if(Serial.available() > 0) {
    int angle = Serial.parseInt(); // read the integer value from the serial port
    servo.write(angle); // set the servo to the specified angle
  }
  else
  {
    servo.write(0);
  }
}
