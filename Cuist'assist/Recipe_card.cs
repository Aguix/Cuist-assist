using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
	public partial class Recipe_card : UserControl {
		public Recipe_card(int codeRecette, string description, int nbPersonnes, int tempsCuisson, string imageDesc, int categPrix, string Commentaire) {
			InitializeComponent();

			lblNomRecette.Text = description;
			lblPersonnes.Text = nbPersonnes + " personnes";
			lblTemps.Text = tempsCuisson + (tempsCuisson > 1 ? "minutes" : "minute");
			lblCout.Text = "cat budget : " + categPrix;
			lblDescriptionRecette.Text = Commentaire;
		}
	}
}
