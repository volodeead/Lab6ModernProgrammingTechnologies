using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab6Interfaces;
using System.IO;

namespace Lab6ModernProgrammingTechnologies.Services
{
    public class DirectoryService : IDirectoryService
    {
        public List<string> GetDirectories(string path)
        {
            Console.WriteLine($"[{DateTime.Now}] INFO: Received request for path: {path}");

            try
            {
                var directories = new List<string>(Directory.GetDirectories(path));
                Console.WriteLine($"[{DateTime.Now}] INFO: Found {directories.Count} directories.");
                return directories;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"[{DateTime.Now}] ERROR: {ex.Message}");
                return new List<string>();
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"[{DateTime.Now}] ERROR: Access denied. {ex.Message}");
                return new List<string>();
            }

        }
    }

}

