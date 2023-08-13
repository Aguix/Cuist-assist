using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuist_assist {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}





		public static void RadiusPaint(PaintEventArgs pevent, Control control, int borderSize, int borderRadius, Color mainColor) {
			Rectangle rectSurface = control.ClientRectangle;
			Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
			int smoothSize = 2;
			if(borderSize > 0)
				smoothSize = borderSize;

			if(borderRadius > 2) { //Rounded button
				using(GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
				using(GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
				using(Pen penSurface = new Pen(control.Parent.BackColor, smoothSize))
				using(Pen penBorder = new Pen(mainColor, borderSize)) {
					pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					//Button surface
					control.Region = new Region(pathSurface);
					//Draw surface border for HD result
					pevent.Graphics.DrawPath(penSurface, pathSurface);

					//Button border                    
					if(borderSize >= 1)
						//Draw control border
						pevent.Graphics.DrawPath(penBorder, pathBorder);
				}
			}
		}
		private static GraphicsPath GetFigurePath(Rectangle rect, int radius) {
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}
	}
}
