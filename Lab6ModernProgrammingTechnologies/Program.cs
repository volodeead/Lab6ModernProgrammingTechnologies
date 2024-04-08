using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using Lab6ModernProgrammingTechnologies.Services;

namespace Lab6ModernProgrammingTechnologies
{
    class Program
    {
        static void Main(string[] args)
        {
            // Додаємо базову адресу до ServiceHost
            Uri baseAddress = new Uri("http://localhost:8000/DirectoryService");

            using (ServiceHost host = new ServiceHost(typeof(DirectoryService), baseAddress))
            {
                // Відкриття служби для прослуховування вхідних запитів
                host.Open();

                Console.WriteLine("Server is running... Press <Enter> to stop.");
                Console.ReadLine(); // Чекаємо на вхід від користувача перед закриттям
            }
        }

    }
}
