﻿namespace ReviewsProject.View
{
    partial class CreateBook
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
            this.components = new System.ComponentModel.Container();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNPages = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.tbNpages = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 4;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.layoutMain.Controls.Add(this.labelDescription, 1, 3);
            this.layoutMain.Controls.Add(this.labelTitle, 1, 1);
            this.layoutMain.Controls.Add(this.tbDescription, 1, 4);
            this.layoutMain.Controls.Add(this.tbTitle, 1, 2);
            this.layoutMain.Controls.Add(this.buttonCreate, 1, 8);
            this.layoutMain.Controls.Add(this.buttonCancel, 2, 8);
            this.layoutMain.Controls.Add(this.labelNPages, 1, 5);
            this.layoutMain.Controls.Add(this.labelRating, 2, 5);
            this.layoutMain.Controls.Add(this.tbNpages, 1, 6);
            this.layoutMain.Controls.Add(this.tbRating, 2, 6);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 9;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.layoutMain.Size = new System.Drawing.Size(391, 424);
            this.layoutMain.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.layoutMain.SetColumnSpan(this.labelDescription, 2);
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Location = new System.Drawing.Point(26, 107);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(338, 40);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Описание книги:";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.layoutMain.SetColumnSpan(this.labelTitle, 2);
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(26, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(338, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название книги:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDescription
            // 
            this.layoutMain.SetColumnSpan(this.tbDescription, 2);
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Location = new System.Drawing.Point(26, 151);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(338, 121);
            this.tbDescription.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.layoutMain.SetColumnSpan(this.tbTitle, 2);
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Location = new System.Drawing.Point(26, 71);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(338, 27);
            this.tbTitle.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreate.Location = new System.Drawing.Point(26, 375);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(166, 45);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreateBook_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(198, 375);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(166, 45);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNPages
            // 
            this.labelNPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNPages.AutoSize = true;
            this.labelNPages.Location = new System.Drawing.Point(26, 296);
            this.labelNPages.Name = "labelNPages";
            this.labelNPages.Size = new System.Drawing.Size(166, 20);
            this.labelNPages.TabIndex = 5;
            this.labelNPages.Text = "Кол-во страниц:";
            // 
            // labelRating
            // 
            this.labelRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(198, 296);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(166, 20);
            this.labelRating.TabIndex = 6;
            this.labelRating.Text = "Рейтинг:";
            // 
            // tbNpages
            // 
            this.tbNpages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNpages.Location = new System.Drawing.Point(26, 319);
            this.tbNpages.Name = "tbNpages";
            this.tbNpages.Size = new System.Drawing.Size(166, 27);
            this.tbNpages.TabIndex = 7;
            // 
            // tbRating
            // 
            this.tbRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRating.Location = new System.Drawing.Point(198, 319);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(166, 27);
            this.tbRating.TabIndex = 8;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(ReviewsData.Model.Book);
            // 
            // CreateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 424);
            this.Controls.Add(this.layoutMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление книги";
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layoutMain;
        private Label labelTitle;
        private Label labelDescription;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private Button buttonCreate;
        private Button buttonCancel;
        private Label labelNPages;
        private Label labelRating;
        private TextBox tbNpages;
        private TextBox tbRating;
        private BindingSource bookBindingSource;
    }
}