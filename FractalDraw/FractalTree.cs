using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Form1
    {
        class FractalTree : Fractal
        {
            bool firstStartFlag;
            /// <summary>
            /// Constructor.
            /// </summary>
            public FractalTree()
            {
                firstStartFlag = true;
            }
            /// <summary>
            /// Draws fractal tree in picturebox of form.
            /// </summary>
            /// <param name="form"></param>
            public override Bitmap FractalDraw(FractalDraw.Form1 form)
            {
                // We set beckground to white from transperent.
                using (var graphics = Graphics.FromImage(img))
                {
                    graphics.Clear(Color.White);
                }
                // Next layer of fractal tree tuples (point + angle + length + width).
                var nextQueue = new Queue<(Point, double, double, double)>();
                // Current layer of abstract tree tuples (point + angle + length + width).
                var curQueue = new Queue<(Point, double, double, double)>();
                var angle = Math.PI / 2;
                var length = 250.0;
                double width = 50;
                // Start point is added to Queue.
                curQueue.Enqueue((new Point(img.Width / 2, (int)(img.Height * 0.8)), angle, length, width));
                int recLimit;
                double segmentRatio, angleOfFirstSegment, angleOfSecondSegment;
                GetInfoFromBoxes(form, out recLimit, out segmentRatio, out angleOfFirstSegment, out angleOfSecondSegment);
                // Variable is explained by the function it is set with. 
                List<Color> gradientList = new List<Color>();
                GetGradientColorsToList(form, recLimit, gradientList);
                // Current depth of the tree.
                int curRec = 0;
                // On each iteration it works with Points from current Queue and adds Point to nextQueue.
                while (recLimit > curRec)
                {
                    try
                    {
                        Point currentPoint;
                        while (curQueue.Count > 0)
                        {
                            (currentPoint, angle, length, width) = curQueue.Dequeue();
                            // Create next point to put it into nextQueue. 
                            Point newPoint = new Point(currentPoint.X + (int)(length * Math.Cos(angle)),
                                currentPoint.Y - (int)(length * Math.Sin(angle)));
                            Pen pen = new Pen(gradientList[curRec], (float)width);
                            nextQueue.Enqueue((newPoint, angle + angleOfFirstSegment * Math.PI, length * segmentRatio, width * segmentRatio));
                            nextQueue.Enqueue((newPoint, angle - angleOfSecondSegment * Math.PI, length * segmentRatio, width * segmentRatio));
                            using (var graphics = Graphics.FromImage(img))
                            {
                                graphics.DrawLine(pen, currentPoint, newPoint);
                            }
                        }
                        // Refresh the picturebox after each iteration.
                        form.pictureBoxFractalDraw.Image = img;
                        form.pictureBoxFractalDraw.Refresh();
                        curQueue = nextQueue;
                        nextQueue = new Queue<(Point, double, double, double)>();
                        curRec++;
                    }
                    catch (Exception)
                    {

                    }

                }

                return img;
            }

            
            /// <summary>
            /// Parse all info from textboxes.
            /// </summary>
            /// <param name="form"></param>
            /// <param name="recLimit"></param>
            /// <param name="segmentRatio"></param>
            /// <param name="angleOfFirstSegment"></param>
            /// <param name="angleOfSecondSegment"></param>
            private void GetInfoFromBoxes(FractalDraw.Form1 form, out int recLimit, out double segmentRatio, out double angleOfFirstSegment, out double angleOfSecondSegment)
            {
                // Information needed for construction is extracted from text boxes.
                recLimit = 0;
                segmentRatio = 0;
                angleOfFirstSegment = 0;
                angleOfSecondSegment = 0;
                // List in which we collect error messages.
                List<string> incorrectFieldInputErrors = new List<string>();
                // From now the code is pretty self explaining.
                if (!double.TryParse(form.textBoxSegmentRatio.Text, out segmentRatio) || segmentRatio <= 0 || segmentRatio > 0.8)
                {
                    string err;
                    if (firstStartFlag)
                    {
                        err = "Incorrect segment ratio.";
                    }
                    else
                    {
                        err = "Enter segment ratio. ";
                    }
                    err += "You should enter real number from (0;1). The default value 0.8 is set.";
                    incorrectFieldInputErrors.Add(err);
                    segmentRatio = 0.8;
                    form.textBoxSegmentRatio.Text = "0,8";
                }
                if (!double.TryParse(form.textBoxAngleOfFirstSegment.Text, out angleOfFirstSegment) || angleOfFirstSegment <= 0 || angleOfFirstSegment >= 0.5)
                {
                    string err;
                    if (firstStartFlag)
                    {
                        err = "Incorrect angle of first segment. ";
                    }
                    else
                    {
                        err = "Enter angle of first segment. ";
                    }
                    err += "You should enter real number from (0;0,5). The angle will be PI* yourInput. The default value 0.25 is set.";
                    incorrectFieldInputErrors.Add(err);
                    angleOfFirstSegment = 0.25;
                    form.textBoxAngleOfFirstSegment.Text = "0,25";
                }
                if (!double.TryParse(form.textBoxAngleOfSecondSegment.Text, out angleOfSecondSegment) || angleOfSecondSegment <= 0 || angleOfSecondSegment >= 0.5)
                {
                    string err;
                    if (firstStartFlag)
                    {
                        err = "Incorrect angle of second segment. ";
                    }
                    else
                    {
                        err = "Enter angle of second segment. ";
                    }
                    err += "You should enter real number from (0;0,5). The angle will be PI* yourInput. The default value 0.25 is set.";
                    incorrectFieldInputErrors.Add(err);
                    angleOfSecondSegment = 0.25;
                    form.textBoxAngleOfSecondSegment.Text = "0,25";
                }
                if (!int.TryParse(form.textBoxRecDepth.Text, out recLimit) || recLimit <= 0 || recLimit > 20)
                {
                    string err;
                    if (firstStartFlag)
                    {
                        err = "Incorrect recursion depth. ";
                    }
                    else
                    {
                        err = "Enter recursion depth. ";
                    }
                    err += "You should enter integer in [1;20]. The default value 5 is set.";
                    incorrectFieldInputErrors.Add(err);
                    recLimit = 5;
                    form.textBoxRecDepth.Text = "5";
                }
                // After we collected all the errors, we display them in one messagebox.
                firstStartFlag = false;
                if (incorrectFieldInputErrors.Count > 0)
                {
                    string errorMessage = "";
                    foreach (var mes in incorrectFieldInputErrors)
                    {
                        errorMessage += mes + Environment.NewLine;
                    }
                    MessageBox.Show(errorMessage);

                }
            }
        }
    }
}

