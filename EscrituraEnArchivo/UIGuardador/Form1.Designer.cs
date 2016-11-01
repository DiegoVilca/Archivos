namespace UIGuardador
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(79, 107);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(79, 166);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(233, 56);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(132, 147);
            this.lstListado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lstListado;
    }
}

