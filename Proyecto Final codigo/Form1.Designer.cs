namespace ProyectoFinal1
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
            txtPrompt = new TextBox();
            btnBusqueda = new Button();
            txtResultado = new RichTextBox();
            lblResultado = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(209, 32);
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(191, 23);
            txtPrompt.TabIndex = 0;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(272, 61);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(75, 23);
            btnBusqueda.TabIndex = 1;
            btnBusqueda.Text = "Busqueda";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(40, 140);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(590, 214);
            txtResultado.TabIndex = 2;
            txtResultado.Text = "";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(40, 116);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 21);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(btnBusqueda);
            Controls.Add(txtPrompt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrompt;
        private Button btnBusqueda;
        private RichTextBox txtResultado;
        private Label lblResultado;
        private PictureBox pictureBox1;
    }
}
