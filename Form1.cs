using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMediaEscolar
{
    public partial class Form1 : Form
    {

        public string aluno;

        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;
        public int nota5;
        public int media;
        string classificacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void mediaButton_Click(object sender, EventArgs e)
        {
            resultado();
            nomeLabelPut.Text = aluno;
        }

        private void resultado()
        {

            nota1 = int.Parse(nota1TextBox.Text);
            nota2 = int.Parse(nota2TextBox.Text);
            nota3 = int.Parse(nota3TextBox.Text);
            nota4 = int.Parse(nota4TextBox.Text);
            nota5 = int.Parse(nota5TextBox.Text);
            
            media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            if (media > 89 && media <= 100)
            {
                mediaTextBox.Text = Convert.ToString(media);
            } else if (media >= 70 && media <= 89)
            {
                mediaTextBox.Text = Convert.ToString(media);
            } else if (media >= 50 && media <= 69)
            {
                mediaTextBox.Text = Convert.ToString(media);
            } else if (media >= 20 && media <= 49)
            {
                mediaTextBox.Text = Convert.ToString(media);
            } else if (media >= 0 && media <= 19)
            {
                mediaTextBox.Text = Convert.ToString(media);
            } else
            {
                mediaTextBox.Text = Convert.ToString(media);
            }
        }

        private void situacaoButton_Click(object sender, EventArgs e)
        {
            if (media > 89 && media <= 100)
            {
                classificacao = "Excelente";
                MessageBox.Show("O aluno " + aluno + " teve uma média de " + media + " sendo classificado com: " + classificacao + " no dia " + dateTimePicker.Text.ToString());
            }
            else if (media >= 70 && media <= 89)
            {
                classificacao = "Bom";
                MessageBox.Show("O aluno " + aluno + " teve uma média de " + media + " sendo classificado com: " + classificacao + " no dia " + dateTimePicker.Text.ToString());
            }
            else if (media >= 50 && media <= 69)
            {
                classificacao = "Suficiente";
                MessageBox.Show("O aluno " + aluno + " teve uma média de " + media + " sendo classificado com: " + classificacao + " no dia " + dateTimePicker.Text.ToString());
            }
            else if (media >= 20 && media <= 49)
            {
                classificacao = "Insuficiente";
                MessageBox.Show("O aluno " + aluno + " teve uma média de " + media + " sendo classificado com: " + classificacao + " no dia " + dateTimePicker.Text.ToString());
            }
            else if (media >= 0 && media <= 19)
            {
                classificacao = "Fraco";
                MessageBox.Show("O aluno " + aluno + " teve uma média de " + media + " sendo classificado com: " + classificacao + " no dia " + dateTimePicker.Text.ToString());
            }
            else
            {
                classificacao = "Inválido";
                MessageBox.Show("O aluno " + aluno + " teve uma média de " + media + " sendo classificado com: " + classificacao + " no dia " + dateTimePicker.Text.ToString());
            }
        }
    }
}
