namespace CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtBoxTwo = new System.Windows.Forms.TextBox();
            this.txtBoxOne = new System.Windows.Forms.TextBox();
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(337, 267);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(100, 23);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtBoxTwo
            // 
            this.txtBoxTwo.Location = new System.Drawing.Point(337, 205);
            this.txtBoxTwo.Name = "txtBoxTwo";
            this.txtBoxTwo.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTwo.TabIndex = 1;
            // 
            // txtBoxOne
            // 
            this.txtBoxOne.Location = new System.Drawing.Point(337, 160);
            this.txtBoxOne.Name = "txtBoxOne";
            this.txtBoxOne.Size = new System.Drawing.Size(100, 22);
            this.txtBoxOne.TabIndex = 2;
            this.txtBoxOne.TextChanged += new System.EventHandler(this.txtBoxOne_TextChanged);
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AccessibleName = "";
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Location = new System.Drawing.Point(229, 160);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(53, 17);
            this.lblNumberOne.TabIndex = 3;
            this.lblNumberOne.Text = "Valor 1";
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Location = new System.Drawing.Point(232, 205);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(53, 17);
            this.lblNumberTwo.TabIndex = 4;
            this.lblNumberTwo.Text = "Valor 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.lblNumberOne);
            this.Controls.Add(this.txtBoxOne);
            this.Controls.Add(this.txtBoxTwo);
            this.Controls.Add(this.btnSomar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtBoxTwo;
        private System.Windows.Forms.TextBox txtBoxOne;
        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.Label lblNumberTwo;
    }
}

