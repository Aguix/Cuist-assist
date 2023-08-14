namespace Cuist_assist {
	partial class SearchPage {
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
			this.components = new System.ComponentModel.Container();
			this.btn_recherche = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cpn_Note = new Cuist_assist.CustomPanel();
			this.lbl_note = new System.Windows.Forms.Label();
			this.trkb_note = new System.Windows.Forms.TrackBar();
			this.lbl_TitleNote = new System.Windows.Forms.Label();
			this.cpn_Duree = new Cuist_assist.CustomPanel();
			this.trkb_duree = new System.Windows.Forms.TrackBar();
			this.lbl_duree = new System.Windows.Forms.Label();
			this.lbl_TitleDuree = new System.Windows.Forms.Label();
			this.cpn_Budget = new Cuist_assist.CustomPanel();
			this.rdb_grand = new System.Windows.Forms.RadioButton();
			this.rdb_moyen = new System.Windows.Forms.RadioButton();
			this.rdb_petit = new System.Windows.Forms.RadioButton();
			this.lbl_TitleBudget = new System.Windows.Forms.Label();
			this.cpn_Type = new Cuist_assist.CustomPanel();
			this.pnl_Familles = new System.Windows.Forms.Panel();
			this.lbl_TitleType = new System.Windows.Forms.Label();
			this.cpn_Ingredients = new Cuist_assist.CustomPanel();
			this.pnl_recapIngredients = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_PresentationIngredients = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pb1 = new System.Windows.Forms.PictureBox();
			this.lbl_Ingredient2 = new System.Windows.Forms.Label();
			this.lbl_Ingredient3 = new System.Windows.Forms.Label();
			this.lbl_Ingredient1 = new System.Windows.Forms.Label();
			this.pnl_AffichageIngredients = new System.Windows.Forms.Panel();
			this.lbl_ChoixCategorie = new System.Windows.Forms.Label();
			this.cbxIngredients = new System.Windows.Forms.ComboBox();
			this.lbl_TitleIngredients = new System.Windows.Forms.Label();
			this.cpn_Note.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkb_note)).BeginInit();
			this.cpn_Duree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkb_duree)).BeginInit();
			this.cpn_Budget.SuspendLayout();
			this.cpn_Type.SuspendLayout();
			this.cpn_Ingredients.SuspendLayout();
			this.pnl_recapIngredients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_recherche
			// 
			this.btn_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_recherche.Location = new System.Drawing.Point(876, 858);
			this.btn_recherche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_recherche.Name = "btn_recherche";
			this.btn_recherche.Size = new System.Drawing.Size(882, 92);
			this.btn_recherche.TabIndex = 11;
			this.btn_recherche.Text = "Lancer la recherche";
			this.btn_recherche.UseVisualStyleBackColor = true;
			this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// cpn_Note
			// 
			this.cpn_Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.cpn_Note.BorderRadius = 12;
			this.cpn_Note.Controls.Add(this.lbl_note);
			this.cpn_Note.Controls.Add(this.trkb_note);
			this.cpn_Note.Controls.Add(this.lbl_TitleNote);
			this.cpn_Note.ForeColor = System.Drawing.Color.White;
			this.cpn_Note.Location = new System.Drawing.Point(1334, 594);
			this.cpn_Note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cpn_Note.Name = "cpn_Note";
			this.cpn_Note.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.cpn_Note.Size = new System.Drawing.Size(424, 229);
			this.cpn_Note.TabIndex = 10;
			// 
			// lbl_note
			// 
			this.lbl_note.AutoSize = true;
			this.lbl_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_note.Location = new System.Drawing.Point(158, 158);
			this.lbl_note.Name = "lbl_note";
			this.lbl_note.Size = new System.Drawing.Size(73, 36);
			this.lbl_note.TabIndex = 9;
			this.lbl_note.Text = "0 / 5";
			// 
			// trkb_note
			// 
			this.trkb_note.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trkb_note.LargeChange = 1;
			this.trkb_note.Location = new System.Drawing.Point(91, 86);
			this.trkb_note.Maximum = 5;
			this.trkb_note.Name = "trkb_note";
			this.trkb_note.Size = new System.Drawing.Size(264, 69);
			this.trkb_note.TabIndex = 8;
			this.trkb_note.ValueChanged += new System.EventHandler(this.trkb_note_ValueChanged);
			// 
			// lbl_TitleNote
			// 
			this.lbl_TitleNote.AutoEllipsis = true;
			this.lbl_TitleNote.BackColor = System.Drawing.Color.Transparent;
			this.lbl_TitleNote.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_TitleNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TitleNote.Location = new System.Drawing.Point(0, 8);
			this.lbl_TitleNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_TitleNote.Name = "lbl_TitleNote";
			this.lbl_TitleNote.Size = new System.Drawing.Size(424, 54);
			this.lbl_TitleNote.TabIndex = 7;
			this.lbl_TitleNote.Text = "Choisissez la note";
			this.lbl_TitleNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cpn_Duree
			// 
			this.cpn_Duree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.cpn_Duree.BorderRadius = 12;
			this.cpn_Duree.Controls.Add(this.trkb_duree);
			this.cpn_Duree.Controls.Add(this.lbl_duree);
			this.cpn_Duree.Controls.Add(this.lbl_TitleDuree);
			this.cpn_Duree.ForeColor = System.Drawing.Color.White;
			this.cpn_Duree.Location = new System.Drawing.Point(876, 594);
			this.cpn_Duree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cpn_Duree.Name = "cpn_Duree";
			this.cpn_Duree.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.cpn_Duree.Size = new System.Drawing.Size(444, 229);
			this.cpn_Duree.TabIndex = 9;
			// 
			// trkb_duree
			// 
			this.trkb_duree.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trkb_duree.Location = new System.Drawing.Point(21, 86);
			this.trkb_duree.Maximum = 150;
			this.trkb_duree.Name = "trkb_duree";
			this.trkb_duree.Size = new System.Drawing.Size(406, 69);
			this.trkb_duree.SmallChange = 5;
			this.trkb_duree.TabIndex = 9;
			this.trkb_duree.TickFrequency = 10;
			this.trkb_duree.ValueChanged += new System.EventHandler(this.trkb_duree_ValueChanged);
			// 
			// lbl_duree
			// 
			this.lbl_duree.AutoSize = true;
			this.lbl_duree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_duree.Location = new System.Drawing.Point(142, 158);
			this.lbl_duree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_duree.Name = "lbl_duree";
			this.lbl_duree.Size = new System.Drawing.Size(140, 37);
			this.lbl_duree.TabIndex = 8;
			this.lbl_duree.Text = "0 minute";
			// 
			// lbl_TitleDuree
			// 
			this.lbl_TitleDuree.AutoEllipsis = true;
			this.lbl_TitleDuree.BackColor = System.Drawing.Color.Transparent;
			this.lbl_TitleDuree.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_TitleDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TitleDuree.Location = new System.Drawing.Point(0, 8);
			this.lbl_TitleDuree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_TitleDuree.Name = "lbl_TitleDuree";
			this.lbl_TitleDuree.Size = new System.Drawing.Size(444, 54);
			this.lbl_TitleDuree.TabIndex = 6;
			this.lbl_TitleDuree.Text = "Choisissez la durée";
			this.lbl_TitleDuree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cpn_Budget
			// 
			this.cpn_Budget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.cpn_Budget.BorderRadius = 12;
			this.cpn_Budget.Controls.Add(this.rdb_grand);
			this.cpn_Budget.Controls.Add(this.rdb_moyen);
			this.cpn_Budget.Controls.Add(this.rdb_petit);
			this.cpn_Budget.Controls.Add(this.lbl_TitleBudget);
			this.cpn_Budget.ForeColor = System.Drawing.Color.White;
			this.cpn_Budget.Location = new System.Drawing.Point(876, 372);
			this.cpn_Budget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cpn_Budget.Name = "cpn_Budget";
			this.cpn_Budget.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.cpn_Budget.Size = new System.Drawing.Size(878, 192);
			this.cpn_Budget.TabIndex = 8;
			// 
			// rdb_grand
			// 
			this.rdb_grand.BackColor = System.Drawing.Color.Transparent;
			this.rdb_grand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_grand.Location = new System.Drawing.Point(594, 96);
			this.rdb_grand.Name = "rdb_grand";
			this.rdb_grand.Size = new System.Drawing.Size(230, 43);
			this.rdb_grand.TabIndex = 8;
			this.rdb_grand.Text = "Grand budget";
			this.rdb_grand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdb_grand.UseVisualStyleBackColor = false;
			// 
			// rdb_moyen
			// 
			this.rdb_moyen.BackColor = System.Drawing.Color.Transparent;
			this.rdb_moyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_moyen.Location = new System.Drawing.Point(314, 96);
			this.rdb_moyen.Name = "rdb_moyen";
			this.rdb_moyen.Size = new System.Drawing.Size(230, 43);
			this.rdb_moyen.TabIndex = 7;
			this.rdb_moyen.Text = "Budget moyen";
			this.rdb_moyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdb_moyen.UseVisualStyleBackColor = false;
			// 
			// rdb_petit
			// 
			this.rdb_petit.BackColor = System.Drawing.Color.Transparent;
			this.rdb_petit.Checked = true;
			this.rdb_petit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_petit.Location = new System.Drawing.Point(43, 96);
			this.rdb_petit.Name = "rdb_petit";
			this.rdb_petit.Size = new System.Drawing.Size(230, 43);
			this.rdb_petit.TabIndex = 6;
			this.rdb_petit.TabStop = true;
			this.rdb_petit.Text = "Petit budget";
			this.rdb_petit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdb_petit.UseVisualStyleBackColor = false;
			// 
			// lbl_TitleBudget
			// 
			this.lbl_TitleBudget.AutoEllipsis = true;
			this.lbl_TitleBudget.BackColor = System.Drawing.Color.Transparent;
			this.lbl_TitleBudget.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_TitleBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TitleBudget.Location = new System.Drawing.Point(0, 8);
			this.lbl_TitleBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_TitleBudget.Name = "lbl_TitleBudget";
			this.lbl_TitleBudget.Size = new System.Drawing.Size(878, 65);
			this.lbl_TitleBudget.TabIndex = 5;
			this.lbl_TitleBudget.Text = "Choisissez le Budget";
			this.lbl_TitleBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cpn_Type
			// 
			this.cpn_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.cpn_Type.BorderRadius = 12;
			this.cpn_Type.Controls.Add(this.pnl_Familles);
			this.cpn_Type.Controls.Add(this.lbl_TitleType);
			this.cpn_Type.ForeColor = System.Drawing.Color.White;
			this.cpn_Type.Location = new System.Drawing.Point(876, 12);
			this.cpn_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cpn_Type.Name = "cpn_Type";
			this.cpn_Type.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.cpn_Type.Size = new System.Drawing.Size(878, 326);
			this.cpn_Type.TabIndex = 7;
			// 
			// pnl_Familles
			// 
			this.pnl_Familles.AutoScroll = true;
			this.pnl_Familles.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Familles.Location = new System.Drawing.Point(0, 62);
			this.pnl_Familles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnl_Familles.Name = "pnl_Familles";
			this.pnl_Familles.Size = new System.Drawing.Size(878, 265);
			this.pnl_Familles.TabIndex = 5;
			// 
			// lbl_TitleType
			// 
			this.lbl_TitleType.AutoEllipsis = true;
			this.lbl_TitleType.BackColor = System.Drawing.Color.Transparent;
			this.lbl_TitleType.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_TitleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TitleType.Location = new System.Drawing.Point(0, 8);
			this.lbl_TitleType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_TitleType.Name = "lbl_TitleType";
			this.lbl_TitleType.Size = new System.Drawing.Size(878, 54);
			this.lbl_TitleType.TabIndex = 4;
			this.lbl_TitleType.Text = "Choisissez le type de plat";
			this.lbl_TitleType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cpn_Ingredients
			// 
			this.cpn_Ingredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
			this.cpn_Ingredients.BorderRadius = 12;
			this.cpn_Ingredients.Controls.Add(this.pnl_recapIngredients);
			this.cpn_Ingredients.Controls.Add(this.pnl_AffichageIngredients);
			this.cpn_Ingredients.Controls.Add(this.lbl_ChoixCategorie);
			this.cpn_Ingredients.Controls.Add(this.cbxIngredients);
			this.cpn_Ingredients.Controls.Add(this.lbl_TitleIngredients);
			this.cpn_Ingredients.ForeColor = System.Drawing.Color.White;
			this.cpn_Ingredients.Location = new System.Drawing.Point(4, 5);
			this.cpn_Ingredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cpn_Ingredients.Name = "cpn_Ingredients";
			this.cpn_Ingredients.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.cpn_Ingredients.Size = new System.Drawing.Size(828, 946);
			this.cpn_Ingredients.TabIndex = 6;
			// 
			// pnl_recapIngredients
			// 
			this.pnl_recapIngredients.BackColor = System.Drawing.Color.Transparent;
			this.pnl_recapIngredients.Controls.Add(this.pictureBox2);
			this.pnl_recapIngredients.Controls.Add(this.lbl_PresentationIngredients);
			this.pnl_recapIngredients.Controls.Add(this.pictureBox1);
			this.pnl_recapIngredients.Controls.Add(this.pb1);
			this.pnl_recapIngredients.Controls.Add(this.lbl_Ingredient2);
			this.pnl_recapIngredients.Controls.Add(this.lbl_Ingredient3);
			this.pnl_recapIngredients.Controls.Add(this.lbl_Ingredient1);
			this.pnl_recapIngredients.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_recapIngredients.Location = new System.Drawing.Point(0, 792);
			this.pnl_recapIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnl_recapIngredients.Name = "pnl_recapIngredients";
			this.pnl_recapIngredients.Size = new System.Drawing.Size(828, 154);
			this.pnl_recapIngredients.TabIndex = 11;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Cuist_assist.Properties.Resources.bin;
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(288, 115);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(31, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "2";
			this.pictureBox2.Click += new System.EventHandler(this.delete_selection);
			// 
			// lbl_PresentationIngredients
			// 
			this.lbl_PresentationIngredients.AutoSize = true;
			this.lbl_PresentationIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_PresentationIngredients.Location = new System.Drawing.Point(48, 0);
			this.lbl_PresentationIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_PresentationIngredients.Name = "lbl_PresentationIngredients";
			this.lbl_PresentationIngredients.Size = new System.Drawing.Size(362, 33);
			this.lbl_PresentationIngredients.TabIndex = 7;
			this.lbl_PresentationIngredients.Text = "Ingrédients séléctionnées :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Cuist_assist.Properties.Resources.bin;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(288, 80);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "1";
			this.pictureBox1.Click += new System.EventHandler(this.delete_selection);
			// 
			// pb1
			// 
			this.pb1.Image = global::Cuist_assist.Properties.Resources.bin;
			this.pb1.InitialImage = null;
			this.pb1.Location = new System.Drawing.Point(288, 43);
			this.pb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(31, 31);
			this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb1.TabIndex = 8;
			this.pb1.TabStop = false;
			this.pb1.Tag = "0";
			this.pb1.Click += new System.EventHandler(this.delete_selection);
			// 
			// lbl_Ingredient2
			// 
			this.lbl_Ingredient2.AutoSize = true;
			this.lbl_Ingredient2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Ingredient2.Location = new System.Drawing.Point(49, 81);
			this.lbl_Ingredient2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Ingredient2.Name = "lbl_Ingredient2";
			this.lbl_Ingredient2.Size = new System.Drawing.Size(25, 29);
			this.lbl_Ingredient2.TabIndex = 6;
			this.lbl_Ingredient2.Tag = "2";
			this.lbl_Ingredient2.Text = "・";
			// 
			// lbl_Ingredient3
			// 
			this.lbl_Ingredient3.AutoSize = true;
			this.lbl_Ingredient3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Ingredient3.Location = new System.Drawing.Point(49, 117);
			this.lbl_Ingredient3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Ingredient3.Name = "lbl_Ingredient3";
			this.lbl_Ingredient3.Size = new System.Drawing.Size(25, 29);
			this.lbl_Ingredient3.TabIndex = 5;
			this.lbl_Ingredient3.Tag = "3";
			this.lbl_Ingredient3.Text = "・";
			// 
			// lbl_Ingredient1
			// 
			this.lbl_Ingredient1.AutoSize = true;
			this.lbl_Ingredient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Ingredient1.Location = new System.Drawing.Point(49, 43);
			this.lbl_Ingredient1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Ingredient1.Name = "lbl_Ingredient1";
			this.lbl_Ingredient1.Size = new System.Drawing.Size(25, 29);
			this.lbl_Ingredient1.TabIndex = 0;
			this.lbl_Ingredient1.Tag = "1";
			this.lbl_Ingredient1.Text = "・";
			// 
			// pnl_AffichageIngredients
			// 
			this.pnl_AffichageIngredients.AutoScroll = true;
			this.pnl_AffichageIngredients.BackColor = System.Drawing.Color.Transparent;
			this.pnl_AffichageIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnl_AffichageIngredients.Location = new System.Drawing.Point(39, 172);
			this.pnl_AffichageIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnl_AffichageIngredients.Name = "pnl_AffichageIngredients";
			this.pnl_AffichageIngredients.Size = new System.Drawing.Size(674, 422);
			this.pnl_AffichageIngredients.TabIndex = 4;
			// 
			// lbl_ChoixCategorie
			// 
			this.lbl_ChoixCategorie.AutoSize = true;
			this.lbl_ChoixCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ChoixCategorie.Location = new System.Drawing.Point(14, 109);
			this.lbl_ChoixCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_ChoixCategorie.Name = "lbl_ChoixCategorie";
			this.lbl_ChoixCategorie.Size = new System.Drawing.Size(506, 33);
			this.lbl_ChoixCategorie.TabIndex = 3;
			this.lbl_ChoixCategorie.Text = "Choisissez une catégorie d\'aliments : ";
			// 
			// cbxIngredients
			// 
			this.cbxIngredients.ForeColor = System.Drawing.Color.Black;
			this.cbxIngredients.Location = new System.Drawing.Point(510, 114);
			this.cbxIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbxIngredients.Name = "cbxIngredients";
			this.cbxIngredients.Size = new System.Drawing.Size(290, 28);
			this.cbxIngredients.TabIndex = 2;
			this.cbxIngredients.SelectedValueChanged += new System.EventHandler(this.cbxIngredients_SelectedValueChanged);
			// 
			// lbl_TitleIngredients
			// 
			this.lbl_TitleIngredients.AutoEllipsis = true;
			this.lbl_TitleIngredients.BackColor = System.Drawing.Color.Transparent;
			this.lbl_TitleIngredients.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_TitleIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TitleIngredients.Location = new System.Drawing.Point(0, 8);
			this.lbl_TitleIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_TitleIngredients.Name = "lbl_TitleIngredients";
			this.lbl_TitleIngredients.Size = new System.Drawing.Size(828, 54);
			this.lbl_TitleIngredients.TabIndex = 0;
			this.lbl_TitleIngredients.Text = "Choisissez maximum trois ingrédients";
			this.lbl_TitleIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SearchPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.btn_recherche);
			this.Controls.Add(this.cpn_Note);
			this.Controls.Add(this.cpn_Duree);
			this.Controls.Add(this.cpn_Budget);
			this.Controls.Add(this.cpn_Type);
			this.Controls.Add(this.cpn_Ingredients);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SearchPage";
			this.Size = new System.Drawing.Size(1172, 661);
			this.cpn_Note.ResumeLayout(false);
			this.cpn_Note.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkb_note)).EndInit();
			this.cpn_Duree.ResumeLayout(false);
			this.cpn_Duree.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkb_duree)).EndInit();
			this.cpn_Budget.ResumeLayout(false);
			this.cpn_Type.ResumeLayout(false);
			this.cpn_Ingredients.ResumeLayout(false);
			this.cpn_Ingredients.PerformLayout();
			this.pnl_recapIngredients.ResumeLayout(false);
			this.pnl_recapIngredients.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomPanel cpn_Ingredients;
		private System.Windows.Forms.Label lbl_ChoixCategorie;
		private System.Windows.Forms.ComboBox cbxIngredients;
		private System.Windows.Forms.Label lbl_TitleIngredients;
		private CustomPanel cpn_Type;
		private System.Windows.Forms.Label lbl_TitleType;
		private CustomPanel cpn_Budget;
		private System.Windows.Forms.Label lbl_TitleBudget;
		private CustomPanel cpn_Duree;
		private System.Windows.Forms.Label lbl_TitleDuree;
		private CustomPanel cpn_Note;
		private System.Windows.Forms.Label lbl_TitleNote;
		private System.Windows.Forms.Label lbl_duree;
		private System.Windows.Forms.Panel pnl_AffichageIngredients;
		private System.Windows.Forms.Button btn_recherche;
		private System.Windows.Forms.Label lbl_PresentationIngredients;
		private System.Windows.Forms.Label lbl_Ingredient2;
		private System.Windows.Forms.Label lbl_Ingredient3;
		private System.Windows.Forms.Label lbl_Ingredient1;
		private System.Windows.Forms.PictureBox pb1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnl_Familles;
		private System.Windows.Forms.RadioButton rdb_petit;
		private System.Windows.Forms.RadioButton rdb_grand;
		private System.Windows.Forms.RadioButton rdb_moyen;
		private System.Windows.Forms.Panel pnl_recapIngredients;
		private System.Windows.Forms.TrackBar trkb_duree;
		private System.Windows.Forms.TrackBar trkb_note;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label lbl_note;
	}
}
