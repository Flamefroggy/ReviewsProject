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
            this.GamesBS = new System.Windows.Forms.BindingSource(this.components);
            this.BooksBS = new System.Windows.Forms.BindingSource(this.components);
            this.FilmsBS = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTableType = new System.Windows.Forms.ComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GamesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamesBS
            // 
            this.GamesBS.DataSource = typeof(ReviewsData.Model.Game);
            // 
            // BooksBS
            // 
            this.BooksBS.DataSource = typeof(ReviewsData.Model.Book);
            // 
            // FilmsBS
            // 
            this.FilmsBS.DataSource = typeof(ReviewsData.Model.Film);
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
            this.comboBoxTableType.Location = new System.Drawing.Point(10, 10);
            this.comboBoxTableType.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxTableType.Name = "comboBoxTableType";
            this.comboBoxTableType.Size = new System.Drawing.Size(380, 28);
            this.comboBoxTableType.TabIndex = 2;
            this.comboBoxTableType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableType_SelectedIndexChanged);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMain.ColumnHeadersHeight = 29;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ratingtitleDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.GamesBS;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(25, 65);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(25);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.Size = new System.Drawing.Size(350, 726);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
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
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.dgvMain, 0, 1);
            this.layoutMain.Controls.Add(this.comboBoxTableType, 0, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1667, 816);
            this.layoutMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 816);
            this.Controls.Add(this.layoutMain);
            this.Name = "MainForm";
            this.Text = "Браузер рецензий";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GamesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource GamesBS;
        private BindingSource BooksBS;
        private BindingSource FilmsBS;
        private ComboBox comboBoxTableType;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingtitleDataGridViewTextBoxColumn;
        private TableLayoutPanel layoutMain;
    }
}