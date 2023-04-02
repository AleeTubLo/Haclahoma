using System.IO.Ports;
namespace CharacterToBinary
{

    class Program
    {

        public static void Main(string[] args)
        {

            SerialPort port = new SerialPort("COM5", 9600); // "COM5" has to be changed based on which ports are being used by the arduino

            port.Open();

            Console.Write("Enter your sequence of letters you with to convert to braille:");

            string input = Console.ReadLine();
            
            byte[] bytesOfInput = System.Text.Encoding.ASCII.GetBytes(input);

            foreach (byte b in bytesOfInput)
            {

                string binary = Convert.ToString(b, 2).PadLeft(8, '0');
                port.Write(binary);

            }

            port.Close();

        }


    }


}
