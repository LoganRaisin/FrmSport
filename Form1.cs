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
            List<Label> listeSports = new List<Label>();
            listeSports.Add (new Label() { Text = leSport } );
            foreach( Label sport in listeSports)
            {

            }
        }

        /// <summary>
        /// Affichage avant lancement de l'application.
        /// </summary>
        private void Exercice_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Premier test affichage");
        }

        /// <summary>
        /// bouton pour quitter
        /// </summary>
        private void BtnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}