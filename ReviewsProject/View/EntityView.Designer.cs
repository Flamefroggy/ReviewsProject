namespace ReviewsProject.View
{
    partial class EntityView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.infoViewMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.EntityBS = new System.Windows.Forms.BindingSource(this.components);
            this.infoViewMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntityBS)).BeginInit();
            this.SuspendLayout();
            // 
            // infoViewMain
            // 
            this.infoViewMain.ColumnCount = 4;
            this.infoViewMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoViewMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoViewMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoViewMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.infoViewMain.Controls.Add(this.labelDescription, 1, 3);
            this.infoViewMain.Controls.Add(this.labelTitle, 1, 1);
            this.infoViewMain.Controls.Add(this.tbDescription, 1, 4);
            this.infoViewMain.Controls.Add(this.tbTitle, 1, 2);
            this.infoViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoViewMain.Location = new System.Drawing.Point(0, 0);
            this.infoViewMain.Name = "infoViewMain";
            this.infoViewMain.RowCount = 6;
            this.infoViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.infoViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.infoViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.infoViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoViewMain.Size = new System.Drawing.Size(1327, 513);
            this.infoViewMain.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.infoViewMain.SetColumnSpan(this.labelDescription, 2);
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Location = new System.Drawing.Point(23, 80);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(1280, 30);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Описание книги:";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.infoViewMain.SetColumnSpan(this.labelTitle, 2);
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(23, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1280, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название книги:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDescription
            // 
            this.infoViewMain.SetColumnSpan(this.tbDescription, 2);
            this.tbDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EntityBS, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Location = new System.Drawing.Point(23, 113);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(1280, 377);
            this.tbDescription.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.infoViewMain.SetColumnSpan(this.tbTitle, 2);
            this.tbTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EntityBS, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Location = new System.Drawing.Point(23, 53);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(1280, 23);
            this.tbTitle.TabIndex = 1;
            // 
            // EntityBS
            // 
            this.EntityBS.DataSource = typeof(ReviewsData.Model.BaseEntity);
            // 
            // InfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoViewMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoView";
            this.Size = new System.Drawing.Size(1327, 513);
            this.infoViewMain.ResumeLayout(false);
            this.infoViewMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntityBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel infoViewMain;
        private Label labelDescription;
        private Label labelTitle;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private BindingSource EntityBS;
    }
}
