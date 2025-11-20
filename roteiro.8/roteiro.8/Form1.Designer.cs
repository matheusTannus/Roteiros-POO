namespace roteiro._8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            panel1 = new Panel();
            Computador = new Label();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.WindowText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(604, 74);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(Computador);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 122);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseMove += panel1_MouseDown;
            // 
            // Computador
            // 
            Computador.AutoSize = true;
            Computador.Font = new Font("Snap ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Computador.ForeColor = SystemColors.WindowText;
            Computador.Location = new Point(12, 39);
            Computador.Name = "Computador";
            Computador.Size = new Size(241, 42);
            Computador.TabIndex = 1;
            Computador.Text = "Computador";
            Computador.Click += Computador_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 328);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(36, 144);
            button7.Name = "button7";
            button7.Size = new Size(136, 28);
            button7.TabIndex = 3;
            button7.Text = "Cabos";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightPink;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(36, 107);
            button6.Name = "button6";
            button6.Size = new Size(135, 31);
            button6.TabIndex = 2;
            button6.Text = "Perifericos";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 192);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(36, 70);
            button4.Name = "button4";
            button4.Size = new Size(136, 31);
            button4.TabIndex = 1;
            button4.Text = "Telas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PapayaWhip;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(36, 30);
            button2.Name = "button2";
            button2.Size = new Size(136, 34);
            button2.TabIndex = 0;
            button2.Text = "Componentes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ControlText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(578, 396);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 3;
            button3.Text = "Maximizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(604, 367);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "Voltar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label Computador;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button7;
    }
}
