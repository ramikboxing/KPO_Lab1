namespace KPO4381_nmv.Main.source
{
    partial class FrmCar
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
            this.lbMark = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMark
            // 
            this.lbMark.AutoSize = true;
            this.lbMark.Location = new System.Drawing.Point(13, 26);
            this.lbMark.Name = "lbMark";
            this.lbMark.Size = new System.Drawing.Size(40, 13);
            this.lbMark.TabIndex = 0;
            this.lbMark.Text = "Марка";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(16, 74);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(46, 13);
            this.lbModel.TabIndex = 1;
            this.lbModel.Text = "Модель";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(19, 132);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Цена";
            // 
            // tbMark
            // 
            this.tbMark.Enabled = false;
            this.tbMark.Location = new System.Drawing.Point(138, 26);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(200, 20);
            this.tbMark.TabIndex = 3;
            // 
            // tbModel
            // 
            this.tbModel.Enabled = false;
            this.tbModel.Location = new System.Drawing.Point(138, 74);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(200, 20);
            this.tbModel.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Enabled = false;
            this.tbPrice.Location = new System.Drawing.Point(138, 124);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // FrmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 185);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbMark);
            this.Name = "FrmCar";
            this.Text = "FrmCar";
            this.Load += new System.EventHandler(this.FrmCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMark;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbPrice;
    }
}