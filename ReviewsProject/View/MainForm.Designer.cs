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
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesBS = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreateGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreateFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTableType = new System.Windows.Forms.ComboBox();
            this.BooksBS = new System.Windows.Forms.BindingSource(this.components);
            this.FilmsBS = new System.Windows.Forms.BindingSource(this.components);
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesBS)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsBS)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.dgvMain, 0, 2);
            this.layoutMain.Controls.Add(this.menuStrip, 0, 0);
            this.layoutMain.Controls.Add(this.comboBoxTableType, 0, 1);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 3;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(813, 791);
            this.layoutMain.TabIndex = 0;
            // 
            // dgvMain
            // 
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.layoutMain.SetColumnSpan(this.dgvMain, 2);
            this.dgvMain.DataSource = this.GamesBS;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 84);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.Size = new System.Drawing.Size(807, 703);
            this.dgvMain.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // GamesBS
            // 
            this.GamesBS.DataSource = typeof(ReviewsData.Model.Game);
            // 
            // menuStrip
            // 
            this.layoutMain.SetColumnSpan(this.menuStrip, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreate});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(813, 30);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemCreate
            // 
            this.menuItemCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreateGame,
            this.menuItemCreateBook,
            this.menuItemCreateFilm});
            this.menuItemCreate.Name = "menuItemCreate";
            this.menuItemCreate.Size = new System.Drawing.Size(78, 24);
            this.menuItemCreate.Text = "Создать";
            // 
            // menuItemCreateGame
            // 
            this.menuItemCreateGame.Name = "menuItemCreateGame";
            this.menuItemCreateGame.Size = new System.Drawing.Size(139, 26);
            this.menuItemCreateGame.Text = "Игру...";
            this.menuItemCreateGame.Click += new System.EventHandler(this.menuItemCreateGame_Click);
            // 
            // menuItemCreateBook
            // 
            this.menuItemCreateBook.Name = "menuItemCreateBook";
            this.menuItemCreateBook.Size = new System.Drawing.Size(139, 26);
            this.menuItemCreateBook.Text = "Книгу";
            this.menuItemCreateBook.Click += new System.EventHandler(this.menuItemCreateBook_Click);
            // 
            // menuItemCreateFilm
            // 
            this.menuItemCreateFilm.Name = "menuItemCreateFilm";
            this.menuItemCreateFilm.Size = new System.Drawing.Size(139, 26);
            this.menuItemCreateFilm.Text = "Фильм";
            this.menuItemCreateFilm.Click += new System.EventHandler(this.menuItemCreateFilm_Click);
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
            this.comboBoxTableType.Location = new System.Drawing.Point(3, 44);
            this.comboBoxTableType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTableType.Name = "comboBoxTableType";
            this.comboBoxTableType.Size = new System.Drawing.Size(223, 28);
            this.comboBoxTableType.TabIndex = 2;
            this.comboBoxTableType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableType_SelectedIndexChanged);
            // 
            // BooksBS
            // 
            this.BooksBS.DataSource = typeof(ReviewsData.Model.Book);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 791);
            this.Controls.Add(this.layoutMain);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Браузер рецензий";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesBS)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layoutMain;
        private DataGridView dgvMain;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuItemCreate;
        private ToolStripMenuItem menuItemCreateGame;
        private BindingSource GamesBS;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ComboBox comboBoxTableType;
        private ToolStripMenuItem menuItemCreateBook;
        private ToolStripMenuItem menuItemCreateFilm;
        private BindingSource BooksBS;
        private BindingSource FilmsBS;
    }
}