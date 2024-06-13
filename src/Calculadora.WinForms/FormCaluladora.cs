namespace Calculadora.WinForms
{
    public partial class FormCaluladora : Form
    {
        private Operacao.Matematica.Calculadora Calculadora { get; set; }

        public FormCaluladora()
        {
            InitializeComponent();
            Calculadora = new Operacao.Matematica.Calculadora();
            rdbAdicao.Checked = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Calculadora.RealizarOperacaoMatematica();
                this.listBoxResultados.Items.Add(Calculadora.ResultadoOperacao);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void rdbOperacao(object sender, EventArgs e)
        {
            if (this.rdbAdicao.Checked)
            {
                Calculadora.Operacao = "1";
            }
            if (rdbMultiplicacao.Checked)
            {
                Calculadora.Operacao = "3";
            }
            if (rdbSubtracao.Checked)
            {
                Calculadora.Operacao = "2";
            }
            if (rdbDivisao.Checked)
            {
                Calculadora.Operacao = "4";
            }
        }

        private void txtPrimeiroNumerador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calculadora.PrimeiroNumerador = Decimal.Parse(txtPrimeiroNumerador.Text);
            }
            catch
            {
                Calculadora.PrimeiroNumerador = 0;
            }
            finally
            {
                CheckCalcularButton();
            }
        }

        private void txtSegundoNumerador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calculadora.SegundoNumerador = Decimal.Parse(txtSegundoNumerador.Text);
            }
            catch
            {
                Calculadora.SegundoNumerador = 0;
            }
            finally
            {
                CheckCalcularButton();
            }
        }

        private void CheckCalcularButton()
        {
            if (Calculadora.PrimeiroNumerador != null
                && Calculadora.SegundoNumerador != null)
            {
                btnCalcular.Enabled = true;
            }
        }
    }
}
