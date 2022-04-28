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
            List<Label> listeSports = new List<Label>(); //creation de la liste
            listeSports.Add (new Label() { Text = leSport } ); // ajout d'un objet label a chaque click
            foreach( Label sport in listeSports) //parcours de liste pour afficher dans le groupe
            {
                ///savoir comment ajouter le label au bon endroit
                ///changer les coordonées de la prochaine a chaque fois que la boucle fini
                ///donc besoin d'une variable qui s'incrémente.
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