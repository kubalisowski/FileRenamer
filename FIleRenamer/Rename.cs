using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace FIleRenamer
{
    class Rename
    {
        public string[] FilesFromDir = new string[] { "" };
        public Rename(string path, bool searchoption)
        {
            SearchOption SubDirs(bool includeSubDirs)
            {
                if (searchoption)
                    return SearchOption.AllDirectories;
                else
                    return SearchOption.AllDirectories;
            }

            try
            {
                FilesFromDir = Directory.GetFiles(path, "*.*", SubDirs(searchoption));
            }
            catch
            {
                MessageBox.Show("Please check provided path!");
            }
        }
    }

}

