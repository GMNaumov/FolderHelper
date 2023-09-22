using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderHelper
{
    internal class Solution : IFolderHandler
    {
        private const string rootPath = @"C:\";

        public string CreateNewFolder(string folderName)
        {
            string folderPath = rootPath + folderName;
            if (!Directory.Exists(folderPath))
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(folderPath);
                return directoryInfo.FullName;
            }
            else
            {
                Console.WriteLine("The folder {0} is already exists!", folderPath);
                return string.Empty;
            }
        }

        public string CreateNewFolderInTemp(string folderName)
        {
            throw new NotImplementedException();
        }
    }
}
