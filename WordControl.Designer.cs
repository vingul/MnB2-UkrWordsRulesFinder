
namespace UkrWordsRulesFinder
{
    partial class WordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordControl));
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusInfo = new System.Windows.Forms.Label();
            this.flowAddRules = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAddRules = new System.Windows.Forms.Label();
            this.lblMainRule = new System.Windows.Forms.Label();
            this.layoutMainRule = new System.Windows.Forms.FlowLayoutPanel();
            this.comboMainRule = new System.Windows.Forms.ComboBox();
            this.lblMainRuleHint = new System.Windows.Forms.Label();
            this.tabGenders = new System.Windows.Forms.TabControl();
            this.pageMasculine = new System.Windows.Forms.TabPage();
            this.listMusculine = new System.Windows.Forms.ListView();
            this.columnCaseM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWordM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRuleM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageFeminine = new System.Windows.Forms.TabPage();
            this.listFeminine = new System.Windows.Forms.ListView();
            this.columnCaseF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWordF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRuleF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageNeuter = new System.Windows.Forms.TabPage();
            this.listNeuter = new System.Windows.Forms.ListView();
            this.columnCaseN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWordN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRuleN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pagePlural = new System.Windows.Forms.TabPage();
            this.listPlural = new System.Windows.Forms.ListView();
            this.columnCaseP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWordP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRuleP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilStatus = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutMain.SuspendLayout();
            this.layoutMainRule.SuspendLayout();
            this.tabGenders.SuspendLayout();
            this.pageMasculine.SuspendLayout();
            this.pageFeminine.SuspendLayout();
            this.pageNeuter.SuspendLayout();
            this.pagePlural.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.lblStatus, 1, 0);
            this.tableLayoutMain.Controls.Add(this.lblStatusInfo, 2, 0);
            this.tableLayoutMain.Controls.Add(this.flowAddRules, 2, 2);
            this.tableLayoutMain.Controls.Add(this.lblAddRules, 0, 2);
            this.tableLayoutMain.Controls.Add(this.lblMainRule, 0, 1);
            this.tableLayoutMain.Controls.Add(this.layoutMainRule, 3, 1);
            this.tableLayoutMain.Controls.Add(this.tabGenders, 0, 3);
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 4;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(834, 455);
            this.tableLayoutMain.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(58, 3);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Статус:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusInfo
            // 
            this.lblStatusInfo.AutoSize = true;
            this.lblStatusInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatusInfo.Location = new System.Drawing.Point(113, 3);
            this.lblStatusInfo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblStatusInfo.Name = "lblStatusInfo";
            this.lblStatusInfo.Size = new System.Drawing.Size(72, 16);
            this.lblStatusInfo.TabIndex = 1;
            this.lblStatusInfo.Text = "Знайдено";
            this.lblStatusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowAddRules
            // 
            this.flowAddRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowAddRules.AutoSize = true;
            this.flowAddRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowAddRules.Location = new System.Drawing.Point(113, 43);
            this.flowAddRules.Margin = new System.Windows.Forms.Padding(0);
            this.flowAddRules.Name = "flowAddRules";
            this.flowAddRules.Size = new System.Drawing.Size(721, 0);
            this.flowAddRules.TabIndex = 2;
            this.flowAddRules.WrapContents = false;
            // 
            // lblAddRules
            // 
            this.lblAddRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddRules.AutoSize = true;
            this.tableLayoutMain.SetColumnSpan(this.lblAddRules, 2);
            this.lblAddRules.Location = new System.Drawing.Point(3, 43);
            this.lblAddRules.Name = "lblAddRules";
            this.lblAddRules.Size = new System.Drawing.Size(107, 13);
            this.lblAddRules.TabIndex = 3;
            this.lblAddRules.Text = "Додаткові правила:";
            this.lblAddRules.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMainRule
            // 
            this.lblMainRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainRule.AutoSize = true;
            this.tableLayoutMain.SetColumnSpan(this.lblMainRule, 2);
            this.lblMainRule.Location = new System.Drawing.Point(3, 26);
            this.lblMainRule.Name = "lblMainRule";
            this.lblMainRule.Size = new System.Drawing.Size(107, 13);
            this.lblMainRule.TabIndex = 2;
            this.lblMainRule.Text = "Основне правило:";
            this.lblMainRule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // layoutMainRule
            // 
            this.layoutMainRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutMainRule.AutoSize = true;
            this.layoutMainRule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutMainRule.Controls.Add(this.comboMainRule);
            this.layoutMainRule.Controls.Add(this.lblMainRuleHint);
            this.layoutMainRule.Location = new System.Drawing.Point(113, 22);
            this.layoutMainRule.Margin = new System.Windows.Forms.Padding(0);
            this.layoutMainRule.Name = "layoutMainRule";
            this.layoutMainRule.Size = new System.Drawing.Size(721, 21);
            this.layoutMainRule.TabIndex = 0;
            this.layoutMainRule.WrapContents = false;
            // 
            // comboMainRule
            // 
            this.comboMainRule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboMainRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMainRule.FormattingEnabled = true;
            this.comboMainRule.Location = new System.Drawing.Point(0, 0);
            this.comboMainRule.Margin = new System.Windows.Forms.Padding(0);
            this.comboMainRule.Name = "comboMainRule";
            this.comboMainRule.Size = new System.Drawing.Size(121, 21);
            this.comboMainRule.TabIndex = 0;
            this.comboMainRule.SelectedIndexChanged += new System.EventHandler(this.comboMainRule_SelectedIndexChanged);
            this.comboMainRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressChecker_KeyDown);
            // 
            // lblMainRuleHint
            // 
            this.lblMainRuleHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainRuleHint.AutoSize = true;
            this.lblMainRuleHint.Location = new System.Drawing.Point(124, 4);
            this.lblMainRuleHint.Name = "lblMainRuleHint";
            this.lblMainRuleHint.Size = new System.Drawing.Size(0, 13);
            this.lblMainRuleHint.TabIndex = 1;
            this.lblMainRuleHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabGenders
            // 
            this.tabGenders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGenders.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tableLayoutMain.SetColumnSpan(this.tabGenders, 3);
            this.tabGenders.Controls.Add(this.pageMasculine);
            this.tabGenders.Controls.Add(this.pageFeminine);
            this.tabGenders.Controls.Add(this.pageNeuter);
            this.tabGenders.Controls.Add(this.pagePlural);
            this.tabGenders.ImageList = this.ilStatus;
            this.tabGenders.Location = new System.Drawing.Point(3, 59);
            this.tabGenders.Name = "tabGenders";
            this.tabGenders.SelectedIndex = 0;
            this.tabGenders.Size = new System.Drawing.Size(828, 393);
            this.tabGenders.TabIndex = 6;
            this.tabGenders.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabGenders_Selected);
            // 
            // pageMasculine
            // 
            this.pageMasculine.Controls.Add(this.listMusculine);
            this.pageMasculine.Location = new System.Drawing.Point(4, 26);
            this.pageMasculine.Name = "pageMasculine";
            this.pageMasculine.Padding = new System.Windows.Forms.Padding(3);
            this.pageMasculine.Size = new System.Drawing.Size(820, 363);
            this.pageMasculine.TabIndex = 0;
            this.pageMasculine.Text = "Чоловічий рід (Ctrl+1)";
            this.pageMasculine.UseVisualStyleBackColor = true;
            // 
            // listMusculine
            // 
            this.listMusculine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMusculine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCaseM,
            this.columnQuestM,
            this.columnWordM,
            this.columnRuleM});
            this.listMusculine.HideSelection = false;
            this.listMusculine.Location = new System.Drawing.Point(0, 0);
            this.listMusculine.Name = "listMusculine";
            this.listMusculine.Size = new System.Drawing.Size(820, 364);
            this.listMusculine.TabIndex = 0;
            this.listMusculine.UseCompatibleStateImageBehavior = false;
            this.listMusculine.View = System.Windows.Forms.View.Details;
            this.listMusculine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressChecker_KeyDown);
            // 
            // columnCaseM
            // 
            this.columnCaseM.Text = "Відмінок";
            this.columnCaseM.Width = 100;
            // 
            // columnQuestM
            // 
            this.columnQuestM.Text = "Питання";
            this.columnQuestM.Width = 150;
            // 
            // columnWordM
            // 
            this.columnWordM.Text = "Слово";
            this.columnWordM.Width = 100;
            // 
            // columnRuleM
            // 
            this.columnRuleM.Text = "Правило";
            this.columnRuleM.Width = 100;
            // 
            // pageFeminine
            // 
            this.pageFeminine.Controls.Add(this.listFeminine);
            this.pageFeminine.Location = new System.Drawing.Point(4, 26);
            this.pageFeminine.Name = "pageFeminine";
            this.pageFeminine.Padding = new System.Windows.Forms.Padding(3);
            this.pageFeminine.Size = new System.Drawing.Size(820, 363);
            this.pageFeminine.TabIndex = 1;
            this.pageFeminine.Text = "Жіночий рід (Ctrl+2)";
            this.pageFeminine.UseVisualStyleBackColor = true;
            // 
            // listFeminine
            // 
            this.listFeminine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFeminine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCaseF,
            this.columnQuestF,
            this.columnWordF,
            this.columnRuleF});
            this.listFeminine.HideSelection = false;
            this.listFeminine.Location = new System.Drawing.Point(0, 0);
            this.listFeminine.Name = "listFeminine";
            this.listFeminine.Size = new System.Drawing.Size(820, 312);
            this.listFeminine.TabIndex = 1;
            this.listFeminine.UseCompatibleStateImageBehavior = false;
            this.listFeminine.View = System.Windows.Forms.View.Details;
            this.listFeminine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressChecker_KeyDown);
            // 
            // columnCaseF
            // 
            this.columnCaseF.Text = "Відмінок";
            this.columnCaseF.Width = 100;
            // 
            // columnQuestF
            // 
            this.columnQuestF.Text = "Питання";
            this.columnQuestF.Width = 150;
            // 
            // columnWordF
            // 
            this.columnWordF.Text = "Слово";
            this.columnWordF.Width = 100;
            // 
            // columnRuleF
            // 
            this.columnRuleF.Text = "Правило";
            this.columnRuleF.Width = 100;
            // 
            // pageNeuter
            // 
            this.pageNeuter.Controls.Add(this.listNeuter);
            this.pageNeuter.Location = new System.Drawing.Point(4, 26);
            this.pageNeuter.Name = "pageNeuter";
            this.pageNeuter.Padding = new System.Windows.Forms.Padding(3);
            this.pageNeuter.Size = new System.Drawing.Size(820, 363);
            this.pageNeuter.TabIndex = 2;
            this.pageNeuter.Text = "Середній рід (Ctrl+3)";
            this.pageNeuter.UseVisualStyleBackColor = true;
            // 
            // listNeuter
            // 
            this.listNeuter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listNeuter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCaseN,
            this.columnQuestN,
            this.columnWordN,
            this.columnRuleN});
            this.listNeuter.HideSelection = false;
            this.listNeuter.Location = new System.Drawing.Point(0, 0);
            this.listNeuter.Name = "listNeuter";
            this.listNeuter.Size = new System.Drawing.Size(820, 312);
            this.listNeuter.TabIndex = 1;
            this.listNeuter.UseCompatibleStateImageBehavior = false;
            this.listNeuter.View = System.Windows.Forms.View.Details;
            this.listNeuter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressChecker_KeyDown);
            // 
            // columnCaseN
            // 
            this.columnCaseN.Text = "Відмінок";
            this.columnCaseN.Width = 100;
            // 
            // columnQuestN
            // 
            this.columnQuestN.Text = "Питання";
            this.columnQuestN.Width = 150;
            // 
            // columnWordN
            // 
            this.columnWordN.Text = "Слово";
            this.columnWordN.Width = 100;
            // 
            // columnRuleN
            // 
            this.columnRuleN.Text = "Правило";
            this.columnRuleN.Width = 100;
            // 
            // pagePlural
            // 
            this.pagePlural.Controls.Add(this.listPlural);
            this.pagePlural.Location = new System.Drawing.Point(4, 26);
            this.pagePlural.Name = "pagePlural";
            this.pagePlural.Padding = new System.Windows.Forms.Padding(3);
            this.pagePlural.Size = new System.Drawing.Size(820, 363);
            this.pagePlural.TabIndex = 3;
            this.pagePlural.Text = "Множина (Ctrl+4)";
            this.pagePlural.UseVisualStyleBackColor = true;
            // 
            // listPlural
            // 
            this.listPlural.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPlural.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCaseP,
            this.columnQuestP,
            this.columnWordP,
            this.columnRuleP});
            this.listPlural.HideSelection = false;
            this.listPlural.Location = new System.Drawing.Point(0, 0);
            this.listPlural.Name = "listPlural";
            this.listPlural.Size = new System.Drawing.Size(820, 312);
            this.listPlural.TabIndex = 1;
            this.listPlural.UseCompatibleStateImageBehavior = false;
            this.listPlural.View = System.Windows.Forms.View.Details;
            this.listPlural.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressChecker_KeyDown);
            // 
            // columnCaseP
            // 
            this.columnCaseP.Text = "Відмінок";
            this.columnCaseP.Width = 100;
            // 
            // columnQuestP
            // 
            this.columnQuestP.Text = "Питання";
            this.columnQuestP.Width = 150;
            // 
            // columnWordP
            // 
            this.columnWordP.Text = "Слово";
            this.columnWordP.Width = 100;
            // 
            // columnRuleP
            // 
            this.columnRuleP.Text = "Правило";
            this.columnRuleP.Width = 100;
            // 
            // ilStatus
            // 
            this.ilStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStatus.ImageStream")));
            this.ilStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.ilStatus.Images.SetKeyName(0, "True.png");
            this.ilStatus.Images.SetKeyName(1, "False.png");
            // 
            // WordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "WordControl";
            this.Size = new System.Drawing.Size(834, 455);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.layoutMainRule.ResumeLayout(false);
            this.layoutMainRule.PerformLayout();
            this.tabGenders.ResumeLayout(false);
            this.pageMasculine.ResumeLayout(false);
            this.pageFeminine.ResumeLayout(false);
            this.pageNeuter.ResumeLayout(false);
            this.pagePlural.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.FlowLayoutPanel flowAddRules;
        private System.Windows.Forms.Label lblAddRules;
        private System.Windows.Forms.Label lblMainRule;
        private System.Windows.Forms.FlowLayoutPanel layoutMainRule;
        private System.Windows.Forms.ComboBox comboMainRule;
        private System.Windows.Forms.Label lblMainRuleHint;
        private System.Windows.Forms.TabControl tabGenders;
        private System.Windows.Forms.TabPage pageMasculine;
        private System.Windows.Forms.ListView listMusculine;
        private System.Windows.Forms.ColumnHeader columnCaseM;
        private System.Windows.Forms.ColumnHeader columnQuestM;
        private System.Windows.Forms.ColumnHeader columnWordM;
        private System.Windows.Forms.ColumnHeader columnRuleM;
        private System.Windows.Forms.TabPage pageFeminine;
        private System.Windows.Forms.ListView listFeminine;
        private System.Windows.Forms.ColumnHeader columnCaseF;
        private System.Windows.Forms.ColumnHeader columnQuestF;
        private System.Windows.Forms.ColumnHeader columnWordF;
        private System.Windows.Forms.ColumnHeader columnRuleF;
        private System.Windows.Forms.TabPage pageNeuter;
        private System.Windows.Forms.ListView listNeuter;
        private System.Windows.Forms.ColumnHeader columnCaseN;
        private System.Windows.Forms.ColumnHeader columnQuestN;
        private System.Windows.Forms.ColumnHeader columnWordN;
        private System.Windows.Forms.ColumnHeader columnRuleN;
        private System.Windows.Forms.TabPage pagePlural;
        private System.Windows.Forms.ListView listPlural;
        private System.Windows.Forms.ColumnHeader columnCaseP;
        private System.Windows.Forms.ColumnHeader columnQuestP;
        private System.Windows.Forms.ColumnHeader columnWordP;
        private System.Windows.Forms.ColumnHeader columnRuleP;
        private System.Windows.Forms.ImageList ilStatus;
    }
}
