
namespace UkrWordsRulesFinder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblWords = new System.Windows.Forms.Label();
            this.textWords = new System.Windows.Forms.TextBox();
            this.btnWords = new System.Windows.Forms.Button();
            this.tableLayoutForm = new System.Windows.Forms.TableLayoutPanel();
            this.tabWords = new System.Windows.Forms.TabControl();
            this.ilStatus = new System.Windows.Forms.ImageList(this.components);
            this.textWordsProcessed = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tableLayoutForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWords
            // 
            this.lblWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(3, 9);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(72, 16);
            this.lblWords.TabIndex = 0;
            this.lblWords.Text = "Слова:";
            // 
            // textWords
            // 
            this.textWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textWords.Location = new System.Drawing.Point(81, 5);
            this.textWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textWords.Name = "textWords";
            this.textWords.Size = new System.Drawing.Size(658, 23);
            this.textWords.TabIndex = 1;
            this.textWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textWords_KeyDown);
            // 
            // btnWords
            // 
            this.btnWords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWords.AutoSize = true;
            this.btnWords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWords.Location = new System.Drawing.Point(746, 4);
            this.btnWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(157, 26);
            this.btnWords.TabIndex = 2;
            this.btnWords.Text = "Обробити слова (Enter)";
            this.btnWords.UseVisualStyleBackColor = true;
            this.btnWords.Click += new System.EventHandler(this.btnWords_Click);
            this.btnWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeyChecker);
            // 
            // tableLayoutForm
            // 
            this.tableLayoutForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutForm.ColumnCount = 3;
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutForm.Controls.Add(this.lblWords, 0, 0);
            this.tableLayoutForm.Controls.Add(this.btnWords, 2, 0);
            this.tableLayoutForm.Controls.Add(this.textWords, 1, 0);
            this.tableLayoutForm.Controls.Add(this.tabWords, 0, 1);
            this.tableLayoutForm.Controls.Add(this.textWordsProcessed, 1, 2);
            this.tableLayoutForm.Controls.Add(this.lblResult, 0, 2);
            this.tableLayoutForm.Controls.Add(this.btnCopy, 2, 2);
            this.tableLayoutForm.Location = new System.Drawing.Point(14, 15);
            this.tableLayoutForm.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutForm.Name = "tableLayoutForm";
            this.tableLayoutForm.RowCount = 3;
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutForm.Size = new System.Drawing.Size(907, 524);
            this.tableLayoutForm.TabIndex = 3;
            // 
            // tabWords
            // 
            this.tabWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabWords.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tableLayoutForm.SetColumnSpan(this.tabWords, 3);
            this.tabWords.ImageList = this.ilStatus;
            this.tabWords.Location = new System.Drawing.Point(3, 38);
            this.tabWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabWords.Multiline = true;
            this.tabWords.Name = "tabWords";
            this.tabWords.SelectedIndex = 0;
            this.tabWords.Size = new System.Drawing.Size(901, 450);
            this.tabWords.TabIndex = 3;
            this.tabWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeyChecker);
            // 
            // ilStatus
            // 
            this.ilStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStatus.ImageStream")));
            this.ilStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.ilStatus.Images.SetKeyName(0, "True.png");
            this.ilStatus.Images.SetKeyName(1, "False.png");
            // 
            // textWordsProcessed
            // 
            this.textWordsProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textWordsProcessed.Location = new System.Drawing.Point(81, 496);
            this.textWordsProcessed.Name = "textWordsProcessed";
            this.textWordsProcessed.Size = new System.Drawing.Size(658, 23);
            this.textWordsProcessed.TabIndex = 4;
            this.textWordsProcessed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeyChecker);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(3, 500);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Результат:";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.AutoSize = true;
            this.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopy.Location = new System.Drawing.Point(745, 495);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(159, 26);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Скопіювати (Ctrl+Alt+C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeyChecker);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 554);
            this.Controls.Add(this.tableLayoutForm);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Додати теги до слів";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tableLayoutForm.ResumeLayout(false);
            this.tableLayoutForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.TextBox textWords;
        private System.Windows.Forms.Button btnWords;
        private System.Windows.Forms.TableLayoutPanel tableLayoutForm;
        private System.Windows.Forms.TabControl tabWords;
        private System.Windows.Forms.ImageList ilStatus;
        private System.Windows.Forms.TextBox textWordsProcessed;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCopy;
    }
}

