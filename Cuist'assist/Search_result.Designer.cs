namespace Cuist_assist {
	partial class Search_result {
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_affichage = new System.Windows.Forms.Panel();
			this.header = new Cuist_assist.Header();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(16, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(270, 46);
			this.panel2.TabIndex = 1;
			this.panel2.Visible = false;
			// 
			// pnl_affichage
			// 
			this.pnl_affichage.AutoScroll = true;
			this.pnl_affichage.BackColor = System.Drawing.Color.Transparent;
			this.pnl_affichage.Location = new System.Drawing.Point(0, 114);
			this.pnl_affichage.Name = "pnl_affichage";
			this.pnl_affichage.Size = new System.Drawing.Size(1336, 492);
			this.pnl_affichage.TabIndex = 2;
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.header.Dock = System.Windows.Forms.DockStyle.Top;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Margin = new System.Windows.Forms.Padding(4);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(1336, 110);
			this.header.TabIndex = 0;
			// 
			// Search_result
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.Controls.Add(this.pnl_affichage);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.header);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(800, 0);
			this.Name = "Search_result";
			this.Size = new System.Drawing.Size(1336, 609);
			this.ResumeLayout(false);

		}

		#endregion

		private Header header;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnl_affichage;
	}
}
