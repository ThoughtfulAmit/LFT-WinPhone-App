using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;
using System.IO;
using Microsoft.Phone.Shell;

namespace LFT_Win_Phone_App
{
    public partial class Settings : PhoneApplicationPage
    {
        public Settings()
        {
            InitializeComponent();
        }

     
        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (StreamReader sr = new StreamReader(store.OpenFile("stupidamigo.txt", FileMode.Open, FileAccess.Read)))
                {
                    tb1_s.Text = sr.ReadLine();
                    tb2_s.Text = sr.ReadLine();
                    tb3_s.Text = sr.ReadLine();
                }


            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tb1_s.Text = "";
            tb2_s.Text = "";
            tb3_s.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var appStorage = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = "stupidamigo.txt";

            using (var file = appStorage.OpenFile(filename, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
            {
                using (var write = new StreamWriter(file))
                {
                    write.WriteLine(tb1_s.Text);
                    write.WriteLine(tb2_s.Text);
                    write.WriteLine(tb3_s.Text);
                }
            }
            PhoneApplicationService.Current.State["p_name"] = tb1_s.Text;
            PhoneApplicationService.Current.State["p_clg"] = tb2_s.Text;
            PhoneApplicationService.Current.State["p_pwd"] = tb3_s.Text;

            MessageBox.Show("Details saved!!");
        }
    }
}