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
            components = new System.ComponentModel.Container();
            GamesBS = new BindingSource(components);
            dgvEntities = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingtitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            layoutMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)GamesBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            layoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // GamesBS
            // 
            GamesBS.DataSource = typeof(ReviewsData.Model.Game);
            // 
            // dgvEntities
            // 
            dgvEntities.AllowUserToAddRows = false;
            dgvEntities.AllowUserToDeleteRows = false;
            dgvEntities.AllowUserToResizeColumns = false;
            dgvEntities.AllowUserToResizeRows = false;
            dgvEntities.AutoGenerateColumns = false;
            dgvEntities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEntities.BackgroundColor = Color.White;
            dgvEntities.ColumnHeadersHeight = 29;
            dgvEntities.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, ratingtitleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dgvEntities.DataSource = GamesBS;
            dgvEntities.Dock = DockStyle.Fill;
            dgvEntities.Location = new Point(8, 8);
            dgvEntities.Margin = new Padding(8);
            dgvEntities.MultiSelect = false;
            dgvEntities.Name = "dgvEntities";
            dgvEntities.ReadOnly = true;
            dgvEntities.RowHeadersVisible = false;
            dgvEntities.RowHeadersWidth = 51;
            layoutMain.SetRowSpan(dgvEntities, 2);
            dgvEntities.RowTemplate.Height = 25;
            dgvEntities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntities.Size = new Size(334, 457);
            dgvEntities.TabIndex = 0;
            dgvEntities.SelectionChanged += dgvMain_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 84;
            // 
            // ratingtitleDataGridViewTextBoxColumn
            // 
            ratingtitleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ratingtitleDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingtitleDataGridViewTextBoxColumn.DividerWidth = 2;
            ratingtitleDataGridViewTextBoxColumn.FillWeight = 39.85912F;
            ratingtitleDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            ratingtitleDataGridViewTextBoxColumn.MaxInputLength = 2;
            ratingtitleDataGridViewTextBoxColumn.MinimumWidth = 50;
            ratingtitleDataGridViewTextBoxColumn.Name = "ratingtitleDataGridViewTextBoxColumn";
            ratingtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Visible = false;
            descriptionDataGridViewTextBoxColumn.Width = 92;
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(dgvEntities, 0, 0);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 2;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(787, 473);
            layoutMain.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 473);
            Controls.Add(layoutMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Браузер рецензий";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)GamesBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            layoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource GamesBS;
        private DataGridView dgvEntities;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private TableLayoutPanel layoutMain;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingtitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}