namespace WindowsFormsApp1
{
    partial class FormSalidas
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
            this.lsbResultados = new System.Windows.Forms.ListBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbResultados
            // 
            this.lsbResultados.FormattingEnabled = true;
            this.lsbResultados.Location = new System.Drawing.Point(61, 57);
            this.lsbResultados.Name = "lsbResultados";
            this.lsbResultados.Size = new System.Drawing.Size(151, 121);
            this.lsbResultados.TabIndex = 0;
            this.lsbResultados.Tag = "lsbResultados";
            this.lsbResultados.SelectedIndexChanged += new System.EventHandler(this.lsbResultados_SelectedIndexChanged);
            // 
            // button
            // 
            this.button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button.Location = new System.Drawing.Point(93, 239);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Salir";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // FormSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 342);
            this.Controls.Add(this.button);
            this.Controls.Add(this.lsbResultados);
            this.Name = "FormSalidas";
            this.Text = "FormSalidas";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lsbResultados;
        private System.Windows.Forms.Button button;
    }
}