namespace ReviewsProject.View.ButtonControls
{
    partial class MainButtonsPanel
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
            this.layoutCCD = new System.Windows.Forms.TableLayoutPanel();
            this.createButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.layoutCCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutCCD
            // 
            this.layoutCCD.ColumnCount = 4;
            this.layoutCCD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCCD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutCCD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutCCD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutCCD.Controls.Add(this.createButton, 1, 0);
            this.layoutCCD.Controls.Add(this.changeButton, 2, 0);
            this.layoutCCD.Controls.Add(this.deleteButton, 3, 0);
            this.layoutCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCCD.Location = new System.Drawing.Point(0, 0);
            this.layoutCCD.Name = "layoutCCD";
            this.layoutCCD.RowCount = 1;
            this.layoutCCD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCCD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutCCD.Size = new System.Drawing.Size(409, 57);
            this.layoutCCD.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(112, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 29);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(212, 3);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(94, 29);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(312, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 29);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtons_Click);
            // 
            // MainButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutCCD);
            this.Name = "MainButtons";
            this.Size = new System.Drawing.Size(409, 57);
            this.layoutCCD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layoutCCD;
        private Button createButton;
        private Button changeButton;
        private Button deleteButton;
    }
}
