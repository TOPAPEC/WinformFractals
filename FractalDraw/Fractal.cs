using System;
using System.Collections.Generic;
using System.Drawing;

namespace FractalDraw
{
    public partial class Form1
    {
        class Fractal
        {
            protected Color startColor;
            protected Color endColor;
            public Bitmap img = new Bitmap(baseRes, baseRes);
            
            public virtual Bitmap FractalDraw(FractalDraw.Form1 form) { throw new NotImplementedException(); }
            /// <summary>
            /// Create array with colors. Number of colors - number of iterations on fractal draw. First color - start color that is set by the user.
            /// Last color - end color that is set by the user too. Colors between the first and the last - gradient from first to last.
            /// </summary>
            /// <param name="form"></param>
            /// <param name="recLimit"></param>
            /// <param name="gradientList"></param>
            protected void GetGradientColorsToList(Form1 form, int recLimit, List<Color> gradientList)
            {
                startColor = form.pictureBoxStartColor.BackColor;
                int sR, sG, sB;
                (sR, sG, sB) = (startColor.R, startColor.G, startColor.B);
                endColor = form.pictureBoxEndColor.BackColor;
                int eR, eG, eB;
                (eR, eG, eB) = (endColor.R, endColor.G, endColor.B);
                // Color delta - how fast each color is changing while we go from startC to endC.
                double dR, dG, dB;
                dR = (double)(eR - sR) / recLimit;
                dG = (double)(eG - sG) / recLimit;
                dB = (double)(eB - sB) / recLimit;
                int cR = sR;
                int cG = sG;
                int cB = sB;
                // Creating a gradient.
                for (int i = 0; i < recLimit; ++i)
                {
                    gradientList.Add(Color.FromArgb(cR + (int)(dR * i), cG + (int)(dG * i), cB + (int)(dB * i)));
                }
            }
        }
    }
}

