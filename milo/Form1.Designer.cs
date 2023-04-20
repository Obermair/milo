namespace milo
{
    partial class MILO
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MILO));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.locationFinder = new System.Windows.Forms.TabPage();
            this.receiptSuggestion = new System.Windows.Forms.TabPage();
            this.blogWriter = new System.Windows.Forms.TabPage();
            this.imageCreator = new System.Windows.Forms.TabPage();
            this.filmRoulette = new System.Windows.Forms.TabPage();
            this.giftSuggestion = new System.Windows.Forms.TabPage();
            this.codeTranslator = new System.Windows.Forms.TabPage();
            this.chartPresentation = new System.Windows.Forms.TabPage();
            this.grammarCorrection = new System.Windows.Forms.TabPage();
            this.fileSummarizer = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.receiptSuggestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.locationFinder);
            this.materialTabControl1.Controls.Add(this.receiptSuggestion);
            this.materialTabControl1.Controls.Add(this.blogWriter);
            this.materialTabControl1.Controls.Add(this.imageCreator);
            this.materialTabControl1.Controls.Add(this.filmRoulette);
            this.materialTabControl1.Controls.Add(this.giftSuggestion);
            this.materialTabControl1.Controls.Add(this.codeTranslator);
            this.materialTabControl1.Controls.Add(this.chartPresentation);
            this.materialTabControl1.Controls.Add(this.grammarCorrection);
            this.materialTabControl1.Controls.Add(this.fileSummarizer);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 92);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1119, 654);
            this.materialTabControl1.TabIndex = 0;
            // 
            // locationFinder
            // 
            this.locationFinder.ImageKey = "map-pin.png";
            this.locationFinder.Location = new System.Drawing.Point(4, 60);
            this.locationFinder.Name = "locationFinder";
            this.locationFinder.Padding = new System.Windows.Forms.Padding(3);
            this.locationFinder.Size = new System.Drawing.Size(1111, 590);
            this.locationFinder.TabIndex = 1;
            this.locationFinder.Text = "Location Finder";
            this.locationFinder.UseVisualStyleBackColor = true;
            // 
            // receiptSuggestion
            // 
            this.receiptSuggestion.Controls.Add(this.label3);
            this.receiptSuggestion.Controls.Add(this.label2);
            this.receiptSuggestion.Controls.Add(this.label1);
            this.receiptSuggestion.ImageKey = "cake.png";
            this.receiptSuggestion.Location = new System.Drawing.Point(4, 60);
            this.receiptSuggestion.Name = "receiptSuggestion";
            this.receiptSuggestion.Size = new System.Drawing.Size(1111, 590);
            this.receiptSuggestion.TabIndex = 2;
            this.receiptSuggestion.Text = "Receipt Suggestion";
            this.receiptSuggestion.UseVisualStyleBackColor = true;
            this.receiptSuggestion.Click += new System.EventHandler(this.receiptSuggestion_Click);
            // 
            // blogWriter
            // 
            this.blogWriter.ImageKey = "newspaper.png";
            this.blogWriter.Location = new System.Drawing.Point(4, 32);
            this.blogWriter.Name = "blogWriter";
            this.blogWriter.Size = new System.Drawing.Size(1111, 618);
            this.blogWriter.TabIndex = 3;
            this.blogWriter.Text = "Blog Writer";
            this.blogWriter.UseVisualStyleBackColor = true;
            // 
            // imageCreator
            // 
            this.imageCreator.ImageKey = "photo.png";
            this.imageCreator.Location = new System.Drawing.Point(4, 32);
            this.imageCreator.Name = "imageCreator";
            this.imageCreator.Size = new System.Drawing.Size(1111, 618);
            this.imageCreator.TabIndex = 4;
            this.imageCreator.Text = "Image Creator";
            this.imageCreator.UseVisualStyleBackColor = true;
            // 
            // filmRoulette
            // 
            this.filmRoulette.ImageKey = "film.png";
            this.filmRoulette.Location = new System.Drawing.Point(4, 32);
            this.filmRoulette.Name = "filmRoulette";
            this.filmRoulette.Size = new System.Drawing.Size(1111, 618);
            this.filmRoulette.TabIndex = 5;
            this.filmRoulette.Text = "Film Roulette";
            this.filmRoulette.UseVisualStyleBackColor = true;
            // 
            // giftSuggestion
            // 
            this.giftSuggestion.ImageKey = "gift-top.png";
            this.giftSuggestion.Location = new System.Drawing.Point(4, 32);
            this.giftSuggestion.Name = "giftSuggestion";
            this.giftSuggestion.Size = new System.Drawing.Size(1111, 618);
            this.giftSuggestion.TabIndex = 6;
            this.giftSuggestion.Text = "Gift Suggestion";
            this.giftSuggestion.UseVisualStyleBackColor = true;
            // 
            // codeTranslator
            // 
            this.codeTranslator.ImageKey = "code.png";
            this.codeTranslator.Location = new System.Drawing.Point(4, 32);
            this.codeTranslator.Name = "codeTranslator";
            this.codeTranslator.Size = new System.Drawing.Size(1111, 618);
            this.codeTranslator.TabIndex = 7;
            this.codeTranslator.Text = "Code Translator";
            this.codeTranslator.UseVisualStyleBackColor = true;
            // 
            // chartPresentation
            // 
            this.chartPresentation.ImageKey = "presentation-chart-bar.png";
            this.chartPresentation.Location = new System.Drawing.Point(4, 60);
            this.chartPresentation.Name = "chartPresentation";
            this.chartPresentation.Size = new System.Drawing.Size(1111, 590);
            this.chartPresentation.TabIndex = 8;
            this.chartPresentation.Text = "Chart Presentation";
            this.chartPresentation.UseVisualStyleBackColor = true;
            // 
            // grammarCorrection
            // 
            this.grammarCorrection.ImageKey = "academic-cap.png";
            this.grammarCorrection.Location = new System.Drawing.Point(4, 60);
            this.grammarCorrection.Name = "grammarCorrection";
            this.grammarCorrection.Size = new System.Drawing.Size(1111, 590);
            this.grammarCorrection.TabIndex = 9;
            this.grammarCorrection.Text = "Grammar Correction";
            this.grammarCorrection.UseVisualStyleBackColor = true;
            // 
            // fileSummarizer
            // 
            this.fileSummarizer.ImageKey = "upload.png";
            this.fileSummarizer.Location = new System.Drawing.Point(4, 60);
            this.fileSummarizer.Name = "fileSummarizer";
            this.fileSummarizer.Padding = new System.Windows.Forms.Padding(3);
            this.fileSummarizer.Size = new System.Drawing.Size(1111, 590);
            this.fileSummarizer.TabIndex = 0;
            this.fileSummarizer.Text = "File Summarizer";
            this.fileSummarizer.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "academic-cap.png");
            this.imageList1.Images.SetKeyName(1, "bars-3-bottom-left.png");
            this.imageList1.Images.SetKeyName(2, "cake.png");
            this.imageList1.Images.SetKeyName(3, "code.png");
            this.imageList1.Images.SetKeyName(4, "code-bracket-square.png");
            this.imageList1.Images.SetKeyName(5, "document-arrow-down.png");
            this.imageList1.Images.SetKeyName(6, "film.png");
            this.imageList1.Images.SetKeyName(7, "gift-top.png");
            this.imageList1.Images.SetKeyName(8, "language.png");
            this.imageList1.Images.SetKeyName(9, "link.png");
            this.imageList1.Images.SetKeyName(10, "map-pin.png");
            this.imageList1.Images.SetKeyName(11, "megaphone.png");
            this.imageList1.Images.SetKeyName(12, "newspaper.png");
            this.imageList1.Images.SetKeyName(13, "photo.png");
            this.imageList1.Images.SetKeyName(14, "presentation-chart-bar.png");
            this.imageList1.Images.SetKeyName(15, "trash.png");
            this.imageList1.Images.SetKeyName(16, "upload.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt Suggestion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get Personalized Recipes Based on What\'s in Your Fridge";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.MaximumSize = new System.Drawing.Size(750, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(935, 130);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MILO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1125, 750);
            this.Controls.Add(this.materialTabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MILO";
            this.Padding = new System.Windows.Forms.Padding(3, 92, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MILO"; 
            this.materialTabControl1.ResumeLayout(false);
            this.receiptSuggestion.ResumeLayout(false);
            this.receiptSuggestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage locationFinder;
        private System.Windows.Forms.TabPage receiptSuggestion;
        private System.Windows.Forms.TabPage blogWriter;
        private System.Windows.Forms.TabPage imageCreator;
        private System.Windows.Forms.TabPage filmRoulette;
        private System.Windows.Forms.TabPage giftSuggestion;
        private System.Windows.Forms.TabPage codeTranslator;
        private System.Windows.Forms.TabPage chartPresentation;
        private System.Windows.Forms.TabPage grammarCorrection;
        private System.Windows.Forms.TabPage fileSummarizer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

