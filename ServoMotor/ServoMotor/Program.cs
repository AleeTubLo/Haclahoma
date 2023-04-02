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

            // Calculate the target position for the servo motor based on the current letter
            switch (char.ToLower(letter))
            {

                case 'a':

                    serialPort.write("30");

                    break;

                case 'b':

                    serialPort.write("60");
                    
                    break;

                case 'c':

                    serialPort.write("90");

                    break;

                case 'd':

                    serialPort.write("120");

                    break;

                case 'e':

                    serialPort.write("150");

                    break;

                default:

                    targetPosition = 180;

                    break;

            }

            System.Threading.Thread.Sleep(1000);

        }

        // Close the serial port
        serialPort.Close();

    }

}
