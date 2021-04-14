using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Dados;



namespace Caixa
{
    public partial class frmMenu : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int Index;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            Saque saque = new Saque();

            int.TryParse(txtValor.Text, out var valor);

            
            notas = saque.sacar((valor));
                
                if (notas == null)
                {
                    MessageBox.Show($"Não foi possivel efetuar o saque de R$ {valor}, tente outro valor.");
                }
                else
                {

                     MessageBox.Show("Saque realizado com Sucesso.\n\n\n" +
                       $"Total de Cedulas de R$100,00: {notas.MostrarNota100()}\n" +
                       $"Total de Cedulas de R$50,00: {notas.MostrarNota50()}\n" +
                       $"Total de Cedulas de R$20,00: {notas.MostrarNota20()}\n" +
                       $"Total de Cedulas de R$10,00: {notas.MostrarNota10()}\n");
                }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (Index < listPanel.Count - 1) listPanel[++Index].BringToFront();

            int.TryParse(txtValor.Text, out var valor);

            if (valor > 1000)
            {
                MessageBox.Show("O Limite para saque é de R$ 1000,00");
            }
            else if (valor < 10)
                MessageBox.Show("O Valor minimo para saque é de R$ 10,00");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Index > 0) listPanel[--Index].BringToFront();
        }
        private void btnDisponivel_Click(object sender, EventArgs e)
        {
            TelaNotas tela = new TelaNotas();
            tela.Show();
        }
    }
    }

