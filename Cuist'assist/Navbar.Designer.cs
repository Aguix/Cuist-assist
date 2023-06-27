namespace Cuist_assist {
	partial class Navbar {
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navbar));
			this.PanelFond = new System.Windows.Forms.Panel();
			this.pnl_active_page = new Cuist_assist.CustomPanel();
			this.btnFavorite = new System.Windows.Forms.Button();
			this.btnAccount = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.PanelFond.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelFond
			// 
			this.PanelFond.AutoSize = true;
			this.PanelFond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(11)))), ((int)(((byte)(52)))));
			this.PanelFond.Controls.Add(this.pnl_active_page);
			this.PanelFond.Controls.Add(this.btnFavorite);
			this.PanelFond.Controls.Add(this.btnAccount);
			this.PanelFond.Controls.Add(this.btnAdd);
			this.PanelFond.Controls.Add(this.btnSearch);
			this.PanelFond.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelFond.Location = new System.Drawing.Point(0, 0);
			this.PanelFond.Margin = new System.Windows.Forms.Padding(2);
			this.PanelFond.Name = "PanelFond";
			this.PanelFond.Size = new System.Drawing.Size(980, 70);
			this.PanelFond.TabIndex = 0;
			// 
			// pnl_active_page
			// 
			this.pnl_active_page.BackColor = System.Drawing.Color.White;
			this.pnl_active_page.BorderRadius = 5;
			this.pnl_active_page.ForeColor = System.Drawing.Color.White;
			this.pnl_active_page.Location = new System.Drawing.Point(186, 50);
			this.pnl_active_page.Name = "pnl_active_page";
			this.pnl_active_page.Size = new System.Drawing.Size(50, 5);
			this.pnl_active_page.TabIndex = 4;
			// 
			// btnFavorite
			// 
			this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
			this.btnFavorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFavorite.BackgroundImage")));
			this.btnFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnFavorite.FlatAppearance.BorderSize = 0;
			this.btnFavorite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnFavorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFavorite.ForeColor = System.Drawing.Color.Transparent;
			this.btnFavorite.Location = new System.Drawing.Point(392, 13);
			this.btnFavorite.Margin = new System.Windows.Forms.Padding(2);
			this.btnFavorite.Name = "btnFavorite";
			this.btnFavorite.Size = new System.Drawing.Size(40, 40);
			this.btnFavorite.TabIndex = 1;
			this.btnFavorite.Tag = "favoritePage1";
			this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFavorite.UseVisualStyleBackColor = false;
			this.btnFavorite.Click += new System.EventHandler(this.btnClick);
			this.btnFavorite.MouseEnter += new System.EventHandler(this.btnMouseEnter);
			this.btnFavorite.MouseLeave += new System.EventHandler(this.btnMouseLeave);
			// 
			// btnAccount
			// 
			this.btnAccount.BackColor = System.Drawing.Color.Transparent;
			this.btnAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.BackgroundImage")));
			this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAccount.FlatAppearance.BorderSize = 0;
			this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccount.ForeColor = System.Drawing.Color.Transparent;
			this.btnAccount.Location = new System.Drawing.Point(782, 13);
			this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new System.Drawing.Size(40, 40);
			this.btnAccount.TabIndex = 3;
			this.btnAccount.Tag = "accountPage1";
			this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAccount.UseVisualStyleBackColor = false;
			this.btnAccount.Click += new System.EventHandler(this.btnClick);
			this.btnAccount.MouseEnter += new System.EventHandler(this.btnMouseEnter);
			this.btnAccount.MouseLeave += new System.EventHandler(this.btnMouseLeave);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Transparent;
			this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
			this.btnAdd.Location = new System.Drawing.Point(620, 13);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(40, 40);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Tag = "addPage1";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnClick);
			this.btnAdd.MouseEnter += new System.EventHandler(this.btnMouseEnter);
			this.btnAdd.MouseLeave += new System.EventHandler(this.btnMouseLeave);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
			this.btnSearch.Location = new System.Drawing.Point(188, 13);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(40, 40);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Tag = "searchPage1";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnClick);
			this.btnSearch.MouseEnter += new System.EventHandler(this.btnMouseEnter);
			this.btnSearch.MouseLeave += new System.EventHandler(this.btnMouseLeave);
			// 
			// Navbar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PanelFond);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Navbar";
			this.Size = new System.Drawing.Size(980, 70);
			this.PanelFond.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel PanelFond;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnFavorite;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnAccount;
		private CustomPanel pnl_active_page;
	}
}
