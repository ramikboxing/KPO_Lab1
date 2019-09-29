using Kpo4381_nmv;

namespace KPO4381_nmv.Main
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.DataCars = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDataCars = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.DataCars});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(800, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(57, 20);
            this.mmFile.Text = "1.Файл";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(121, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(121, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // DataCars
            // 
            this.DataCars.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDataCars});
            this.DataCars.Name = "DataCars";
            this.DataCars.Size = new System.Drawing.Size(98, 20);
            this.DataCars.Text = "2.Автомобили";
            // 
            // OpenDataCars
            // 
            this.OpenDataCars.Name = "OpenDataCars";
            this.OpenDataCars.Size = new System.Drawing.Size(165, 22);
            this.OpenDataCars.Text = "Открыть данные";
            this.OpenDataCars.Click += new System.EventHandler(this.mnOpenCars_Click);
            // 
            // SStatus
            // 
            this.SStatus.Location = new System.Drawing.Point(0, 428);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(800, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvCarList
            // 
            this.dgvCarList.AutoGenerateColumns = false;
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markText,
            this.modelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvCarList.DataSource = this.carBindingSource;
            this.dgvCarList.Location = new System.Drawing.Point(29, 39);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.Size = new System.Drawing.Size(737, 251);
            this.dgvCarList.TabIndex = 2;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(Car);
            // 
            // markText
            // 
            this.markText.DataPropertyName = "Mark";
            this.markText.HeaderText = "Mark";
            this.markText.Name = "markText";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.ToolStripMenuItem DataCars;
        private System.Windows.Forms.ToolStripMenuItem OpenDataCars;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn markText;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

