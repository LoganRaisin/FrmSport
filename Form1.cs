namespace FrmSport
{
    public partial class Exercice : Form
    {
        public Exercice()
        {
            InitializeComponent();
        }

        private void GrpSports_Enter(object sender, EventArgs e)
        {

        }

        private void TxtSport_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            string leSport = this.TxtSport.Text;
            this.Sport1.Text = leSport;
        }

        private void Exercice_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Premier test affichage");
        }
    }
}