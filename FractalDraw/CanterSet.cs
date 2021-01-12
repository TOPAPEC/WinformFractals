using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Form1
    {
        class CanterSet : Fractal
        {
            // Width of soon to be drawn lines and vertical distance between them.
            const float widthOfLine = 50;
            const int distanceBetweenLines = 80;
            /// <summary>
            /// Draws Canter set in the picturebox.
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
                if (!int.TryParse(form.textBoxRecDepth.Text, out recLimit) || recLimit <= 0 || recLimit > 10)
                {
                    string error;
                    error = "Incorrect recursion depth. ";
                    error += "You should enter integer in [1;10]. The default value 5 is set.";
                    MessageBox.Show(error);
                    recLimit = 5;
                    form.textBoxRecDepth.Text = "5";
                }
                // As we parse multiple variables in loop we need a flag that will tell us about unsuccessful parse.
                bool errorFlag = false;
                var splitedDist = form.textBoxDistanceBetweenSegmentsCanterSet.Text.Split(' ');
                if (splitedDist.Length != recLimit - 1)
                {
                    errorFlag = true;
                }
                foreach (var elem in splitedDist)
                {
                    double a;
                    if(!double.TryParse(elem, out a) || a > 1 || a < -0.5)
                    {
                        errorFlag = true;
                    }
                    distanceBetweenSegmentsCoef.Add(a);
                }
                // If error occured we set default values and display message.
                if (errorFlag)
                {
                    MessageBox.Show("Distances between segments is real numbers from [-0,5;1]. The distance is calculated as 1/3 * (length of big segment on this level) +" +
                        "{your number} * (length of big segment on this level. The default value 0 is set for all distances.");
                    string def = "0";
                    distanceBetweenSegmentsCoef.Clear();
                    distanceBetweenSegmentsCoef.Add(0);
                    distanceBetweenSegmentsCoef.Add(0);
                    for (int i = 0; i < recLimit - 2; ++i)
                    {
                        def += " 0";
                        distanceBetweenSegmentsCoef.Add(0);
                    }
                    form.textBoxDistanceBetweenSegmentsCanterSet.Text = def;
                    form.Refresh();
                }
                GetGradientColorsToList(form, recLimit, gradientList);
                Point startPoint = new Point(0, 100);
                Point endPoint = new Point(baseRes, 100);
                recursiveDraw(startPoint, endPoint, 0, recLimit, gradientList, form, distanceBetweenSegmentsCoef);
                return img;
            }
            /// <summary>
            /// Recursively draws each layer of Canter Set.
            /// </summary>
            /// <param name="startPoint"></param>
            /// <param name="endPoint"></param>
            /// <param name="recDepth"></param>
            /// <param name="recDepthLimit"></param>
            /// <param name="gradientList"></param>
            /// <param name="form"></param>
            /// <param name="distanceBetweenSegmentsCoef"></param>
            public void recursiveDraw(Point startPoint, Point endPoint, int recDepth, int recDepthLimit, List<Color> gradientList, FractalDraw.Form1 form, List<double> distanceBetweenSegmentsCoef)
            {
                Pen pen = new Pen(gradientList[recDepth], (float)widthOfLine);
                try
                {
                    using (var graphics = Graphics.FromImage(img))
                    {
                        graphics.DrawLine(pen, startPoint, endPoint);
                    }
                    form.pictureBoxFractalDraw.Image = img;
                    form.pictureBoxFractalDraw.Refresh();
                }
                catch(Exception)
                {

                }
                
                if (recDepth == recDepthLimit - 1)
                    return;
                /// We calculate positions of next segments and send them to next draw functions.
                int lengthOfNextSegment = (int)((endPoint.X - startPoint.X) * (1.0 - (1.0 / 3) * distanceBetweenSegmentsCoef[recDepth] - (1.0 / 3)) / 2);
                recursiveDraw(new Point(startPoint.X, startPoint.Y + distanceBetweenLines), new Point(startPoint.X + lengthOfNextSegment, startPoint.Y + distanceBetweenLines), recDepth + 1, recDepthLimit,
                    gradientList, form, distanceBetweenSegmentsCoef);
                recursiveDraw(new Point(endPoint.X - lengthOfNextSegment, endPoint.Y + distanceBetweenLines), new Point(endPoint.X, endPoint.Y + distanceBetweenLines), recDepth + 1, recDepthLimit,
                    gradientList, form, distanceBetweenSegmentsCoef);
            }
        }
    }
}

