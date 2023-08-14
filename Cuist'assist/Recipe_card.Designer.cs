namespace Cuist_assist {
	partial class Recipe_card {
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
			this.cbt_pdf = new Cuist_assist.CustomButton();
			this.cbt_recette_integrale = new Cuist_assist.CustomButton();
			this.cpn_recipe_infos = new Cuist_assist.CustomPanel();
			this.lblPersonnes = new System.Windows.Forms.Label();
			this.lblTemps = new System.Windows.Forms.Label();
			this.lblCout = new System.Windows.Forms.Label();
			this.lblNomRecette = new System.Windows.Forms.Label();
			this.lblDescriptionRecette = new System.Windows.Forms.Label();
			this.picRecette = new System.Windows.Forms.PictureBox();
			this.cpn_recipe_infos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRecette)).BeginInit();
			this.SuspendLayout();
			// 
			// cbt_pdf
			// 
			this.cbt_pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(11)))), ((int)(((byte)(52)))));
			this.cbt_pdf.BorderRadius = 32;
			this.cbt_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbt_pdf.FlatAppearance.BorderSize = 0;
			this.cbt_pdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(72)))));
			this.cbt_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbt_pdf.ForeColor = System.Drawing.Color.White;
			this.cbt_pdf.Location = new System.Drawing.Point(966, 172);
			this.cbt_pdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbt_pdf.MinimumSize = new System.Drawing.Size(101, 38);
			this.cbt_pdf.Name = "cbt_pdf";
			this.cbt_pdf.Size = new System.Drawing.Size(201, 64);
			this.cbt_pdf.TabIndex = 2;
			this.cbt_pdf.Text = "PDF";
			this.cbt_pdf.UseVisualStyleBackColor = false;
			// 
			// cbt_recette_integrale
			// 
			this.cbt_recette_integrale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(11)))), ((int)(((byte)(52)))));
			this.cbt_recette_integrale.BorderRadius = 32;
			this.cbt_recette_integrale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbt_recette_integrale.FlatAppearance.BorderSize = 0;
			this.cbt_recette_integrale.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(72)))));
			this.cbt_recette_integrale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbt_recette_integrale.ForeColor = System.Drawing.Color.White;
			this.cbt_recette_integrale.Location = new System.Drawing.Point(966, 60);
			this.cbt_recette_integrale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbt_recette_integrale.MinimumSize = new System.Drawing.Size(101, 38);
			this.cbt_recette_integrale.Name = "cbt_recette_integrale";
			this.cbt_recette_integrale.Size = new System.Drawing.Size(201, 64);
			this.cbt_recette_integrale.TabIndex = 1;
			this.cbt_recette_integrale.Text = "Recette intégrale";
			this.cbt_recette_integrale.UseVisualStyleBackColor = false;
			// 
			// cpn_recipe_infos
			// 
			this.cpn_recipe_infos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.cpn_recipe_infos.BorderRadius = 12;
			this.cpn_recipe_infos.Controls.Add(this.lblPersonnes);
			this.cpn_recipe_infos.Controls.Add(this.lblTemps);
			this.cpn_recipe_infos.Controls.Add(this.lblCout);
			this.cpn_recipe_infos.Controls.Add(this.lblNomRecette);
			this.cpn_recipe_infos.Controls.Add(this.lblDescriptionRecette);
			this.cpn_recipe_infos.Controls.Add(this.picRecette);
			this.cpn_recipe_infos.ForeColor = System.Drawing.Color.White;
			this.cpn_recipe_infos.Location = new System.Drawing.Point(3, 4);
			this.cpn_recipe_infos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cpn_recipe_infos.Name = "cpn_recipe_infos";
			this.cpn_recipe_infos.Size = new System.Drawing.Size(928, 290);
			this.cpn_recipe_infos.TabIndex = 0;
			// 
			// lblPersonnes
			// 
			this.lblPersonnes.AutoSize = true;
			this.lblPersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPersonnes.Location = new System.Drawing.Point(411, 25);
			this.lblPersonnes.Name = "lblPersonnes";
			this.lblPersonnes.Size = new System.Drawing.Size(116, 26);
			this.lblPersonnes.TabIndex = 5;
			this.lblPersonnes.Text = "Personnes";
			// 
			// lblTemps
			// 
			this.lblTemps.AutoSize = true;
			this.lblTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTemps.Location = new System.Drawing.Point(588, 25);
			this.lblTemps.Name = "lblTemps";
			this.lblTemps.Size = new System.Drawing.Size(78, 26);
			this.lblTemps.TabIndex = 4;
			this.lblTemps.Text = "Temps";
			// 
			// lblCout
			// 
			this.lblCout.AutoSize = true;
			this.lblCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCout.Location = new System.Drawing.Point(722, 25);
			this.lblCout.Name = "lblCout";
			this.lblCout.Size = new System.Drawing.Size(50, 26);
			this.lblCout.TabIndex = 3;
			this.lblCout.Text = "Prix";
			// 
			// lblNomRecette
			// 
			this.lblNomRecette.AutoSize = true;
			this.lblNomRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomRecette.Location = new System.Drawing.Point(34, 25);
			this.lblNomRecette.Name = "lblNomRecette";
			this.lblNomRecette.Size = new System.Drawing.Size(128, 25);
			this.lblNomRecette.TabIndex = 2;
			this.lblNomRecette.Text = "Nom recette";
			// 
			// lblDescriptionRecette
			// 
			this.lblDescriptionRecette.AutoSize = true;
			this.lblDescriptionRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescriptionRecette.Location = new System.Drawing.Point(292, 106);
			this.lblDescriptionRecette.Name = "lblDescriptionRecette";
			this.lblDescriptionRecette.Size = new System.Drawing.Size(0, 26);
			this.lblDescriptionRecette.TabIndex = 1;
			// 
			// picRecette
			// 
			this.picRecette.BackColor = System.Drawing.Color.RosyBrown;
			this.picRecette.Location = new System.Drawing.Point(39, 106);
			this.picRecette.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.picRecette.Name = "picRecette";
			this.picRecette.Size = new System.Drawing.Size(226, 138);
			this.picRecette.TabIndex = 0;
			this.picRecette.TabStop = false;
			// 
			// Recipe_card
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.cbt_pdf);
			this.Controls.Add(this.cbt_recette_integrale);
			this.Controls.Add(this.cpn_recipe_infos);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Recipe_card";
			this.Size = new System.Drawing.Size(1218, 296);
			this.cpn_recipe_infos.ResumeLayout(false);
			this.cpn_recipe_infos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRecette)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomPanel cpn_recipe_infos;
		private System.Windows.Forms.Label lblNomRecette;
		private System.Windows.Forms.Label lblDescriptionRecette;
		private System.Windows.Forms.PictureBox picRecette;
		private System.Windows.Forms.Label lblPersonnes;
		private System.Windows.Forms.Label lblTemps;
		private System.Windows.Forms.Label lblCout;
		private CustomButton cbt_recette_integrale;
		private CustomButton cbt_pdf;
	}
}
