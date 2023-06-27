using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
	internal class CustomPanel : Panel{
		//Fields
		private int borderSize = 0;
		private int borderRadius = 40;
		private Color mainColor = Color.FromArgb(23, 29, 31);

		[Category("Apparence")]
		public int BorderRadius {
			get { return borderRadius; }
			set {
				borderRadius = value;
				this.Invalidate();
			}
		}

		public CustomPanel() {
			this.BackColor = mainColor;
			this.ForeColor = Color.White;
			this.BorderRadius = this.Size.Height / 8;
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
			this.BorderRadius = this.Size.Height / 8;
		}
	}
}