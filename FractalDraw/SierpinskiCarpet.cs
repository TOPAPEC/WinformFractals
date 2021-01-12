using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Form1
    {
        class SierpinskiCarpet : Fractal
        {
            /// <summary>
            /// Draws fractal in the picturebox.
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
                var distanceBetweenSegmentsCoef = new List<double>();
                int recLimit;
                if (!int.TryParse(form.textBoxRecDepth.Text, out recLimit) || recLimit <= 0 || recLimit > 7)
                {
                    string error;
                    error = "Incorrect recursion depth. ";
                    error += "You should enter integer in [1;7]. The default value 3 is set.";
                    MessageBox.Show(error);
                    recLimit = 3;
                    form.textBoxRecDepth.Text = "3";
                }
                GetGradientColorsToList(form, recLimit, gradientList);
                RecDrawCarp(form, 0, recLimit, new RectangleF(0, 0, baseRes, baseRes), gradientList);
                return img;
            }

            private void RecDrawCarp(FractalDraw.Form1 form, int recDepth, int recDepthLimit, RectangleF rect, List<Color> gradientList)
            {
                if (recDepth == recDepthLimit)
                {
                    return;
                }
                else
                {
                    try
                    {
                        using (var graphics = Graphics.FromImage(img))
                        {
                            graphics.FillRectangle(new SolidBrush(gradientList[recDepth]), rect);
                        }
                        if (recDepth <= 2)
                        {
                            form.pictureBoxFractalDraw.Image = img;
                            form.pictureBoxFractalDraw.Refresh();
                        }
                    }
                    catch(Exception)
                    {

                    }
                    

                    // Divide into 9 new rectangles and draw them.
                    float wid = rect.Width / 3f;
                    float x0 = rect.Left;
                    float x1 = x0 + wid;
                    float x2 = x0 + wid * 2f;

                    float hgt = rect.Height / 3f;
                    float y0 = rect.Top;
                    float y1 = y0 + hgt;
                    float y2 = y0 + hgt * 2f;

                    
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x0, y0, wid, hgt), gradientList);
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x1, y0, wid, hgt), gradientList);
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x2, y0, wid, hgt), gradientList);
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x0, y1, wid, hgt), gradientList);
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x2, y1, wid, hgt), gradientList);
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x0, y2, wid, hgt), gradientList);
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x1, y2, wid, hgt), gradientList);
                    RecDrawCarp(form, recDepth + 1, recDepthLimit, new RectangleF(x2, y2, wid, hgt), gradientList);
                }
            }
        }
    }
}

