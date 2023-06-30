namespace ProvaRecuperação_1Semestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_pontos.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contribuinte c = new Contribuinte();    
            c.nome = tx_nome.Text;
            c.cpf =mask_cpf.Text;
            c.idade = Convert.ToInt32(tx_datanasc.Text);
            c.tempo_carreira = Convert.ToInt32(tx_data_profissao.Text);
            c.profissao = cm_profissao.Text;
            c.sexo = cm_sexo.Text;
            int calculo;

            int resultado = c.Aposentadoria(c.idade, c.tempo_carreira, c.profissao, c.sexo, c.calculo);
            lb_pontos.Text = $"Faltam {resultado.ToString()} pontos para você se aposentar!";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_datanasc.Clear();
            tx_data_profissao.Clear();
            mask_cpf.Clear();
        }
    }
}