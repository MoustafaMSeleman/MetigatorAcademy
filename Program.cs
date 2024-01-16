using EFCore_Metigator_ep10.Configuration;

namespace EFCore_Metigator_ep10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AppDbContext()) 
            {
                foreach(var section in context.Sections) 
                {
                    Console.WriteLine(section);
                }
            }
        }
    }
}
