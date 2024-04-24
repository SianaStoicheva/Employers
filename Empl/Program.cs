
namespace Empl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko slujiteli vavejdash: ");
            int count = int.Parse(Console.ReadLine());

            List<Employers> employers = new List<Employers>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] inputS = input.Split().ToArray();

                string name = inputS[0];//Console.ReadLine();
                double salary = double.Parse(inputS[1]);
                string position = inputS[2];
                string filed = inputS[3];
                string email = null;
                if (inputS.Length > 4)
                {
                     email = inputS[4];
                }
                int age = 0;
                if (inputS.Length > 5)
                {
                     age = int.Parse(inputS[5]);
                }

                Employers currentEmpl = new Employers(name,salary,position,filed,email,age);
                
                employers.Add(currentEmpl);
            }

            PrintAllEmployers(employers);
        }

        private static void PrintAllEmployers(List<Employers> employers)
        {
            foreach (Employers item in employers)
            {
                item.PrintMe();
            }
        }

    }
}
