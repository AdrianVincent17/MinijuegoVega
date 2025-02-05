namespace VegaJuego
{
    partial class PantallaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            button1 = new Button();
            checkSonido = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 10.1F, FontStyle.Bold);
            button1.ForeColor = Color.Orange;
            button1.Image = Properties.Resources.Boton;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(358, 445);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(307, 50);
            button1.TabIndex = 0;
            button1.Text = "Comienza la aventura";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            checkSonido.Location = new Point(540, 177);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(125, 23);
            checkSonido.TabIndex = 1;
            checkSonido.Text = "Sonido On/Off";
            checkSonido.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 42);
            label1.Name = "label1";
            label1.Size = new Size(286, 21);
            label1.TabIndex = 2;
            label1.Text = "Creado por Fernando Ureña Herrero ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureBox1.Location = new Point(510, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 83);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.LogoBueno;
            pictureBox2.Location = new Point(2, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 202);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            ClientSize = new Size(809, 580);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(checkSonido);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkSonido;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}