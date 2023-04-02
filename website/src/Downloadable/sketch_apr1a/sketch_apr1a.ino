#include <Servo.h>

Servo servo1;
Servo servo2;

void setup() {
  Serial.begin(9600);

  servo1.attach(9);
  servo2.attach(10);
}

void loop() {
  if (Serial.available()) {
    String binary = Serial.readStringUntil('\n');
    if (binary.length() == 8) {
      int servo1Pos = binary.substring(0, 4).toInt();
      int servo2Pos = binary.substring(4).toInt();

      servo1.write(map(servo1Pos, 0, 15, 0, 180));
      servo2.write(map(servo2Pos, 0, 15, 0, 180));
    }
  }
}
