namespace Project04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.Write("Enter Temprature :");
            temp = Convert.ToInt32(Console.ReadLine());

            switch(temp)
            {
                case 0:
                    Console.WriteLine("Frezing weather\n");
                    break;
                case 10:
                    Console.WriteLine("very cold weather\n");
                    break;
                case 20:
                    Console.WriteLine("Cold weather\n");
                    break;
                case 30:
                    Console.WriteLine("Normal Temprature\n");
                    break;
                case 40:
                    Console.WriteLine("Hot\n");
                    break;
                default:
                    Console.WriteLine("Very hot\n");
                    break;
            }

            Console.ReadLine();

        }
    }
}
