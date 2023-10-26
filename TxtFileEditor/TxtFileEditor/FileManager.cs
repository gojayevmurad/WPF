using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtFileEditor
{
    public static class FileManager
    {
        public static string FilePath { get; set; } = String.Empty;

        public static void WriteFile(string content) => File.WriteAllText(FilePath, content);
        
        public static string ReadFile() => File.ReadAllText(FilePath);
    }
}
