using System;
using System.IO.Ports;
namespace ConsoleApp1

{

    class Program
    {
        static void Main(string[] args)
        {
            // Open the serial port for communication with the Arduino
            SerialPort serialPort = new SerialPort("COM5", 9600);
            serialPort.Open();

            // Prompt user for input.
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
                        serialPort.WriteLine("30");
                        break;

                    case 'b':
                        serialPort.WriteLine("60");
                        break;

                    case 'c':
                        serialPort.WriteLine("90"); 
                        break;

                    case 'd':
                        serialPort.WriteLine("120");
                        break;

                    case 'e':
                        serialPort.WriteLine("150");
                        
                        break;

                    default:
                        serialPort.WriteLine("180");
                        
                        break;
                }
                System.Threading.Thread.Sleep(5000);
            }

            // Close the serial port
            serialPort.Close();
        }
    }
}
