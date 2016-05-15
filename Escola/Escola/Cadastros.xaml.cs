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
    /// Interaction logic for Cadastros.xaml
    /// </summary>
    public partial class Cadastros : Window
    {
        Aluno a;
        Professor p;
        Pessoa pess;

        public Cadastros()
        {
            InitializeComponent();
            dp.SelectedDate = DateTime.Now;
            pess = new Pessoa();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            string text = ((ComboBoxItem)cbTipo.SelectedItem).Content.ToString();
            if (text == "Aluno")
            {
                a = new Aluno();
                a.Nome = txtNom.Text;
                a.Curso = txtExtra.Text;
                a.Nascimento = dp.SelectedDate.Value;
                a.Matricula = txtMatricula.Text;
                pess.lp.Add(a);

                string aluno = "Nome: " + a.GetNome() + " - Nascimento: " + a.GetNascimento()
                + " - Matricula: " + a.GetMatricula() + " - Curso: " + a.Curso;
                lbPess.Items.Add(aluno);
            }
            else
            {
                p = new Professor();
                p.Nome = txtNom.Text;
                p.Diretoria = txtExtra.Text;
                p.Nascimento = dp.SelectedDate.Value;
                p.Matricula = txtMatricula.Text;
                pess.lp.Add(p);

                string prof = "Nome: " + p.GetNome() + " - Nascimento: " + p.GetNascimento()
                + " - Matricula: " + p.GetMatricula() + " - Diretoria: " + p.Diretoria;
                lbPess.Items.Add(prof);
            }
        }

        private void btnExibir_Click(object sender, RoutedEventArgs e)
        {
            lbNiver.Items.Clear();
            int mes = Convert.ToInt32(((ComboBoxItem)cbMes.SelectedItem).Content);
            List<Pessoa> list = pess.ExibirPessoas(mes);
            foreach (Pessoa k in list) lbNiver.Items.Add(k.Nome);
        }
    }
}
