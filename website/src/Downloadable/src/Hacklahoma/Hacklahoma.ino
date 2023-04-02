#include <ArduinoSTL.h>
#include <Servo.h>
#include <string>
  Servo myServo;
  const int startAngle = 0;
  int angle = 0;
  String input = Serial.readString();
  std::vector<char> myVector(input.begin(), input.end());
 
  void setup() 
  { 
    myServo.attach(6);
    for(int i = 0; i < input.length(); ++i)
    {
      braille(myVector[i]);
    }
  }

  void braille(char input)
  {
    switch(input)
    {
      case 'a':
        angle = 30;
      case 'b':
        angle = 60;
      case 'c':
        angle = 90;
      default:
        angle = 180;
    }

    myServo.write(angle);
    delay(5000);
    myServo.write(startAngle);
    delay(5000);
  }



  void loop() 
  {
      
  }
