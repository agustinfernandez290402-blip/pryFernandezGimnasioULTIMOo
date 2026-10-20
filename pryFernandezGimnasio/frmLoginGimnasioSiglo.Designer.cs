namespace pryFernandezGimnasio
{
    partial class frmLoginGimnasioSiglo
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
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(174, 371);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(154, 29);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmLoginGimnasioSiglo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.siglogymm;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(498, 484);
            Controls.Add(btnIngresar);
            DoubleBuffered = true;
            Name = "frmLoginGimnasioSiglo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoginGimnasioSiglo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
    }
}