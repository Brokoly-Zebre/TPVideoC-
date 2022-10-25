namespace TPBuffet
{
    public partial class Form1 : Form
    {
        private List<Diffusion> lesDiffusions = new List<Diffusion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            RestrictionAjout();

        }

        private void MajListDiffusion()
        {
            lstDiffusions.Items.Clear();
            foreach (Diffusion unediffusion in lesDiffusions)
            {
                lstDiffusions.Items.Add(unediffusion.getInfos());
            }

        }

        private void RestrictionAjout()
        {

            lblRecette.Visible = RdbFilm.Checked;
            txtRecette.Visible = RdbFilm.Checked;
            lblnbEpisodes.Visible = !RdbFilm.Checked;
            txtnbEpisodes.Visible = !RdbFilm.Checked;


        }

        private void RdbFilm_CheckedChanged(object sender, EventArgs e)
        {
            RestrictionAjout();

        }

        private void RdbSerie_CheckedChanged(object sender, EventArgs e)
        {
            RestrictionAjout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diffusion uneDiffusion;
            if (RdbFilm.Checked)
            {
                uneDiffusion = new Film(int.Parse(txtRecette.Text), txtTItre.Text, int.Parse(txtannee.Text));
            }
            else
            {
                uneDiffusion = new Serie(int.Parse(txtnbEpisodes.Text), txtTItre.Text, int.Parse(txtannee.Text));
            }

            lesDiffusions.Add(uneDiffusion);
            MajListDiffusion();
        }
    }
}