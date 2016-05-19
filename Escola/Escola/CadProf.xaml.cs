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
    /// Interaction logic for CadProf.xaml
    /// </summary>
    public partial class CadProf : Window
    {
        public CadProf()
        {
            InitializeComponent();
            dpNasc.SelectedDate = DateTime.Now;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Professor p = new Professor(txtNome.Text, dpNasc.SelectedDate.Value, 
                txtMatricula.Text, txtDiretoria.Text);
            p.Cadastrar(p);
            lbAlunos.ItemsSource = null;
            lbAlunos.ItemsSource = Professor.ListarProfs().ToList();
        }
    }
}
