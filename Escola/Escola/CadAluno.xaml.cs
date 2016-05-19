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
    /// Interaction logic for CadAluno.xaml
    /// </summary>
    public partial class CadAluno : Window
    {
        public CadAluno()
        {
            InitializeComponent();
            dpNasc.SelectedDate = DateTime.Now;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno(txtNome.Text, dpNasc.SelectedDate.Value, txtMatricula.Text,
                txtCurso.Text);
            a.Cadastrar(a);
            lbAlunos.ItemsSource = null;
            lbAlunos.ItemsSource = Aluno.ListarAlunos().ToList();
        }
    }
}
