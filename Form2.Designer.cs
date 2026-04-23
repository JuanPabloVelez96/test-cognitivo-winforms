namespace Juego
{
    using System;
    using System.ComponentModel.Design;
    using System.Drawing;
    using System.Windows.Forms;

   
    
partial class Form2 { 
       

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelColor = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTituloForm2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(103, 48);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(151, 107);
            this.panelColor.TabIndex = 0;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(11, 173);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Puntuación";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(10, 205);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(62, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Informacion";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(136, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Comenzar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // lblTituloForm2
            // 
            this.lblTituloForm2.AutoSize = true;
            this.lblTituloForm2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm2.Location = new System.Drawing.Point(112, 9);
            this.lblTituloForm2.Name = "lblTituloForm2";
            this.lblTituloForm2.Size = new System.Drawing.Size(131, 25);
            this.lblTituloForm2.TabIndex = 4;
            this.lblTituloForm2.Text = "Color : Rojo";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.lblTituloForm2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panelColor);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

}
        
        #endregion


       
        private Label lblScore;
        private Label lblInfo;
        private Label lblTituloForm2;
        public Button btnStart;
        public Panel panelColor;
    }  
}