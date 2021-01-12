using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Form1 : Form
    {
        const int baseRes = 1700;
        /// <summary>
        /// Image that is being displayed on the pictureBox when program is running.
        /// </summary>
        Bitmap currentImage = new Bitmap(baseRes, baseRes);
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("To make program draw something click on button with fractal name on it. You can customize your fractals via controls " +
                "from left side of the windows (basically you can choose how many iterations of fractal will be drawn, but there can be some other options). Also you can zoom in and out with help of zoom buttons. And finally, you can safe your fractal into .jpg file with" +
                " custom name you enter.");
        }
        /// <summary>
        /// Button that triggers Sierpinski Carpet draw.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSierpinskiCarpet_Click(object sender, EventArgs e)
        {
            HideAllAdditionalControls();

            labelRecHelpSirpCarpet.Show();
            this.Refresh();
            var spCarpet = new SierpinskiCarpet();
            currentImage = spCarpet.FractalDraw(this);
        }
        /// <summary>
        /// Button that triggers Sierpinski Triangle draw.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSierpiskiTriangle_Click(object sender, EventArgs e)
        {
            HideAllAdditionalControls();

            labelRecHelpSierpTr.Show();
            this.Refresh();
            var spTriangle = new SirpinskiTriangle();
            currentImage = spTriangle.FractalDraw(this);
        }
        /// <summary>
        /// Button that triggers Canter Set draw.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCanterSet_Click(object sender, EventArgs e)
        {
            HideAllAdditionalControls();

            textBoxDistanceBetweenSegmentsCanterSet.Show();
            labelDistanceBetweenSegments.Show();
            labelRecHelpCanterSet.Show();
            this.Refresh();
            var ctSet = new CanterSet();
            currentImage = ctSet.FractalDraw(this);

        }
        /// <summary>
        /// Button that triggers fractal tree draw.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFractalTree_Click(object sender, EventArgs e)
        {
            HideAllAdditionalControls();

            labelAngelOfFirstSegment.Show();
            labelAngelOfSecondSegment.Show();
            labelSegmentRatio.Show();
            textBoxAngleOfFirstSegment.Show();
            textBoxAngleOfSecondSegment.Show();
            textBoxSegmentRatio.Show();
            labelRecurHelp.Show();
            this.Refresh();
            var frTree = new FractalTree();
            currentImage = frTree.FractalDraw(this);
            pictureBoxFractalDraw.Refresh();

        }
        /// <summary>
        /// Button that triggers Koch Curve draw.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKochCurve_Click(object sender, EventArgs e)
        {
            HideAllAdditionalControls();

            labelRecHelpKochCurve.Show();
            this.Refresh();
            var khCurve = new KochCurve();
            currentImage = khCurve.FractalDraw(this);
        }
        /// <summary>
        /// Hides all additional fractal draw controls and labels with help to them.
        /// </summary>
        private void HideAllAdditionalControls()
        {
            textBoxAngleOfSecondSegment.Hide();
            labelAngelOfFirstSegment.Hide();
            labelAngelOfSecondSegment.Hide();
            labelSegmentRatio.Hide();
            textBoxAngleOfFirstSegment.Hide();
            labelDistanceBetweenSegments.Hide();
            labelSegmentLengthKantorSet.Hide();
            textBoxSegmentRatio.Hide();
            textBoxDistanceBetweenSegmentsCanterSet.Hide();
            labelRecHelpSirpCarpet.Hide();
            labelRecHelpCanterSet.Hide();
            labelRecurHelp.Hide();
            labelRecHelpSierpTr.Hide();
            labelRecHelpKochCurve.Hide();
        }


        /// <summary>
        /// Shows color dialog for start color of the fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartColor_Click(object sender, EventArgs e)
        {
            if (colorDialogStartColor.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStartColor.BackColor = colorDialogStartColor.Color;
            }
        }
        /// <summary>
        /// Shows color dialog for end color of fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEndColor_Click(object sender, EventArgs e)
        {
            if (colorDialogStartColor.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEndColor.BackColor = colorDialogStartColor.Color;
            }
        }

        private void pictureBoxFractalDraw_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Set image's zoom to 1x.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZoom1x_Click(object sender, EventArgs e)
        {
            var ZoomedImage = ResizeBitmap(currentImage, baseRes, baseRes);
            pictureBoxFractalDraw.Image = ZoomedImage;
        }
        /// <summary>
        /// Resizes bitmap using drawImage function.
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
        /// <summary>
        /// Set image's zoom to 2x.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZoom2x_Click(object sender, EventArgs e)
        {
            var ZoomedImage = ResizeBitmap(currentImage, baseRes * 2, baseRes * 2);
            pictureBoxFractalDraw.Image = ZoomedImage;
        }
        /// <summary>
        /// Set image's zoom to 3x.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZoom3x_Click(object sender, EventArgs e)
        {
            var ZoomedImage = ResizeBitmap(currentImage, baseRes * 3, baseRes * 3);
            pictureBoxFractalDraw.Image = ZoomedImage;
        }
        /// <summary>
        /// Set image's zoom to 5x.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZoom5x_Click(object sender, EventArgs e)
        {
            var ZoomedImage = ResizeBitmap(currentImage, baseRes * 5, baseRes * 5);
            pictureBoxFractalDraw.Image = ZoomedImage;
        }
        /// <summary>
        /// Trigger image saving to jpg file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveFractal_Click(object sender, EventArgs e)
        {
            string fileName = textBoxSaveFileName.Text;
            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 || fileName.Length == 0)
            {
                MessageBox.Show("Incorrect file name. Setting file name to default \"fractal\".");
                fileName = "fractal";
                textBoxSaveFileName.Text = fileName;
            }
            currentImage.Save(fileName + ".jpg", ImageFormat.Jpeg);
        }
    }
}

