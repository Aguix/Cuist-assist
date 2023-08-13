using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
	public partial class SearchPage : UserControl {

		const string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\baseFrigov2023.mdb";
		OleDbConnection connec = new OleDbConnection();
		DataSet ds = new DataSet();


		private List<String> str_ingredients_choisis = new List<String>();
		private List<int> ids_ingredients_choisis = new List<int>();
		private List<int> ids_type_plats = new List<int>();
		private int budget = 0;
		private int duree = 0;
		private int note_min = 0;


		//private Page_resultat_recettes res;

		public SearchPage() {
			InitializeComponent();

			this.Resize += SearchPage_Replace;

			try {
				ChargementDsLocal();
			} catch(Exception ex) {
			}

			try {
				ChargementCBO(cbxIngredients, "Famille", "libFamille", "codeFamille");
			} catch(Exception ex2) {
			}

			try {
				int top = 0;
				int left = 10;
				foreach(DataRow row in ds.Tables["Catégories"].Rows) {
					CustomCheckbox rcb = new CustomCheckbox();
					rcb.Text = row["libCategorie"].ToString();
					rcb.Tag = row["codeCategorie"].ToString();
					rcb.CheckedChanged += plat_selectionne;
					pnl_Familles.Controls.Add(rcb);
					rcb.Font = new Font(rcb.Font.FontFamily, 12);

					rcb.Location = new Point(left, top);

					if(left + rcb.Width + 5 > pnl_Familles.Width * 0.8) {
						left = 10;
						top += rcb.Height + 5;
					} else {
						left += rcb.Width + 5;
					}
				}
			} catch(Exception ex3) {
			}

			/*res = new Page_resultat_recettes();
			this.Controls.Add(res);
			res.Visible = false;
			res.Enabled = false;*/
		}

		/*private void TrackBar_ValueChanged(object sender, EventArgs e) {
			TrackBar trackBarTemps = (TrackBar)sender;
			int duree = trackBarTemps.Value;
			label7.Text = duree.ToString() + " minute";
			if(duree > 1) { label7.Text += "s"; }
		}*/



		
		public void ChargementDsLocal() {
			connec.ConnectionString = chcon;
			connec.Open();
			DataTable schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

			foreach(DataRow row in schemaTable.Rows) {
				if(row[2].ToString() != "Table des erreurs") {
					string req = "SELECT * FROM " + row[2].ToString();
					OleDbDataAdapter da = new OleDbDataAdapter(req, connec);
					da.Fill(ds, row[2].ToString());
				}
			}

			connec.Close();
		}

		private void ChargementCBO(ComboBox cb, string nomTable, string champAffiche, string champRetour) {
			cb.DataSource = ds.Tables[nomTable];
			cb.DisplayMember = champAffiche;
			cb.ValueMember = champRetour;
		}


		// Responsive
		private void SearchPage_Replace(object sender, EventArgs e) {
			int milieu = this.ClientSize.Width / 2;

			int navbarheight = 80;
			int hauteur_pannels = (int)(this.ClientSize.Height * 1) - navbarheight - 10;
			double sep = milieu * 0.01;

			// Calcul de la largeur des custompanel et du bouton valider
			cpn_Ingredients.Width = milieu - 20;
			cpn_Type.Width = milieu - 20;
			cpn_Budget.Width = milieu - 20;
			cpn_Duree.Width = milieu / 2 - 15;
			cpn_Note.Width = milieu / 2 - 15;
			btn_recherche.Width = milieu - 20;

			// Calcul de la hauteur des custompanel et du bouton valider
			cpn_Ingredients.Height = hauteur_pannels;
			cpn_Type.Height = (int)(hauteur_pannels * 0.40);
			cpn_Budget.Height = (int)(hauteur_pannels * 0.20);
			cpn_Duree.Height = (int)(hauteur_pannels * 0.25);
			cpn_Note.Height = (int)(hauteur_pannels * 0.25);
			btn_recherche.Height = (int)(hauteur_pannels * 0.1);


			// Placement des custompanel et du bouton valider
			int space = (int)(hauteur_pannels - cpn_Type.Height - cpn_Budget.Height - cpn_Duree.Height - btn_recherche.Height) / 3;
			cpn_Ingredients.Location = new Point(10, 10);
			cpn_Type.Location = new Point(milieu + 10, 10);
			cpn_Budget.Location = new Point(milieu + 10, cpn_Type.Location.Y + cpn_Type.Height + space);
			cpn_Duree.Location = new Point(milieu + 10, cpn_Budget.Location.Y + cpn_Budget.Height + space);
			cpn_Note.Location = new Point(cpn_Duree.Location.X + cpn_Duree.Width + 10, cpn_Budget.Location.Y + cpn_Budget.Height + space);
			btn_recherche.Location = new Point(milieu + 10, cpn_Duree.Location.Y + cpn_Duree.Height + space);


			// Pour etre sur de reset les tailles et positions
			cpn_Ingredients.Invalidate();
			cpn_Type.Invalidate();
			cpn_Budget.Invalidate();
			cpn_Duree.Invalidate();
			cpn_Note.Invalidate();
			btn_recherche.Invalidate();


			// Placement des controls du panel d'ingredient
			cpn_Ingredients.Controls.Add(lbl_TitleIngredients);
			//pnl_AffichageIngredients.MaximumSize = new Size((int)(cpn_Ingredients.Height/2.5), 0);
			//lbl_TitleIngredients.Width = (int)(cpn_Ingredients.Width * 0.8);
			//lbl_TitleIngredients.Location = new Point(cpn_Ingredients.Width / 2 - (lbl_TitleIngredients.Width / 2), 10);
			//lbl_TitleIngredients.Invalidate();

			// Placement des controls du panel de type d'ingredient
			cpn_Type.Controls.Add(lbl_TitleType);
			//lbl_TitleType.Width = (int)(cpn_Type.Width * 0.8);
			//lbl_TitleType.Location = new Point(cpn_Type.Width / 2 - (lbl_TitleType.Width / 2), 10);
			//lbl_TitleType.Invalidate();

			// Placement des controls du panel de budget
			cpn_Budget.Controls.Add(lbl_TitleBudget);
			//lbl_TitleBudget.Width = (int)(cpn_Budget.Width * 0.8);
			//lbl_TitleBudget.Location = new Point(cpn_Budget.Width / 2 - (lbl_TitleBudget.Width / 2), 10);
			//lbl_TitleBudget.Invalidate();
			space = (cpn_Budget.Width - (rdb_petit.Width + rdb_moyen.Width + rdb_grand.Width)) / 3;
			int reserved_width = rdb_petit.Width + rdb_moyen.Width + rdb_grand.Width + 2 * space;
			rdb_petit.Location = new Point(cpn_Budget.Width / 2 - reserved_width / 2, cpn_Budget.Height / 2 - rdb_petit.Height / 2);
			rdb_moyen.Location = new Point(rdb_petit.Location.X + rdb_petit.Width + space, cpn_Budget.Height / 2 - rdb_moyen.Height / 2);
			rdb_grand.Location = new Point(rdb_moyen.Location.X + rdb_moyen.Width + space, cpn_Budget.Height / 2 - rdb_grand.Height / 2);

			// Placement des controls du panel de duree
			cpn_Duree.Controls.Add(lbl_TitleDuree);
			//lbl_TitleDuree.Width = (int)(cpn_Duree.Width * 0.9);
			//lbl_TitleDuree.Location = new Point(cpn_Duree.Width / 2 - (lbl_TitleDuree.Width / 2), 10);
			//lbl_TitleDuree.Invalidate();

			// Placement des controls du panel de note
			cpn_Note.Controls.Add(lbl_TitleNote);
			//lbl_TitleNote.Width = (int)(cpn_Note.Width * 0.9);
			//lbl_TitleNote.Location = new Point(cpn_Note.Width / 2 - (lbl_TitleNote.Width / 2), 10);
			//lbl_TitleNote.Invalidate();
		}




		private void cbxIngredients_SelectedValueChanged(object sender, EventArgs e) {
			pnl_AffichageIngredients.Controls.Clear();
			int top = 0;
			int hauteur_panel = 0;
			foreach(DataRow row in ds.Tables["Ingrédients"].Rows) {
				if(row["codeFamille"].ToString() == cbxIngredients.SelectedValue.ToString()) {
					CheckBox cb = new CheckBox();
					cb.AutoSize = true;
					cb.Font = new Font(cb.Font.FontFamily, 10, cb.Font.Style);
					cb.Text = row["libIngredient"].ToString();
					cb.Location = new Point(0, top + 2);
					cb.CheckedChanged += ingredientAjouteOuSupprime;
					cb.Tag = row["codeIngredient"];
					pnl_AffichageIngredients.Controls.Add(cb);
					top += cb.Height;
					hauteur_panel += 2 + cb.Height;

					if(str_ingredients_choisis.Contains(cb.Text)) {
						cb.Checked = true;
					}
				}
			}
			pnl_AffichageIngredients.Height = (hauteur_panel > (int)(cpn_Ingredients.Height * 0.65)) ?  (int)(cpn_Ingredients.Height * 0.65) : hauteur_panel;			
		}


		private void ingredientAjouteOuSupprime(object sender, EventArgs e) {
			CheckBox cb = (CheckBox)sender;

			if(cb.Checked && str_ingredients_choisis.Count < 3 && !str_ingredients_choisis.Contains(cb.Text)) {
				str_ingredients_choisis.Add(cb.Text);
				ids_ingredients_choisis.Add(int.Parse(cb.Tag.ToString()));

			} else if(cb.Checked == false) {
				str_ingredients_choisis.Remove(cb.Text);
				ids_ingredients_choisis.Remove(int.Parse(cb.Tag.ToString()));
			}

			updateAffichageSelection();
		}

		private void delete_selection(object sender, EventArgs e) {
			PictureBox cross = (PictureBox)sender;
			int index = int.Parse(cross.Tag.ToString());
			if(index < str_ingredients_choisis.Count) {
				str_ingredients_choisis.RemoveAt(index);
				ids_ingredients_choisis.RemoveAt(index);
			}

			updateAffichageSelection();
		}
		private void updateAffichageSelection() {
			lbl_Ingredient1.Text = str_ingredients_choisis.Count >= 1 ? "・" + str_ingredients_choisis[0] : "・";
			lbl_Ingredient2.Text = str_ingredients_choisis.Count >= 2 ? "・" + str_ingredients_choisis[1] : "・";
			lbl_Ingredient3.Text = str_ingredients_choisis.Count == 3 ? "・" + str_ingredients_choisis[2] : "・";

			foreach(Control c in pnl_AffichageIngredients.Controls) {
				if(c is CheckBox) {
					CheckBox cb = (CheckBox)c;
					cb.Checked = str_ingredients_choisis.Contains(c.Text);
				}
			}
		}


		

		private void btn_recherche_Click(object sender, EventArgs e) {
			bool error = false;
			if(ids_ingredients_choisis.Count == 0) {
				error = true;
				MessageBox.Show("Il faut séléctionner au moins un ingrédient.");
			}
			if(ids_type_plats.Count == 0) {
				error = true;
				MessageBox.Show("Il faut choisir au moins un type de plat.");
			}


			if(!error) {
				Search_result res = new Search_result(ids_ingredients_choisis, str_ingredients_choisis, ids_type_plats, budget, duree, note_min);
				this.Controls.Add(res);
				res.BringToFront();
				res.Dock = DockStyle.Fill;
			}
		}


		private void budget_checked(object sender, EventArgs e) {
			RadioButton rdb = (RadioButton)sender;
			budget = int.Parse(rdb.Tag.ToString());
		}


		private void plat_selectionne(object sender, EventArgs e) {
			CustomCheckbox CustomCheckbox = (CustomCheckbox)sender;

			if(CustomCheckbox.Checked) {
				ids_type_plats.Add(int.Parse(CustomCheckbox.Tag.ToString()));
			} else {
				ids_type_plats.Remove(int.Parse(CustomCheckbox.Tag.ToString()));
			}
		}

		private void trkb_duree_ValueChanged(object sender, EventArgs e) { 
			this.duree = trkb_duree.Value;
			lbl_duree.Text = trkb_duree.Value.ToString() + (trkb_duree.Value > 1 ? " minutes" : " minute");
		}

		private void trkb_note_ValueChanged(object sender, EventArgs e) {
			this.note_min = trkb_note.Value;
			lbl_note.Text = trkb_note.Value.ToString() + " / 5";
		}
	}
}
