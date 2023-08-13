using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
    public partial class Header : UserControl
    {

        private List<String> ingredients_choisis = new List<String>();
        private int budget = 0;
        private int temps = 0;
        private int note_min = 0;


		public Header()
        {
            InitializeComponent();
            
            this.Resize += rpn_header_Resize;
        }


        public void update(List<String> ingredients_choisis, int budget, int temps, int note) {
			this.ingredients_choisis = ingredients_choisis;
			this.budget = budget;
			this.temps = temps;
            this.note_min = note;

			lblIngredients.Text = "Ingredients sélectionnés : " + string.Join(", ", ingredients_choisis);
            txtBudget.Text = budget.ToString();
            ctbTemps.Value = temps;
            txtNote.Text = note_min.ToString();
        }

        private void Header_Load(object sender, EventArgs e)
        {

            // Définir les propriétés de la trackbar
            ctbTemps.Width = 100;
            ctbTemps.Height = 20;
            ctbTemps.Minimum = 0;
            ctbTemps.Maximum = 135;

            // Définir un style personnalisé pour le curseur
            ctbTemps.TickStyle = TickStyle.None;
            ctbTemps.AutoSize = false;

            // Personnaliser l'apparence du curseur
            ctbTemps.BackColor = Color.FromArgb(23, 29, 31);
            ctbTemps.ForeColor = Color.White;
            ctbTemps.Cursor = Cursors.Hand;

            // Gérer l'événement ValueChanged de la trackbar
            ctbTemps.ValueChanged += TrackBar_ValueChanged;
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {

            if (this.Width > 1350)
            {
                lblTemps.Text = "Temps (en min) : " + ctbTemps.Value.ToString();
            }
            else
            {
                lblTemps.Text = "Temps : " + ctbTemps.Value.ToString();
            }
        }

        private void rpn_header_Resize(object sender, EventArgs e) {
            rbtn_retour.Location = new Point((int)Math.Truncate(this.Width * 0.010419), (int)Math.Truncate(this.Height * 0.051613));
            rbtn_retour.Width = (int)Math.Truncate(this.Width * 0.206686);
            rbtn_retour.Height = (int)Math.Truncate(this.Height * 0.193548);
            if(rbtn_retour.Width < 180) {
                rbtn_retour.Text = "<-- Retour";
            } else if(rbtn_retour.Width < 270) {
                rbtn_retour.Text = "<-- Retourner à la selection";
            } else {
                rbtn_retour.Text = "<-- Retourner à la selection des ingrédients";
            }

            lblIngredients.Location = new Point((int)Math.Truncate(this.Width * 0.251007), (int)Math.Truncate(this.Height * 0.051613));
            lblIngredients.Width = (int)Math.Truncate(this.Width * 0.358295);
            lblIngredients.Height = (int)Math.Truncate(this.Height * 0.154839);

            lblBudget.Location = new Point((int)Math.Truncate(this.Width * 0.016284), (int)Math.Truncate(this.Height * 0.566774));
            lblBudget.Width = (int)Math.Truncate(this.Width * 0.051301);
            lblBudget.Height = (int)Math.Truncate(this.Height * 0.129032);

            txtBudget.Location = new Point((int)Math.Truncate(this.Width * 0.100989), (int)Math.Truncate(this.Height * 0.579677));
            txtBudget.Width = (int)Math.Truncate(this.Width * 0.068564);
            txtBudget.Height = (int)Math.Truncate(this.Height * 0.129032);

            lblNote.Location = new Point((int)Math.Truncate(this.Width * 0.213284), (int)Math.Truncate(this.Height * 0.566774));
            lblNote.Width = (int)Math.Truncate(this.Width * 0.051301);
            lblNote.Height = (int)Math.Truncate(this.Height * 0.129032);

            txtNote.Location = new Point((int)Math.Truncate(this.Width * 0.354350), (int)Math.Truncate(this.Height * 0.579677));
            txtNote.Width = (int)Math.Truncate(this.Width * 0.068564);
            txtNote.Height = (int)Math.Truncate(this.Height * 0.129032);

            lblTemps.Location = new Point((int)Math.Truncate(this.Width * 0.441813), (int)Math.Truncate(this.Height * 0.566774));
            lblTemps.Width = (int)Math.Truncate(this.Width * 0.093692);
            lblTemps.Height = (int)Math.Truncate(this.Height * 0.129032);

            ctbTemps.Location = new Point((int)Math.Truncate(this.Width * 0.555331), (int)Math.Truncate(this.Height * 0.589677));
            ctbTemps.Width = (int)Math.Truncate(this.Width * 0.131537);
            ctbTemps.Height = (int)Math.Truncate(this.Height * 0.189032);
            if(this.Width > 1350) {
                lblTemps.Text = "Temps (en min) : " + ctbTemps.Value.ToString();
            } else {
                lblTemps.Text = "Temps : " + ctbTemps.Value.ToString();
            }

            rbtn_tri.Location = new Point((int)Math.Truncate(this.Width * 0.707569), (int)Math.Truncate(this.Height * 0.534516));
            int tempWidth_rbtn_tri = rbtn_tri.Width;
            rbtn_tri.Width = (int)Math.Truncate(this.Width * 0.209197);
            if(rbtn_tri.Width > 185) {
                rbtn_tri.Width = 185;
            }
            rbtn_tri.Height = (int)Math.Truncate(this.Height * 0.23);
        }
	}
}
