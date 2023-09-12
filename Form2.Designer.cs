namespace Tela_teste_login2
{
    partial class Form2
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
            this.listViewAtendente = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewAtendente
            // 
            this.listViewAtendente.HideSelection = false;
            this.listViewAtendente.Location = new System.Drawing.Point(85, 50);
            this.listViewAtendente.Name = "listViewAtendente";
            this.listViewAtendente.Size = new System.Drawing.Size(246, 166);
            this.listViewAtendente.TabIndex = 0;
            this.listViewAtendente.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewAtendente);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAtendente;
    }
}