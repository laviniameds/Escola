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
    /// Interaction logic for ExibNiver.xaml
    /// </summary>
    public partial class ExibNiver : Window
    {
        public ExibNiver()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, RoutedEventArgs e)
        {
            lbniver.ItemsSource = null;
            lbniver.ItemsSource = Pessoa.Aniversariantes(Aluno.ListarAlunos(), Professor.ListarProfs(), 
                Convert.ToInt32(((ComboBoxItem)comboBox.SelectedItem).Content));
        }
    }
}
