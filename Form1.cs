using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Slector_de_cores
{
    public partial class Fselector : Form
    {
        public Fselector()
        {
            InitializeComponent();

            // Adicionar manipulador de eventos para o evento Resize
            this.Resize += Fselector_Resize;

        }


        private void AtualizarCor()
        {
            // Obter os valores de cada controle deslizante
            int vermelho = Tvermelho.Value;
            int verde = Tverde.Value;
            int azul = Tazul.Value;


            // Exibir os valores RGB nos rótulos correspondentes
            LVermelho.Text = $"Vermelho: {vermelho}";
            Lverde.Text = $"Verde: {verde}";
            Lblue.Text = $"Azul: {azul}";

            // Converter os valores para hexadecimal
            string hexaVermelho = vermelho.ToString("X2");
            string hexaVerde = verde.ToString("X2");
            string hexaAzul = azul.ToString("X2");

            // Exibir os valores hexadecimais no rótulo correspondente
            Thexa.Text = $" #{hexaVermelho}{hexaVerde}{hexaAzul}";

            // Exibir os valores RGB no rótulo lTRGB
            TRGB.Text = $" {vermelho}, {verde}, {azul}";


            // Criar uma nova cor com base nos valores dos controles deslizantes
            Color novaCor = Color.FromArgb(vermelho, verde, azul);

            // Atualizar a cor de algum elemento na sua interface gráfica
            // Exemplo: Mudar a cor de um painel (chame seu painel de "seuPainel")
            PCor.BackColor = novaCor;
        }

        private void Tvermelho_Scroll(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        private void Tverde_Scroll(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        private void Tazul_Scroll(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        private void Fselector_Resize(object sender, EventArgs e)
        {
            // Exibir os valores RGB no rótulo lTRGB quando o tamanho do formulário é alterado
            TRGB.Text = $"TRGB: {Tvermelho.Value}, {Tverde.Value}, {Tazul.Value}";
        }

        private void BCopiar_Click(object sender, EventArgs e)
        {
            // Copiar o valor hexadecimal para a área de transferência
            Clipboard.SetText(Thexa.Text);
            // adicionar uma message box codico copiado com sucesso 
            MessageBox.Show("Seu codico foi copiado com suçesso!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BCopiarRGB_Click(object sender, EventArgs e)
        {
            // Copiar o valor hexadecimal para a área de transferência
            Clipboard.SetText(TRGB.Text);
            // adicionar uma message box codico copiado com sucesso 
            MessageBox.Show("Seu codico foi copiado com suçesso!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
