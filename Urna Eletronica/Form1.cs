using System.Security.Cryptography.X509Certificates;

namespace Urna_Eletronica
{
    public partial class Form1 : Form
    {
        public List<Candidato> candidatos = new List<Candidato>()
        {
            new Candidato("13", "Lula da Silva", "PT"),
            new Candidato("22", "Jair Bolsonaro", "PL"),
            new Candidato("45", "Aécio Neves", "PSDB"),
            new Candidato("15", "Michel Temer", "MDB"),
            new Candidato("40", "Eduardo Leite", "PSB"),
            new Candidato("12", "Ciro Gomes", "PDT"),
            new Candidato("19", "Sergio Moro", "PODEMOS"),
            new Candidato("50", "Guilherme Boulos", "PSOL"),
            new Candidato("25", "João Doria", "DEM"),
            new Candidato("11", "José Maria Eymael", "DC")
        };

        public Form1()
        {
            InitializeComponent();
      

        }


        private void btnConfirma_Click(object sender, EventArgs e)
        {
            var numero1 = n1.Text;
            var numero2 = n2.Text;
            var codigo = numero1 + numero2;

            Candidato candidato = candidatos.Where(x => x.ID == codigo).FirstOrDefault();
            
            var existsCandidato = candidatos.Where(x => x.ID == codigo).Any();

            if(numero1 != "" && numero2 != "" &&  existsCandidato)
            {
                textName.Text = candidato.Name;
                textPartido.Text = candidato.Partido;

                MessageBox.Show("Voto confirmado.");
            }
            else{

                MessageBox.Show("Número inválido ou não preenchido corretamente");
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InserirNumero(btn1.Text);
        }

        public void InserirNumero(string numero1)
        {
            if(n1.Text == "")
            {
                n1.Text = numero1;
            } else if (n1.Text != "")  {
                n2.Text = numero1;
            }

            

            }

        private void btn2_Click(object sender, EventArgs e)
        {
            InserirNumero(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InserirNumero(btn3.Text);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InserirNumero(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InserirNumero(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InserirNumero(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InserirNumero(btn7.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InserirNumero(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InserirNumero(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            InserirNumero(btn0.Text);
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            if (n1.Text != "" || n2.Text != "")
            {

                n1.Text = "";
                n2.Text = "";
            }
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voto anulado.");

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InserirNumero(btn0.Text);

        }
    }

    public class Candidato {

        public string ID { get; set; }
        public string Name { get; set; }
        public string Partido { get; set; }

        public Candidato(string iD, string name, string partido)
        {
            ID = iD;
            Name = name;
            Partido = partido;
        }
    }



}