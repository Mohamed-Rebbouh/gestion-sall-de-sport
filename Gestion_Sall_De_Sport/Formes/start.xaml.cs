using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace Gestion_Sall_De_Sport.Formes
{
    /// <summary>
    /// Logique d'interaction pour start.xaml
    /// </summary>
    public partial class start : Window
    {
        public start()
        {
            InitializeComponent();
        }

        private void home_button_Click(object sender, RoutedEventArgs e)
        {
            DataTable try_ = Classes.BaseDeDonner.Select_Table("entrinement");
            DataShow.ItemsSource = try_.DefaultView;          
        }
    }
}
