using System;
using System.IO.Ports;

class Program
{
    static void Main(string[] args)
    {
        // Open the serial port for communication with the Arduino
        SerialPort serialPort = new SerialPort("COM3", 9600);
        serialPort.Open();

        // Set the initial position of the servo motor to 0 degrees
        int currentPosition = 0;

        // Define the sequence of letters to be translated
        string sequence = "ABC";

        // Loop through each letter in the sequence
        foreach (char letter in sequence)
        {
            // Calculate the target position for the servo motor based on the current letter
            int targetPosition = ((int)letter - 65) * 30;

            // Move the servo motor to the target position
            for (int i = currentPosition; i < targetPosition; i++)
            {
                serialPort.Write(i.ToString());
                currentPosition = i;
                System.Threading.Thread.Sleep(15);
            }
        }

        // Close the serial port
        serialPort.Close();
    }
}
