namespace ReviewsProject.View
{
    partial class GameView
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
            components = new System.ComponentModel.Container();
            infoViewMain = new TableLayoutPanel();
            labelDescription = new Label();
            labelName = new Label();
            tbDescription = new TextBox();
            GameBS = new BindingSource(components);
            tbName = new TextBox();
            infoViewMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameBS).BeginInit();
            SuspendLayout();
            // 
            // infoViewMain
            // 
            infoViewMain.ColumnCount = 2;
            infoViewMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoViewMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoViewMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            infoViewMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            infoViewMain.Controls.Add(labelDescription, 0, 2);
            infoViewMain.Controls.Add(labelName, 0, 0);
            infoViewMain.Controls.Add(tbDescription, 0, 3);
            infoViewMain.Controls.Add(tbName, 0, 1);
            infoViewMain.Dock = DockStyle.Fill;
            infoViewMain.Location = new Point(0, 0);
            infoViewMain.Name = "infoViewMain";
            infoViewMain.RowCount = 4;
            infoViewMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            infoViewMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            infoViewMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            infoViewMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            infoViewMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoViewMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoViewMain.Size = new Size(542, 306);
            infoViewMain.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            infoViewMain.SetColumnSpan(labelDescription, 2);
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Location = new Point(3, 60);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(536, 30);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Описание:";
            labelDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            infoViewMain.SetColumnSpan(labelName, 2);
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(536, 30);
            labelName.TabIndex = 0;
            labelName.Text = "Название:";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbDescription
            // 
            infoViewMain.SetColumnSpan(tbDescription, 2);
            tbDescription.DataBindings.Add(new Binding("Text", GameBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Location = new Point(3, 93);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(536, 210);
            tbDescription.TabIndex = 2;
            // 
            // GameBS
            // 
            GameBS.DataSource = typeof(ReviewsData.Model.Game);
            // 
            // tbName
            // 
            infoViewMain.SetColumnSpan(tbName, 2);
            tbName.DataBindings.Add(new Binding("Text", GameBS, "Name", true));
            tbName.Dock = DockStyle.Fill;
            tbName.Location = new Point(3, 33);
            tbName.Name = "tbName";
            tbName.Size = new Size(536, 23);
            tbName.TabIndex = 1;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(infoViewMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameView";
            Size = new Size(542, 306);
            Load += GameView_Load;
            infoViewMain.ResumeLayout(false);
            infoViewMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GameBS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel infoViewMain;
        private Label labelDescription;
        private Label labelName;
        private TextBox tbDescription;
        private TextBox tbName;
        private BindingSource GameBS;
    }
}
