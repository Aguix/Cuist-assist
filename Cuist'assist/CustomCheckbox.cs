using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
	internal class CustomCheckbox : CheckBox {
		private int borderSize = 0;
		private int borderRadius = 40;
		private Color mainColor = Color.FromArgb(97, 11, 52);


		[Category("Apparence")]
		public int BorderRadius {
			get { return borderRadius; }
			set {
				borderRadius = value;
				this.Invalidate();
			}
		}

		public CustomCheckbox() {
			this.Text = "Checkbox";
			this.TextAlign = ContentAlignment.MiddleCenter;
			this.Cursor = Cursors.Hand;

			this.AutoSize = false;
			//base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.Size = new Size(80, 40);

			this.Resize += new EventHandler(Button_Resize);
			this.MinimumSize = new Size(80, 40);

			this.FlatStyle = FlatStyle.Flat;
			this.Appearance = Appearance.Button;
			this.BackColor = mainColor;
			this.FlatAppearance.CheckedBackColor = Color.FromArgb(148, 26, 128);
			this.ForeColor = Color.White;

			this.FlatAppearance.BorderSize = 0;
			this.BorderRadius = this.Size.Height / 2;
		}



		protected override void OnPaint(PaintEventArgs pevent) {
			base.OnPaint(pevent);
			Form1.RadiusPaint(pevent, this, borderSize, borderRadius, mainColor);
		}
		protected override void OnHandleCreated(EventArgs e) {
			base.OnHandleCreated(e);
			this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
		}

		private void Container_BackColorChanged(object sender, EventArgs e) {
			this.Invalidate();
		}
		private void Button_Resize(object sender, EventArgs e) {
			this.BorderRadius = this.Size.Height / 2;
		}
	}
}
