namespace Clipart_Ovn_2_4
{
    partial class frmClipart
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
            this.gbxSkapa = new System.Windows.Forms.GroupBox();
            this.btnLinje = new System.Windows.Forms.Button();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTriangel = new System.Windows.Forms.Button();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.lblBredd = new System.Windows.Forms.Label();
            this.btnSummeraArea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxFigurer = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.gbxSkapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSkapa
            // 
            this.gbxSkapa.Controls.Add(this.btnLinje);
            this.gbxSkapa.Controls.Add(this.btnCirkel);
            this.gbxSkapa.Controls.Add(this.tbxHöjd);
            this.gbxSkapa.Controls.Add(this.label1);
            this.gbxSkapa.Controls.Add(this.btnTriangel);
            this.gbxSkapa.Controls.Add(this.tbxBredd);
            this.gbxSkapa.Controls.Add(this.lblBredd);
            this.gbxSkapa.Location = new System.Drawing.Point(15, 16);
            this.gbxSkapa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSkapa.Name = "gbxSkapa";
            this.gbxSkapa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSkapa.Size = new System.Drawing.Size(253, 314);
            this.gbxSkapa.TabIndex = 0;
            this.gbxSkapa.TabStop = false;
            this.gbxSkapa.Text = "Skapa";
            // 
            // btnLinje
            // 
            this.btnLinje.Location = new System.Drawing.Point(76, 259);
            this.btnLinje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLinje.Name = "btnLinje";
            this.btnLinje.Size = new System.Drawing.Size(162, 39);
            this.btnLinje.TabIndex = 5;
            this.btnLinje.Text = "Skapa Linje";
            this.btnLinje.UseVisualStyleBackColor = true;
            this.btnLinje.Click += new System.EventHandler(this.btnLinje_Click);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(76, 201);
            this.btnCirkel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(162, 39);
            this.btnCirkel.TabIndex = 4;
            this.btnCirkel.Text = "Skapa Cirkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click);
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(76, 94);
            this.tbxHöjd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(162, 26);
            this.tbxHöjd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Höjd";
            // 
            // btnTriangel
            // 
            this.btnTriangel.Location = new System.Drawing.Point(76, 141);
            this.btnTriangel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTriangel.Name = "btnTriangel";
            this.btnTriangel.Size = new System.Drawing.Size(162, 39);
            this.btnTriangel.TabIndex = 2;
            this.btnTriangel.Text = "Skapa triangel";
            this.btnTriangel.UseVisualStyleBackColor = true;
            this.btnTriangel.Click += new System.EventHandler(this.btnTriangel_Click);
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(76, 44);
            this.tbxBredd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(162, 26);
            this.tbxBredd.TabIndex = 1;
            // 
            // lblBredd
            // 
            this.lblBredd.AutoSize = true;
            this.lblBredd.Location = new System.Drawing.Point(7, 48);
            this.lblBredd.Name = "lblBredd";
            this.lblBredd.Size = new System.Drawing.Size(52, 20);
            this.lblBredd.TabIndex = 0;
            this.lblBredd.Text = "Bredd";
            // 
            // btnSummeraArea
            // 
            this.btnSummeraArea.Location = new System.Drawing.Point(91, 346);
            this.btnSummeraArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSummeraArea.Name = "btnSummeraArea";
            this.btnSummeraArea.Size = new System.Drawing.Size(162, 39);
            this.btnSummeraArea.TabIndex = 1;
            this.btnSummeraArea.Text = "Sammanlagd area";
            this.btnSummeraArea.UseVisualStyleBackColor = true;
            this.btnSummeraArea.Click += new System.EventHandler(this.btnSummeraArea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Figurlista";
            // 
            // lbxFigurer
            // 
            this.lbxFigurer.FormattingEnabled = true;
            this.lbxFigurer.ItemHeight = 20;
            this.lbxFigurer.Location = new System.Drawing.Point(276, 64);
            this.lbxFigurer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxFigurer.Name = "lbxFigurer";
            this.lbxFigurer.Size = new System.Drawing.Size(219, 264);
            this.lbxFigurer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sammanlagd area";
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(279, 358);
            this.tbxArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(216, 26);
            this.tbxArea.TabIndex = 5;
            // 
            // frmClipart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 406);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxFigurer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSummeraArea);
            this.Controls.Add(this.gbxSkapa);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClipart";
            this.Text = "Form1";
            this.gbxSkapa.ResumeLayout(false);
            this.gbxSkapa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSkapa;
        private System.Windows.Forms.Button btnLinje;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTriangel;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.Label lblBredd;
        private System.Windows.Forms.Button btnSummeraArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxFigurer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxArea;
    }
}

