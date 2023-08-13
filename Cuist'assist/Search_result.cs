using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
	public partial class Search_result : UserControl {
		public Search_result(List<int> ids_ingredients_choisis, List<String> str_ingredients_choisis, List<int> ids_type_plats, int budget, int duree, int note_min) {
			InitializeComponent();
			this.Resize += Search_Result_Replace;
			update(ids_ingredients_choisis, str_ingredients_choisis, ids_type_plats, budget, duree, note_min);
		}

		private void Search_Result_Replace(object sender, EventArgs e) {
		}


		private void update(List<int> ids_ingredients_choisis, List<String> str_ingredients_choisis, List<int> ids_type_plats, int budget, int duree, int note_min) {
			// Update le header
			header.update(str_ingredients_choisis, budget, duree, note_min);


			// Update les recettes affichés
				// Faire la requete

				// Afficher les recettes correspondantes
		}
	}
}
