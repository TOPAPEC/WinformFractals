namespace FractalDraw
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonKochCurve = new System.Windows.Forms.Button();
            this.buttonSierpinskiCarpet = new System.Windows.Forms.Button();
            this.buttonSierpiskiTriangle = new System.Windows.Forms.Button();
            this.buttonCantorSet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFractalTree = new System.Windows.Forms.Button();
            this.groupBoxControlElements = new System.Windows.Forms.GroupBox();
            this.labelRecHelpKochCurve = new System.Windows.Forms.Label();
            this.labelRecHelpSierpTr = new System.Windows.Forms.Label();
            this.labelRecHelpSirpCarpet = new System.Windows.Forms.Label();
            this.textBoxDistanceBetweenSegmentsCanterSet = new System.Windows.Forms.TextBox();
            this.labelRecHelpCanterSet = new System.Windows.Forms.Label();
            this.textBoxAngleOfSecondSegment = new System.Windows.Forms.TextBox();
            this.textBoxAngleOfFirstSegment = new System.Windows.Forms.TextBox();
            this.textBoxSegmentRatio = new System.Windows.Forms.TextBox();
            this.labelAngelOfSecondSegment = new System.Windows.Forms.Label();
            this.labelAngelOfFirstSegment = new System.Windows.Forms.Label();
            this.labelSegmentRatio = new System.Windows.Forms.Label();
            this.buttonSaveFractal = new System.Windows.Forms.Button();
            this.labelFIleSaveHelp = new System.Windows.Forms.Label();
            this.textBoxSaveFileName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStartColor = new System.Windows.Forms.Button();
            this.buttonEndColor = new System.Windows.Forms.Button();
            this.pictureBoxStartColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxEndColor = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZoom1x = new System.Windows.Forms.Button();
            this.buttonZoom2x = new System.Windows.Forms.Button();
            this.buttonZoom3x = new System.Windows.Forms.Button();
            this.buttonZoom5x = new System.Windows.Forms.Button();
            this.labelRecurHelp = new System.Windows.Forms.Label();
            this.textBoxRecDepth = new System.Windows.Forms.TextBox();
            this.labelDistanceBetweenSegments = new System.Windows.Forms.Label();
            this.labelSegmentLengthKantorSet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxFractalDraw = new System.Windows.Forms.PictureBox();
            this.colorDialogStartColor = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxControlElements.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndColor)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractalDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKochCurve
            // 
            this.buttonKochCurve.AutoSize = true;
            this.buttonKochCurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKochCurve.Location = new System.Drawing.Point(471, 3);
            this.buttonKochCurve.Name = "buttonKochCurve";
            this.buttonKochCurve.Size = new System.Drawing.Size(150, 30);
            this.buttonKochCurve.TabIndex = 1;
            this.buttonKochCurve.Text = "Koch curve";
            this.buttonKochCurve.UseVisualStyleBackColor = true;
            this.buttonKochCurve.Click += new System.EventHandler(this.buttonKochCurve_Click);
            // 
            // buttonSierpinskiCarpet
            // 
            this.buttonSierpinskiCarpet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSierpinskiCarpet.Location = new System.Drawing.Point(315, 3);
            this.buttonSierpinskiCarpet.Name = "buttonSierpinskiCarpet";
            this.buttonSierpinskiCarpet.Size = new System.Drawing.Size(150, 30);
            this.buttonSierpinskiCarpet.TabIndex = 2;
            this.buttonSierpinskiCarpet.Text = "Sierpinski carpet";
            this.buttonSierpinskiCarpet.UseVisualStyleBackColor = true;
            this.buttonSierpinskiCarpet.Click += new System.EventHandler(this.buttonSierpinskiCarpet_Click);
            // 
            // buttonSierpiskiTriangle
            // 
            this.buttonSierpiskiTriangle.AutoSize = true;
            this.buttonSierpiskiTriangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSierpiskiTriangle.Location = new System.Drawing.Point(159, 3);
            this.buttonSierpiskiTriangle.Name = "buttonSierpiskiTriangle";
            this.buttonSierpiskiTriangle.Size = new System.Drawing.Size(150, 30);
            this.buttonSierpiskiTriangle.TabIndex = 3;
            this.buttonSierpiskiTriangle.Text = "Sierpinski triangle";
            this.buttonSierpiskiTriangle.UseVisualStyleBackColor = true;
            this.buttonSierpiskiTriangle.Click += new System.EventHandler(this.buttonSierpiskiTriangle_Click);
            // 
            // buttonCantorSet
            // 
            this.buttonCantorSet.AutoSize = true;
            this.buttonCantorSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCantorSet.Location = new System.Drawing.Point(3, 3);
            this.buttonCantorSet.Name = "buttonCantorSet";
            this.buttonCantorSet.Size = new System.Drawing.Size(150, 30);
            this.buttonCantorSet.TabIndex = 4;
            this.buttonCantorSet.Text = "Cantor set";
            this.buttonCantorSet.UseVisualStyleBackColor = true;
            this.buttonCantorSet.Click += new System.EventHandler(this.buttonCanterSet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSierpiskiTriangle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSierpinskiCarpet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCantorSet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonKochCurve, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFractalTree, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 36);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonFractalTree
            // 
            this.buttonFractalTree.AutoSize = true;
            this.buttonFractalTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFractalTree.Location = new System.Drawing.Point(627, 3);
            this.buttonFractalTree.Name = "buttonFractalTree";
            this.buttonFractalTree.Size = new System.Drawing.Size(154, 30);
            this.buttonFractalTree.TabIndex = 5;
            this.buttonFractalTree.Text = "Fractal tree";
            this.buttonFractalTree.UseVisualStyleBackColor = true;
            this.buttonFractalTree.Click += new System.EventHandler(this.buttonFractalTree_Click);
            // 
            // groupBoxControlElements
            // 
            this.groupBoxControlElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControlElements.Controls.Add(this.labelRecHelpKochCurve);
            this.groupBoxControlElements.Controls.Add(this.labelRecHelpSierpTr);
            this.groupBoxControlElements.Controls.Add(this.labelRecHelpSirpCarpet);
            this.groupBoxControlElements.Controls.Add(this.textBoxDistanceBetweenSegmentsCanterSet);
            this.groupBoxControlElements.Controls.Add(this.labelRecHelpCanterSet);
            this.groupBoxControlElements.Controls.Add(this.textBoxAngleOfSecondSegment);
            this.groupBoxControlElements.Controls.Add(this.textBoxAngleOfFirstSegment);
            this.groupBoxControlElements.Controls.Add(this.textBoxSegmentRatio);
            this.groupBoxControlElements.Controls.Add(this.labelAngelOfSecondSegment);
            this.groupBoxControlElements.Controls.Add(this.labelAngelOfFirstSegment);
            this.groupBoxControlElements.Controls.Add(this.labelSegmentRatio);
            this.groupBoxControlElements.Controls.Add(this.buttonSaveFractal);
            this.groupBoxControlElements.Controls.Add(this.labelFIleSaveHelp);
            this.groupBoxControlElements.Controls.Add(this.textBoxSaveFileName);
            this.groupBoxControlElements.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxControlElements.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxControlElements.Controls.Add(this.labelRecurHelp);
            this.groupBoxControlElements.Controls.Add(this.textBoxRecDepth);
            this.groupBoxControlElements.Controls.Add(this.labelDistanceBetweenSegments);
            this.groupBoxControlElements.Controls.Add(this.labelSegmentLengthKantorSet);
            this.groupBoxControlElements.Location = new System.Drawing.Point(3, 42);
            this.groupBoxControlElements.Name = "groupBoxControlElements";
            this.groupBoxControlElements.Size = new System.Drawing.Size(153, 415);
            this.groupBoxControlElements.TabIndex = 8;
            this.groupBoxControlElements.TabStop = false;
            this.groupBoxControlElements.Text = "groupBox2";
            // 
            // labelRecHelpKochCurve
            // 
            this.labelRecHelpKochCurve.AutoSize = true;
            this.labelRecHelpKochCurve.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecHelpKochCurve.Location = new System.Drawing.Point(6, 48);
            this.labelRecHelpKochCurve.Name = "labelRecHelpKochCurve";
            this.labelRecHelpKochCurve.Size = new System.Drawing.Size(137, 36);
            this.labelRecHelpKochCurve.TabIndex = 10;
            this.labelRecHelpKochCurve.Text = "Recursion depth.\r\nShould be not bigger than 10.\r\n\r\n";
            this.labelRecHelpKochCurve.Visible = false;
            // 
            // labelRecHelpSierpTr
            // 
            this.labelRecHelpSierpTr.AutoSize = true;
            this.labelRecHelpSierpTr.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecHelpSierpTr.Location = new System.Drawing.Point(6, 48);
            this.labelRecHelpSierpTr.Name = "labelRecHelpSierpTr";
            this.labelRecHelpSierpTr.Size = new System.Drawing.Size(137, 24);
            this.labelRecHelpSierpTr.TabIndex = 10;
            this.labelRecHelpSierpTr.Text = "Recursion depth.\r\nShould be not bigger than 10.\r\n";
            this.labelRecHelpSierpTr.Visible = false;
            // 
            // labelRecHelpSirpCarpet
            // 
            this.labelRecHelpSirpCarpet.AutoSize = true;
            this.labelRecHelpSirpCarpet.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecHelpSirpCarpet.Location = new System.Drawing.Point(6, 48);
            this.labelRecHelpSirpCarpet.Name = "labelRecHelpSirpCarpet";
            this.labelRecHelpSirpCarpet.Size = new System.Drawing.Size(132, 36);
            this.labelRecHelpSirpCarpet.TabIndex = 16;
            this.labelRecHelpSirpCarpet.Text = "Recursion depth.\r\nShould be not bigger than 7.\r\n\r\n";
            this.labelRecHelpSirpCarpet.Visible = false;
            // 
            // textBoxDistanceBetweenSegmentsCanterSet
            // 
            this.textBoxDistanceBetweenSegmentsCanterSet.Location = new System.Drawing.Point(6, 272);
            this.textBoxDistanceBetweenSegmentsCanterSet.Name = "textBoxDistanceBetweenSegmentsCanterSet";
            this.textBoxDistanceBetweenSegmentsCanterSet.Size = new System.Drawing.Size(140, 23);
            this.textBoxDistanceBetweenSegmentsCanterSet.TabIndex = 15;
            this.textBoxDistanceBetweenSegmentsCanterSet.Visible = false;
            // 
            // labelRecHelpCanterSet
            // 
            this.labelRecHelpCanterSet.AutoSize = true;
            this.labelRecHelpCanterSet.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecHelpCanterSet.Location = new System.Drawing.Point(6, 48);
            this.labelRecHelpCanterSet.Name = "labelRecHelpCanterSet";
            this.labelRecHelpCanterSet.Size = new System.Drawing.Size(137, 24);
            this.labelRecHelpCanterSet.TabIndex = 1;
            this.labelRecHelpCanterSet.Text = "Recursion depth.\r\nShould be not bigger than 10.\r\n";
            this.labelRecHelpCanterSet.Visible = false;
            // 
            // textBoxAngleOfSecondSegment
            // 
            this.textBoxAngleOfSecondSegment.Location = new System.Drawing.Point(6, 272);
            this.textBoxAngleOfSecondSegment.Name = "textBoxAngleOfSecondSegment";
            this.textBoxAngleOfSecondSegment.Size = new System.Drawing.Size(141, 23);
            this.textBoxAngleOfSecondSegment.TabIndex = 12;
            this.textBoxAngleOfSecondSegment.Visible = false;
            // 
            // textBoxAngleOfFirstSegment
            // 
            this.textBoxAngleOfFirstSegment.Location = new System.Drawing.Point(6, 228);
            this.textBoxAngleOfFirstSegment.Name = "textBoxAngleOfFirstSegment";
            this.textBoxAngleOfFirstSegment.Size = new System.Drawing.Size(141, 23);
            this.textBoxAngleOfFirstSegment.TabIndex = 11;
            this.textBoxAngleOfFirstSegment.Visible = false;
            // 
            // textBoxSegmentRatio
            // 
            this.textBoxSegmentRatio.Location = new System.Drawing.Point(96, 207);
            this.textBoxSegmentRatio.Name = "textBoxSegmentRatio";
            this.textBoxSegmentRatio.Size = new System.Drawing.Size(51, 23);
            this.textBoxSegmentRatio.TabIndex = 10;
            this.textBoxSegmentRatio.Visible = false;
            // 
            // labelAngelOfSecondSegment
            // 
            this.labelAngelOfSecondSegment.AutoSize = true;
            this.labelAngelOfSecondSegment.Location = new System.Drawing.Point(1, 295);
            this.labelAngelOfSecondSegment.Name = "labelAngelOfSecondSegment";
            this.labelAngelOfSecondSegment.Size = new System.Drawing.Size(142, 15);
            this.labelAngelOfSecondSegment.TabIndex = 9;
            this.labelAngelOfSecondSegment.Text = "Angel of second segment";
            this.labelAngelOfSecondSegment.Visible = false;
            // 
            // labelAngelOfFirstSegment
            // 
            this.labelAngelOfFirstSegment.AutoSize = true;
            this.labelAngelOfFirstSegment.Location = new System.Drawing.Point(6, 254);
            this.labelAngelOfFirstSegment.Name = "labelAngelOfFirstSegment";
            this.labelAngelOfFirstSegment.Size = new System.Drawing.Size(124, 15);
            this.labelAngelOfFirstSegment.TabIndex = 8;
            this.labelAngelOfFirstSegment.Text = "Angel of first segment";
            this.labelAngelOfFirstSegment.Visible = false;
            // 
            // labelSegmentRatio
            // 
            this.labelSegmentRatio.AutoSize = true;
            this.labelSegmentRatio.Location = new System.Drawing.Point(6, 210);
            this.labelSegmentRatio.Name = "labelSegmentRatio";
            this.labelSegmentRatio.Size = new System.Drawing.Size(84, 15);
            this.labelSegmentRatio.TabIndex = 7;
            this.labelSegmentRatio.Text = "Segment Ratio";
            this.labelSegmentRatio.Visible = false;
            // 
            // buttonSaveFractal
            // 
            this.buttonSaveFractal.Location = new System.Drawing.Point(6, 382);
            this.buttonSaveFractal.Name = "buttonSaveFractal";
            this.buttonSaveFractal.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveFractal.TabIndex = 6;
            this.buttonSaveFractal.Text = "Save fractal";
            this.buttonSaveFractal.UseVisualStyleBackColor = true;
            this.buttonSaveFractal.Click += new System.EventHandler(this.buttonSaveFractal_Click);
            // 
            // labelFIleSaveHelp
            // 
            this.labelFIleSaveHelp.AutoSize = true;
            this.labelFIleSaveHelp.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFIleSaveHelp.Location = new System.Drawing.Point(6, 339);
            this.labelFIleSaveHelp.Name = "labelFIleSaveHelp";
            this.labelFIleSaveHelp.Size = new System.Drawing.Size(152, 39);
            this.labelFIleSaveHelp.TabIndex = 5;
            this.labelFIleSaveHelp.Text = "If you want to save fractal\r\nin JPG format, enter desired \r\nname without extensio" +
    "n. ";
            // 
            // textBoxSaveFileName
            // 
            this.textBoxSaveFileName.Location = new System.Drawing.Point(6, 313);
            this.textBoxSaveFileName.Name = "textBoxSaveFileName";
            this.textBoxSaveFileName.Size = new System.Drawing.Size(141, 23);
            this.textBoxSaveFileName.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonStartColor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonEndColor, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxStartColor, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxEndColor, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 148);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(143, 58);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonStartColor
            // 
            this.buttonStartColor.AutoSize = true;
            this.buttonStartColor.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartColor.Location = new System.Drawing.Point(3, 32);
            this.buttonStartColor.Name = "buttonStartColor";
            this.buttonStartColor.Size = new System.Drawing.Size(65, 23);
            this.buttonStartColor.TabIndex = 0;
            this.buttonStartColor.Text = "Start Color";
            this.buttonStartColor.UseVisualStyleBackColor = true;
            this.buttonStartColor.Click += new System.EventHandler(this.buttonStartColor_Click);
            // 
            // buttonEndColor
            // 
            this.buttonEndColor.AutoSize = true;
            this.buttonEndColor.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEndColor.Location = new System.Drawing.Point(74, 32);
            this.buttonEndColor.Name = "buttonEndColor";
            this.buttonEndColor.Size = new System.Drawing.Size(66, 23);
            this.buttonEndColor.TabIndex = 1;
            this.buttonEndColor.Text = "End Color";
            this.buttonEndColor.UseVisualStyleBackColor = true;
            this.buttonEndColor.Click += new System.EventHandler(this.buttonEndColor_Click);
            // 
            // pictureBoxStartColor
            // 
            this.pictureBoxStartColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxStartColor.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxStartColor.Name = "pictureBoxStartColor";
            this.pictureBoxStartColor.Size = new System.Drawing.Size(65, 23);
            this.pictureBoxStartColor.TabIndex = 2;
            this.pictureBoxStartColor.TabStop = false;
            // 
            // pictureBoxEndColor
            // 
            this.pictureBoxEndColor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxEndColor.Location = new System.Drawing.Point(74, 3);
            this.pictureBoxEndColor.Name = "pictureBoxEndColor";
            this.pictureBoxEndColor.Size = new System.Drawing.Size(66, 23);
            this.pictureBoxEndColor.TabIndex = 3;
            this.pictureBoxEndColor.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonZoom1x, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonZoom2x, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonZoom3x, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonZoom5x, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(143, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonZoom1x
            // 
            this.buttonZoom1x.Location = new System.Drawing.Point(3, 3);
            this.buttonZoom1x.Name = "buttonZoom1x";
            this.buttonZoom1x.Size = new System.Drawing.Size(65, 21);
            this.buttonZoom1x.TabIndex = 0;
            this.buttonZoom1x.Text = "Zoom1x";
            this.buttonZoom1x.UseVisualStyleBackColor = true;
            this.buttonZoom1x.Click += new System.EventHandler(this.buttonZoom1x_Click);
            // 
            // buttonZoom2x
            // 
            this.buttonZoom2x.Location = new System.Drawing.Point(74, 3);
            this.buttonZoom2x.Name = "buttonZoom2x";
            this.buttonZoom2x.Size = new System.Drawing.Size(66, 21);
            this.buttonZoom2x.TabIndex = 1;
            this.buttonZoom2x.Text = "Zoom2x";
            this.buttonZoom2x.UseVisualStyleBackColor = true;
            this.buttonZoom2x.Click += new System.EventHandler(this.buttonZoom2x_Click);
            // 
            // buttonZoom3x
            // 
            this.buttonZoom3x.Location = new System.Drawing.Point(3, 30);
            this.buttonZoom3x.Name = "buttonZoom3x";
            this.buttonZoom3x.Size = new System.Drawing.Size(65, 21);
            this.buttonZoom3x.TabIndex = 2;
            this.buttonZoom3x.Text = "Zoom3x";
            this.buttonZoom3x.UseVisualStyleBackColor = true;
            this.buttonZoom3x.Click += new System.EventHandler(this.buttonZoom3x_Click);
            // 
            // buttonZoom5x
            // 
            this.buttonZoom5x.Location = new System.Drawing.Point(74, 30);
            this.buttonZoom5x.Name = "buttonZoom5x";
            this.buttonZoom5x.Size = new System.Drawing.Size(66, 21);
            this.buttonZoom5x.TabIndex = 3;
            this.buttonZoom5x.Text = "Zoom5x";
            this.buttonZoom5x.UseVisualStyleBackColor = true;
            this.buttonZoom5x.Click += new System.EventHandler(this.buttonZoom5x_Click);
            // 
            // labelRecurHelp
            // 
            this.labelRecurHelp.AutoSize = true;
            this.labelRecurHelp.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecurHelp.Location = new System.Drawing.Point(6, 48);
            this.labelRecurHelp.Name = "labelRecurHelp";
            this.labelRecurHelp.Size = new System.Drawing.Size(137, 24);
            this.labelRecurHelp.TabIndex = 1;
            this.labelRecurHelp.Text = "Recursion depth.\r\nShould be not bigger than 20.";
            // 
            // textBoxRecDepth
            // 
            this.textBoxRecDepth.Location = new System.Drawing.Point(6, 22);
            this.textBoxRecDepth.Name = "textBoxRecDepth";
            this.textBoxRecDepth.Size = new System.Drawing.Size(141, 23);
            this.textBoxRecDepth.TabIndex = 0;
            // 
            // labelDistanceBetweenSegments
            // 
            this.labelDistanceBetweenSegments.AutoSize = true;
            this.labelDistanceBetweenSegments.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDistanceBetweenSegments.Location = new System.Drawing.Point(6, 298);
            this.labelDistanceBetweenSegments.Name = "labelDistanceBetweenSegments";
            this.labelDistanceBetweenSegments.Size = new System.Drawing.Size(133, 24);
            this.labelDistanceBetweenSegments.TabIndex = 14;
            this.labelDistanceBetweenSegments.Text = "Distance between segments\r\nEnter distance for every stage";
            this.labelDistanceBetweenSegments.Visible = false;
            // 
            // labelSegmentLengthKantorSet
            // 
            this.labelSegmentLengthKantorSet.AutoSize = true;
            this.labelSegmentLengthKantorSet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSegmentLengthKantorSet.Location = new System.Drawing.Point(6, 256);
            this.labelSegmentLengthKantorSet.Name = "labelSegmentLengthKantorSet";
            this.labelSegmentLengthKantorSet.Size = new System.Drawing.Size(91, 13);
            this.labelSegmentLengthKantorSet.TabIndex = 13;
            this.labelSegmentLengthKantorSet.Text = "Segment Length";
            this.labelSegmentLengthKantorSet.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxFractalDraw);
            this.panel1.Location = new System.Drawing.Point(267, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 415);
            this.panel1.TabIndex = 9;
            // 
            // pictureBoxFractalDraw
            // 
            this.pictureBoxFractalDraw.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFractalDraw.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFractalDraw.Name = "pictureBoxFractalDraw";
            this.pictureBoxFractalDraw.Size = new System.Drawing.Size(513, 415);
            this.pictureBoxFractalDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFractalDraw.TabIndex = 0;
            this.pictureBoxFractalDraw.TabStop = false;
            this.pictureBoxFractalDraw.Click += new System.EventHandler(this.pictureBoxFractalDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxControlElements);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxControlElements.ResumeLayout(false);
            this.groupBoxControlElements.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndColor)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractalDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonKochCurve;
        private System.Windows.Forms.Button buttonSierpinskiCarpet;
        private System.Windows.Forms.Button buttonSierpiskiTriangle;
        private System.Windows.Forms.Button buttonCantorSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonFractalTree;
       
        private System.Windows.Forms.TextBox textBoxRecDepth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonZoom1x;
        private System.Windows.Forms.Button buttonZoom2x;
        private System.Windows.Forms.Button buttonZoom3x;
        private System.Windows.Forms.Button buttonZoom5x;
        private System.Windows.Forms.Label labelRecurHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxFractalDraw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonStartColor;
        private System.Windows.Forms.Button buttonEndColor;
        private System.Windows.Forms.PictureBox pictureBoxStartColor;
        private System.Windows.Forms.PictureBox pictureBoxEndColor;
        
        private System.Windows.Forms.Button buttonSaveFractal;
        private System.Windows.Forms.TextBox textBoxSaveFileName;
        private System.Windows.Forms.GroupBox groupBoxControlElements;
        private System.Windows.Forms.ColorDialog colorDialogStartColor;
        
        private System.Windows.Forms.Label labelAngelOfFirstSegment;
        private System.Windows.Forms.Label labelSegmentRatio;
        private System.Windows.Forms.Label labelFIleSaveHelp;
        private System.Windows.Forms.Label labelAngelOfSecondSegment;
        private System.Windows.Forms.TextBox textBoxSegmentRatio;
        
        private System.Windows.Forms.TextBox textBoxAngleOfFirstSegment;
        private System.Windows.Forms.TextBox textBoxAngleOfSecondSegment;
        
        private System.Windows.Forms.Label labelSegmentLengthKantorSet;
        
        
        private System.Windows.Forms.Label labelDistanceBetweenSegments;
        private System.Windows.Forms.Label labelRecHelpCanterSet;
        private System.Windows.Forms.TextBox textBoxDistanceBetweenSegmentsCanterSet;
        private System.Windows.Forms.Label labelRecHelpSirpCarpet;
        private System.Windows.Forms.Label labelRecHelpSierpTr;
        private System.Windows.Forms.Label labelRecHelpKochCurve;
    }
}

