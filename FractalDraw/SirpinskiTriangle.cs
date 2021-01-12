using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Form1
    {
        class SirpinskiTriangle : Fractal
        {
            /// <summary>
            /// Draws fractal in picturebox.
            /// </summary>
            /// <param name="form"></param>
            /// <returns></returns>
            public override Bitmap FractalDraw(FractalDraw.Form1 form)
            {
                // We set beckground to white from transperent.
                using (var graphics = Graphics.FromImage(img))
                {
                    graphics.Clear(Color.White);
                }
                // Variable is explained by the function it is set with. 
                var gradientList = new List<Color>();
                int recLimit;
                // Recursion depth limit is parsed.
                if (!int.TryParse(form.textBoxRecDepth.Text, out recLimit) || recLimit <= 0 || recLimit > 10)
                {
                    string error;
                    error = "Incorrect recursion depth. ";
                    error += "You should enter integer in [1;10]. The default value 5 is set.";
                    MessageBox.Show(error);
                    recLimit = 5;
                    form.textBoxRecDepth.Text = "5";
                }
                GetGradientColorsToList(form, recLimit, gradientList);
                SierpinskiTrDraw(form, new Point(1, baseRes - 10), new Point(baseRes - 1, baseRes - 10), new Point(baseRes / 2, 300), 0, recLimit, gradientList);
                return img;
            }

            public void SierpinskiTrDraw(FractalDraw.Form1 form, PointF lb, PointF rb, PointF up, int recDepth, int recDepthLimit, List<Color> gradientList)
            {
                if (recDepth == recDepthLimit)
                {
                    return;
                }
                // Creates point on center of each original triangle side.
                PointF ml = new PointF((lb.X + up.X) / 2, (lb.Y + up.Y) / 2);
                PointF mr = new PointF((rb.X + up.X) / 2, (rb.Y + up.Y) / 2);
                PointF mb = new PointF((lb.X + rb.X) / 2, (lb.Y + rb.Y) / 2);
                try
                {
                    using (var graphics = Graphics.FromImage(img))
                    {
                        PointF[] points = { lb, rb, up };
                        graphics.FillPolygon(new SolidBrush(gradientList[recDepth]), points);
                    }
                    if (recDepth <= 3)
                    {
                        form.pictureBoxFractalDraw.Image = img;
                        form.pictureBoxFractalDraw.Refresh();
                    }
                }
                catch(Exception)
                {

                }
                // Recursively lauches for each new triangle.
                SierpinskiTrDraw(form, lb, mb, ml, recDepth + 1, recDepthLimit, gradientList);
                SierpinskiTrDraw(form, mb, rb, mr, recDepth + 1, recDepthLimit, gradientList);
                SierpinskiTrDraw(form, ml, mr, up, recDepth + 1, recDepthLimit, gradientList);
            }
        }
    }
}

