using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Text.RegularExpressions;

namespace FIleRenamer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "RenameTheFile!";
        }

        private void gobtn_Click(object sender, RoutedEventArgs e)
        {
            Rename DoRename = new Rename(pathtxtbx.Text, subdirschkbx.IsEnabled);

            //Match checkpattern = Regex.Match(pathtxtbx.Text, stringtxtbx.Text);
            string pattern = @".*" + stringtxtbx.Text + @".*";
            Regex regex = new Regex(pattern);
            
            foreach (string file in DoRename.FilesFromDir)
            {
                foreach (Match match in regex.Matches(file))
                {
                    // From System.IO.
                    File.Move(file, file.Replace(stringtxtbx.Text, @""));
                    
                }
            }
           
        }

        private void subdirschkbx_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
