using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
	public partial class Search_result : UserControl {

		private string con_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\baseFrigov2023.mdb";
		private OleDbConnection db_con = new OleDbConnection();


		public Search_result(List<int> selected_ingredients_ids, List<String> selected_ingredients_str, List<int> dish_type_ids, int budget, int time, int note_min) {
			InitializeComponent();
			db_con.ConnectionString = con_str;
			this.Resize += Search_Result_Replace;
			update(selected_ingredients_ids, selected_ingredients_str, dish_type_ids, budget, time, note_min);
		}

		private void Search_Result_Replace(object sender, EventArgs e) {
		}


		private void update(List<int> selected_ingredients_ids, List<String> selected_ingredients_str, List<int> dish_type_ids, int budget, int time, int note_min) {
			header.update(selected_ingredients_str, budget, time, note_min);


			try {
				string req = $"SELECT codeRecette FROM IngrédientsRecette WHERE codeIngredient IN ({ string.Join(", ", selected_ingredients_ids)}) AND codeRecette IN (SELECT codeRecette FROM CatégoriesRecette WHERE codeCategorie IN ({string.Join(", ", dish_type_ids)}))";
				db_con.Open();
				OleDbCommand cd = new OleDbCommand(req, db_con);
				OleDbDataReader dr = cd.ExecuteReader();
				List<int> recipe_ids_according_to_ingredients_and_dish_type = new List<int>();
				while(dr.Read()) {
					recipe_ids_according_to_ingredients_and_dish_type.Add(int.Parse(dr[0].ToString()));
				}

				if(recipe_ids_according_to_ingredients_and_dish_type.Count > 0) {
					MessageBox.Show("final : " + string.Join(", ", recipe_ids_according_to_ingredients_and_dish_type));
				} else {
					MessageBox.Show("rien");
					return;
				}


				req = $"SELECT DISTINCT * FROM Recettes WHERE codeRecette IN ({string.Join(", ", recipe_ids_according_to_ingredients_and_dish_type)}) AND tempsCuisson <= {time} AND categPrix <= {budget} ";
				MessageBox.Show(req);
				cd = new OleDbCommand(req, db_con);
				dr = cd.ExecuteReader();
				int top = 0;
				while(dr.Read()) {
					MessageBox.Show(dr["description"].ToString());
					Recipe_card card = new Recipe_card(int.Parse(dr["codeRecette"].ToString()), dr["description"].ToString(), int.Parse(dr["nbPersonnes"].ToString()), int.Parse(dr["tempsCuisson"].ToString()), dr["imageDesc"].ToString(), int.Parse(dr["categPrix"].ToString()), dr["Commentaire"].ToString());
					pnl_affichage.Controls.Add(card);
					card.Location = new System.Drawing.Point((pnl_affichage.Width - card.Width) / 2, top);
					top += card.Height + 20;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return;
			}



			
		}
	}
}
