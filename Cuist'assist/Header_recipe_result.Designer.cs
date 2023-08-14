namespace Cuist_assist {
	partial class Header {
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
			this.lblTemps = new System.Windows.Forms.Label();
			this.lblNote = new System.Windows.Forms.Label();
			this.lblBudget = new System.Windows.Forms.Label();
			this.lblIngredients = new System.Windows.Forms.Label();
			this.ctbTemps = new System.Windows.Forms.TrackBar();
			this.txtBudget = new System.Windows.Forms.ComboBox();
			this.ctb_note = new System.Windows.Forms.TrackBar();
			this.rbtn_tri = new Cuist_assist.CustomButton();
			this.rbtn_retour = new Cuist_assist.CustomButton();
			((System.ComponentModel.ISupportInitialize)(this.ctbTemps)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ctb_note)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTemps
			// 
			this.lblTemps.AutoSize = true;
			this.lblTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTemps.ForeColor = System.Drawing.Color.White;
			this.lblTemps.Location = new System.Drawing.Point(780, 118);
			this.lblTemps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTemps.Name = "lblTemps";
			this.lblTemps.Size = new System.Drawing.Size(195, 29);
			this.lblTemps.TabIndex = 4;
			this.lblTemps.Text = "Temps (en min) :";
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNote.ForeColor = System.Drawing.Color.White;
			this.lblNote.Location = new System.Drawing.Point(369, 118);
			this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(181, 29);
			this.lblNote.TabIndex = 3;
			this.lblNote.Text = "Note minimale :";
			// 
			// lblBudget
			// 
			this.lblBudget.AutoSize = true;
			this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBudget.ForeColor = System.Drawing.Color.White;
			this.lblBudget.Location = new System.Drawing.Point(45, 118);
			this.lblBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBudget.Name = "lblBudget";
			this.lblBudget.Size = new System.Drawing.Size(102, 29);
			this.lblBudget.TabIndex = 2;
			this.lblBudget.Text = "Budget :";
			// 
			// lblIngredients
			// 
			this.lblIngredients.AutoSize = true;
			this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIngredients.ForeColor = System.Drawing.Color.White;
			this.lblIngredients.Location = new System.Drawing.Point(548, 22);
			this.lblIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIngredients.Name = "lblIngredients";
			this.lblIngredients.Size = new System.Drawing.Size(386, 33);
			this.lblIngredients.TabIndex = 1;
			this.lblIngredients.Text = "Ingrédient(s) sélectionné(s) :";
			// 
			// ctbTemps
			// 
			this.ctbTemps.AutoSize = false;
			this.ctbTemps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.ctbTemps.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ctbTemps.Location = new System.Drawing.Point(976, 122);
			this.ctbTemps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ctbTemps.Maximum = 150;
			this.ctbTemps.Name = "ctbTemps";
			this.ctbTemps.Size = new System.Drawing.Size(188, 28);
			this.ctbTemps.TabIndex = 10;
			this.ctbTemps.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// txtBudget
			// 
			this.txtBudget.FormattingEnabled = true;
			this.txtBudget.Items.AddRange(new object[] {
            "Petit",
            "Moyen",
            "Grand"});
			this.txtBudget.Location = new System.Drawing.Point(142, 120);
			this.txtBudget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBudget.Name = "txtBudget";
			this.txtBudget.Size = new System.Drawing.Size(180, 28);
			this.txtBudget.TabIndex = 11;
			// 
			// ctb_note
			// 
			this.ctb_note.AutoSize = false;
			this.ctb_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.ctb_note.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ctb_note.LargeChange = 1;
			this.ctb_note.Location = new System.Drawing.Point(557, 111);
			this.ctb_note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ctb_note.Maximum = 5;
			this.ctb_note.Name = "ctb_note";
			this.ctb_note.Size = new System.Drawing.Size(188, 36);
			this.ctb_note.TabIndex = 12;
			this.ctb_note.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// rbtn_tri
			// 
			this.rbtn_tri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(11)))), ((int)(((byte)(52)))));
			this.rbtn_tri.BorderRadius = 24;
			this.rbtn_tri.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbtn_tri.FlatAppearance.BorderSize = 0;
			this.rbtn_tri.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(72)))));
			this.rbtn_tri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbtn_tri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtn_tri.ForeColor = System.Drawing.Color.White;
			this.rbtn_tri.Location = new System.Drawing.Point(1185, 111);
			this.rbtn_tri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbtn_tri.MinimumSize = new System.Drawing.Size(135, 46);
			this.rbtn_tri.Name = "rbtn_tri";
			this.rbtn_tri.Size = new System.Drawing.Size(180, 48);
			this.rbtn_tri.TabIndex = 9;
			this.rbtn_tri.Text = "Trier par prix";
			this.rbtn_tri.UseVisualStyleBackColor = false;
			// 
			// rbtn_retour
			// 
			this.rbtn_retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(11)))), ((int)(((byte)(52)))));
			this.rbtn_retour.BorderRadius = 23;
			this.rbtn_retour.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbtn_retour.FlatAppearance.BorderSize = 0;
			this.rbtn_retour.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(72)))));
			this.rbtn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbtn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtn_retour.ForeColor = System.Drawing.Color.White;
			this.rbtn_retour.Location = new System.Drawing.Point(21, 12);
			this.rbtn_retour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbtn_retour.MinimumSize = new System.Drawing.Size(135, 46);
			this.rbtn_retour.Name = "rbtn_retour";
			this.rbtn_retour.Size = new System.Drawing.Size(417, 46);
			this.rbtn_retour.TabIndex = 8;
			this.rbtn_retour.Text = "<<-- Retourner à la séléction des ingrédients";
			this.rbtn_retour.UseVisualStyleBackColor = false;
			// 
			// Header
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.Controls.Add(this.ctb_note);
			this.Controls.Add(this.txtBudget);
			this.Controls.Add(this.ctbTemps);
			this.Controls.Add(this.rbtn_tri);
			this.Controls.Add(this.lblIngredients);
			this.Controls.Add(this.lblTemps);
			this.Controls.Add(this.rbtn_retour);
			this.Controls.Add(this.lblNote);
			this.Controls.Add(this.lblBudget);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Header";
			this.Size = new System.Drawing.Size(1389, 169);
			this.Load += new System.EventHandler(this.Header_Load);
			((System.ComponentModel.ISupportInitialize)(this.ctbTemps)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ctb_note)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblIngredients;
		private System.Windows.Forms.Label lblBudget;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.Label lblTemps;
		private CustomButton rbtn_retour;
		private CustomButton rbtn_tri;
		private System.Windows.Forms.TrackBar ctbTemps;
		private System.Windows.Forms.ComboBox txtBudget;
		private System.Windows.Forms.TrackBar ctb_note;
	}
}
