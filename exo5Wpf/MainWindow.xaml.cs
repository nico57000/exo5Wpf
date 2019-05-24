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
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace exo5Wpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private ObservableCollection<Livre> livres = new ObservableCollection<Livre>() {
        };
        public MainWindow()
        {
            InitializeComponent();
            data.ItemsSource = livres;
            data.IsReadOnly = true;
        }

        private void Charger(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "JSON Files | *.json";
            if (open.ShowDialog() == true)
            {
                Stream stm3 = new StreamReader("save.json").BaseStream;
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ObservableCollection<Livre>));
                ObservableCollection<Livre> tmp = (ObservableCollection<Livre>)ser.ReadObject(stm3);
                stm3.Close();
                livres.Clear();
                foreach (Livre item in tmp)
                {
                    livres.Add(item);
                }
            }
        }

        private void Save(object sender, RoutedEventArgs e)
        {

            Stream stm = new StreamWriter("save.json").BaseStream;
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ObservableCollection<Livre>));
            ser.WriteObject(stm, livres);
            stm.Close();

        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            data.IsReadOnly = false;
        }
    }
}
