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
using System.Windows.Shapes;

namespace Escola 
{
    /// <summary>
    /// Interaction logic for Aniversariantes.xaml
    /// </summary>
    public partial class Aniversariantes : Window
    {
        public Aniversariantes()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, RoutedEventArgs e)
        {
            Pessoa ip;
            ip.ExibirPessoas(comboBox.SelectedValue.ToString());          
        }
    }
}
