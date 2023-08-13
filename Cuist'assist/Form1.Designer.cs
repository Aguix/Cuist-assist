namespace Cuist_assist {
	partial class Form1 {
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlPagesDisplay = new System.Windows.Forms.Panel();
			this.accountPage1 = new Cuist_assist.AccountPage();
			this.addPage1 = new Cuist_assist.AddPage();
			this.favoritePage1 = new Cuist_assist.FavoritePage();
			this.searchPage1 = new Cuist_assist.SearchPage();
			this.navbar1 = new Cuist_assist.Navbar();
			this.pnlPagesDisplay.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlPagesDisplay
			// 
			resources.ApplyResources(this.pnlPagesDisplay, "pnlPagesDisplay");
			this.pnlPagesDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pnlPagesDisplay.Controls.Add(this.accountPage1);
			this.pnlPagesDisplay.Controls.Add(this.addPage1);
			this.pnlPagesDisplay.Controls.Add(this.favoritePage1);
			this.pnlPagesDisplay.Controls.Add(this.searchPage1);
			this.pnlPagesDisplay.Name = "pnlPagesDisplay";
			// 
			// accountPage1
			// 
			resources.ApplyResources(this.accountPage1, "accountPage1");
			this.accountPage1.Name = "accountPage1";
			// 
			// addPage1
			// 
			resources.ApplyResources(this.addPage1, "addPage1");
			this.addPage1.Name = "addPage1";
			// 
			// favoritePage1
			// 
			resources.ApplyResources(this.favoritePage1, "favoritePage1");
			this.favoritePage1.Name = "favoritePage1";
			// 
			// searchPage1
			// 
			resources.ApplyResources(this.searchPage1, "searchPage1");
			this.searchPage1.Name = "searchPage1";
			// 
			// navbar1
			// 
			resources.ApplyResources(this.navbar1, "navbar1");
			this.navbar1.Name = "navbar1";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.navbar1);
			this.Controls.Add(this.pnlPagesDisplay);
			this.Name = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.pnlPagesDisplay.ResumeLayout(false);
			this.pnlPagesDisplay.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel pnlPagesDisplay;
		private AccountPage accountPage1;
		private AddPage addPage1;
		private FavoritePage favoritePage1;
		private SearchPage searchPage1;
		private Navbar navbar1;
	}
}

