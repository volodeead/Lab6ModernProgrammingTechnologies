using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab6Interfaces;
using System.ServiceModel;
using System.IO;

namespace Lab6Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IDirectoryService> channelFactory = new ChannelFactory<IDirectoryService>(new BasicHttpBinding(), "http://localhost:8000/DirectoryService");
            IDirectoryService proxy = channelFactory.CreateChannel();

            while (true)
            {
                Console.WriteLine("Enter the path to get directories (e.g., C:\\), or 'exit' to close:");
                string path = Console.ReadLine();

                if (path.ToLower() == "exit")
                {
                    break;
                }

                try
                {
                    var directories = proxy.GetDirectories(path);

                    Console.WriteLine("Output:");

                    foreach (string directory in directories)
                    {

                        Console.WriteLine(directory);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

    }
}
