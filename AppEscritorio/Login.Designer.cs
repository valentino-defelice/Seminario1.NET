namespace AppEscritorio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.CrearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IngresarBtn.BackgroundImage")));
            this.IngresarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IngresarBtn.ForeColor = System.Drawing.Color.Black;
            this.IngresarBtn.Image = ((System.Drawing.Image)(resources.GetObject("IngresarBtn.Image")));
            this.IngresarBtn.Location = new System.Drawing.Point(74, 277);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(112, 37);
            this.IngresarBtn.TabIndex = 0;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.UseVisualStyleBackColor = true;
            this.IngresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // CrearBtn
            // 
            this.CrearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CrearBtn.BackgroundImage")));
            this.CrearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrearBtn.ForeColor = System.Drawing.Color.Black;
            this.CrearBtn.Image = ((System.Drawing.Image)(resources.GetObject("CrearBtn.Image")));
            this.CrearBtn.Location = new System.Drawing.Point(192, 277);
            this.CrearBtn.Name = "CrearBtn";
            this.CrearBtn.Size = new System.Drawing.Size(112, 37);
            this.CrearBtn.TabIndex = 1;
            this.CrearBtn.Text = "Crear Usuario";
            this.CrearBtn.UseVisualStyleBackColor = true;
            this.CrearBtn.Click += new System.EventHandler(this.CrearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(175, 132);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(118, 20);
            this.EmailTxtBox.TabIndex = 4;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(175, 164);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(118, 20);
            this.PasswordTxtBox.TabIndex = 5;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.resultado.Location = new System.Drawing.Point(72, 212);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 20);
            this.resultado.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 413);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CrearBtn);
            this.Controls.Add(this.IngresarBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Button CrearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label resultado;
    }
}