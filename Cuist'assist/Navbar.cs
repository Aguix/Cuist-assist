using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cuist_assist {
	public partial class Navbar : UserControl {
		private Control active_page;

		public Navbar() {
			InitializeComponent();
			active_page = btnSearch;
			this.Resize += PanelFond_Resize;
		}


		private void updateNavbar(Control new_active_page) {
			active_page = new_active_page;
			pnl_active_page.Width = active_page.Width;
			int final_x = active_page.Location.X;
			int current_x = pnl_active_page.Location.X;
			if(pnl_active_page.Location.X < active_page.Location.X) {
				while(current_x < final_x) {
					current_x += 1;
					pnl_active_page.Location = new Point(current_x, PanelFond.Height - 5);
					//Stopwatch stopwatch = Stopwatch.StartNew();
					//long stopwatchTicks = 1 * Stopwatch.Frequency / 100000;
					//while (stopwatch.ElapsedTicks < stopwatchTicks) {}
				}
			} else {
				while(current_x > final_x) {
					current_x -= 1;
					pnl_active_page.Location = new Point(current_x, PanelFond.Height - 5);
					//Stopwatch stopwatch = Stopwatch.StartNew();
					//long stopwatchTicks = 1 * Stopwatch.Frequency / 100000;
					//while (stopwatch.ElapsedTicks < stopwatchTicks) { }
				}
			}
		}



		private void PanelFond_Resize(object sender, EventArgs e) {
			int milieu = this.ClientSize.Width / 2;
			int space = this.ClientSize.Width / 25;


			btnFavorite.Location = new Point(milieu - space - btnFavorite.Width, btnSearch.Location.Y);
			btnAdd.Location = new Point(milieu + space, btnSearch.Location.Y);

			btnSearch.Location = new Point(btnFavorite.Location.X - space * 2 - btnSearch.Width, btnSearch.Location.Y);
			btnAccount.Location = new Point(btnAdd.Location.X + space * 2 + btnAdd.Width, btnSearch.Location.Y);
			
			updateNavbar(active_page);
		}


		private void btnMouseEnter(object sender, EventArgs e) {
			Button btn = (Button)sender;
			btn.Location = new Point(btn.Location.X, btn.Location.Y - 5);
		}

		private void btnMouseLeave(object sender, EventArgs e) {
			Button btn = (Button)sender;
			btn.Location = new Point(btn.Location.X, btn.Location.Y + 5);
		}


		private void btnClick(object sender, EventArgs e) {
			var form1 = this.TopLevelControl as Form;
			Control new_active_page = (Control)sender;

			// Masquer toutes les pages
			form1.Controls.Find("pnlPagesDisplay", false)[0].Controls.Find("searchPage1", false)[0].Visible = false;
			form1.Controls.Find("pnlPagesDisplay", false)[0].Controls.Find("favoritePage1", false)[0].Visible = false;
			form1.Controls.Find("pnlPagesDisplay", false)[0].Controls.Find("addPage1", false)[0].Visible = false;
			form1.Controls.Find("pnlPagesDisplay", false)[0].Controls.Find("accountPage1", false)[0].Visible = false;

			// Afficher la page voulu, renseigné dans le tag de l'élément de la navbar cliqué
			form1.Controls.Find("pnlPagesDisplay", false)[0].Controls.Find(new_active_page.Tag.ToString(), false)[0].Visible = true;

			// Mettre à jour la navbar avec la page active
			updateNavbar(new_active_page);
		}
	}
}