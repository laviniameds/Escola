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
            dp.SelectedDate = DateTime.Now;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno(txtNom.Text, dp.SelectedDate.Value.Date,
                txtMatricula.Text, txtCurso.Text);

            string aluno = "Nome: " + a.GetNome() + " - Nascimento: " + a.GetNascimento()
                + " - Matricula: " + a.GetMatricula() + " - Curso: " + a.GetCurso(); 
            lbAluno.Items.Add(aluno);
        }

        private void btnExibir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
