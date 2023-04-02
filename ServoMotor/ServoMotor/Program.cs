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

        // The position to where the motor will move to.
        int targetPosition = 0;

        // Promp user for input.
        Console.Write("Enter the zone of where the blaster shots will be sent: ");


        // Define the sequence of letters to be translated
        string sequence = Console.ReadLine();



        // Loop through each letter in the sequence
        foreach (char letter in sequence)
        {

            if (letter == null)
            {

                currentPosition = 180;

            }

            // Calculate the target position for the servo motor based on the current letter
            switch (char.ToLower(letter))
            {

                case 'a':

                    targetPosition = 30;

                    break;

                case 'b':

                    targetPosition = 60;

                    break;

                case 'c':

                    targetPosition = 90;

                    break;

                case 'd':

                    targetPosition = 120;

                    break;

                case 'e':

                    targetPosition = 150;

                    break;

                default:

                    targetPosition = 0;

                    break;

            }
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
