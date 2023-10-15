namespace ReviewsProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EntitiesBS = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTableType = new System.Windows.Forms.ComboBox();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.EntitiesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).BeginInit();
            this.layoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntitiesBS
            // 
            this.EntitiesBS.DataSource = typeof(ReviewsData.Model.BaseEntity);
            // 
            // comboBoxTableType
            // 
            this.comboBoxTableType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableType.FormattingEnabled = true;
            this.comboBoxTableType.Items.AddRange(new object[] {
            "Игры",
            "Книги",
            "Фильмы"});
            this.comboBoxTableType.Location = new System.Drawing.Point(8, 8);
            this.comboBoxTableType.Margin = new System.Windows.Forms.Padding(8);
            this.comboBoxTableType.Name = "comboBoxTableType";
            this.comboBoxTableType.Size = new System.Drawing.Size(334, 23);
            this.comboBoxTableType.TabIndex = 2;
            this.comboBoxTableType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableType_SelectedIndexChanged);
            // 
            // dgvEntities
            // 
            this.dgvEntities.AllowUserToAddRows = false;
            this.dgvEntities.AllowUserToDeleteRows = false;
            this.dgvEntities.AllowUserToResizeColumns = false;
            this.dgvEntities.AllowUserToResizeRows = false;
            this.dgvEntities.AutoGenerateColumns = false;
            this.dgvEntities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvEntities.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntities.ColumnHeadersHeight = 29;
            this.dgvEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ratingtitleDataGridViewTextBoxColumn});
            this.dgvEntities.DataSource = this.EntitiesBS;
            this.dgvEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntities.Location = new System.Drawing.Point(8, 38);
            this.dgvEntities.Margin = new System.Windows.Forms.Padding(8);
            this.dgvEntities.MultiSelect = false;
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.ReadOnly = true;
            this.dgvEntities.RowHeadersVisible = false;
            this.dgvEntities.RowHeadersWidth = 51;
            this.dgvEntities.RowTemplate.Height = 25;
            this.dgvEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntities.Size = new System.Drawing.Size(334, 427);
            this.dgvEntities.TabIndex = 0;
            this.dgvEntities.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.DividerWidth = 2;
            this.titleDataGridViewTextBoxColumn.FillWeight = 109.214F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingtitleDataGridViewTextBoxColumn
            // 
            this.ratingtitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ratingtitleDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingtitleDataGridViewTextBoxColumn.DividerWidth = 2;
            this.ratingtitleDataGridViewTextBoxColumn.FillWeight = 39.85912F;
            this.ratingtitleDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.ratingtitleDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.ratingtitleDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.ratingtitleDataGridViewTextBoxColumn.Name = "ratingtitleDataGridViewTextBoxColumn";
            this.ratingtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.dgvEntities, 0, 1);
            this.layoutMain.Controls.Add(this.comboBoxTableType, 0, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(787, 473);
            this.layoutMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 473);
            this.Controls.Add(this.layoutMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Браузер рецензий";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntitiesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).EndInit();
            this.layoutMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource EntitiesBS;
        private ComboBox comboBoxTableType;
        private DataGridView dgvEntities;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingtitleDataGridViewTextBoxColumn;
        private TableLayoutPanel layoutMain;
    }
}