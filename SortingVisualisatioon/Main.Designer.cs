namespace SortingVisualisatioon
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pickMethodBox = new System.Windows.Forms.ComboBox();
            this.buttonToGenerateNumbers = new System.Windows.Forms.Button();
            this.buttonToSortNumbers = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.lowerLimitBox = new System.Windows.Forms.TextBox();
            this.higherLimitBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.lowerLimitLabel = new System.Windows.Forms.Label();
            this.higherLimitLabel = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.sortingSpeedLabel = new System.Windows.Forms.Label();
            this.sortingSpeedBox = new System.Windows.Forms.TextBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.generationBorderLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.manualInputButton = new System.Windows.Forms.Button();
            this.instantSortCheck = new System.Windows.Forms.CheckBox();
            this.swapCounter = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.compCounter = new System.Windows.Forms.Label();
            this.swapLabel = new System.Windows.Forms.Label();
            this.comparisonLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numbersBox = new System.Windows.Forms.TextBox();
            this.panelDisplaySorting = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pickMethodBox
            // 
            this.pickMethodBox.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.pickMethodBox.AllowDrop = true;
            this.pickMethodBox.CausesValidation = false;
            this.pickMethodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickMethodBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickMethodBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pickMethodBox.Items.AddRange(new object[] {
            "Класичне сортування Шелла",
            "Послідовність Седжвіка",
            "Послідовність Фібоначі",
            "Послідовність Токуда"});
            this.pickMethodBox.Location = new System.Drawing.Point(635, 42);
            this.pickMethodBox.Margin = new System.Windows.Forms.Padding(4);
            this.pickMethodBox.Name = "pickMethodBox";
            this.pickMethodBox.Size = new System.Drawing.Size(287, 33);
            this.pickMethodBox.TabIndex = 3;
            this.pickMethodBox.SelectedIndexChanged += new System.EventHandler(this.pickMethodBox_SelectedIndexChanged);
            // 
            // buttonToGenerateNumbers
            // 
            this.buttonToGenerateNumbers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonToGenerateNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToGenerateNumbers.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonToGenerateNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.buttonToGenerateNumbers.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonToGenerateNumbers.Location = new System.Drawing.Point(348, 207);
            this.buttonToGenerateNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToGenerateNumbers.Name = "buttonToGenerateNumbers";
            this.buttonToGenerateNumbers.Size = new System.Drawing.Size(249, 67);
            this.buttonToGenerateNumbers.TabIndex = 0;
            this.buttonToGenerateNumbers.Text = "Згенерувати";
            this.buttonToGenerateNumbers.UseVisualStyleBackColor = false;
            this.buttonToGenerateNumbers.Click += new System.EventHandler(this.buttonToGenerateNumbers_Click);
            // 
            // buttonToSortNumbers
            // 
            this.buttonToSortNumbers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonToSortNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToSortNumbers.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonToSortNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.buttonToSortNumbers.Location = new System.Drawing.Point(635, 210);
            this.buttonToSortNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToSortNumbers.Name = "buttonToSortNumbers";
            this.buttonToSortNumbers.Size = new System.Drawing.Size(132, 65);
            this.buttonToSortNumbers.TabIndex = 1;
            this.buttonToSortNumbers.Text = "Сортувати";
            this.buttonToSortNumbers.UseVisualStyleBackColor = false;
            this.buttonToSortNumbers.Click += new System.EventHandler(this.buttonToSortNumbers_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quantityBox.Location = new System.Drawing.Point(348, 45);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(249, 30);
            this.quantityBox.TabIndex = 5;
            // 
            // lowerLimitBox
            // 
            this.lowerLimitBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lowerLimitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerLimitBox.Location = new System.Drawing.Point(428, 113);
            this.lowerLimitBox.Margin = new System.Windows.Forms.Padding(4);
            this.lowerLimitBox.Name = "lowerLimitBox";
            this.lowerLimitBox.Size = new System.Drawing.Size(169, 30);
            this.lowerLimitBox.TabIndex = 7;
            // 
            // higherLimitBox
            // 
            this.higherLimitBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.higherLimitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.higherLimitBox.Location = new System.Drawing.Point(428, 155);
            this.higherLimitBox.Margin = new System.Windows.Forms.Padding(4);
            this.higherLimitBox.Name = "higherLimitBox";
            this.higherLimitBox.Size = new System.Drawing.Size(169, 30);
            this.higherLimitBox.TabIndex = 8;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.quantityLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quantityLabel.Location = new System.Drawing.Point(376, 13);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(221, 25);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Кількість елементів";
            // 
            // lowerLimitLabel
            // 
            this.lowerLimitLabel.AutoSize = true;
            this.lowerLimitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.lowerLimitLabel.ForeColor = System.Drawing.Color.White;
            this.lowerLimitLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lowerLimitLabel.Location = new System.Drawing.Point(375, 111);
            this.lowerLimitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(45, 25);
            this.lowerLimitLabel.TabIndex = 10;
            this.lowerLimitLabel.Text = "Від";
            // 
            // higherLimitLabel
            // 
            this.higherLimitLabel.AutoSize = true;
            this.higherLimitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.higherLimitLabel.ForeColor = System.Drawing.Color.White;
            this.higherLimitLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.higherLimitLabel.Location = new System.Drawing.Point(375, 158);
            this.higherLimitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.higherLimitLabel.Name = "higherLimitLabel";
            this.higherLimitLabel.Size = new System.Drawing.Size(34, 25);
            this.higherLimitLabel.TabIndex = 11;
            this.higherLimitLabel.Text = "До";
            // 
            // errorBox
            // 
            this.errorBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorBox.BackColor = System.Drawing.Color.Transparent;
            this.errorBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.errorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
            this.errorBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorBox.Location = new System.Drawing.Point(13, 17);
            this.errorBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(327, 147);
            this.errorBox.TabIndex = 12;
            this.errorBox.Text = "ErrorBox";
            this.errorBox.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1358, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(42, 37);
            this.closeButton.TabIndex = 13;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sortingSpeedLabel
            // 
            this.sortingSpeedLabel.AutoSize = true;
            this.sortingSpeedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.sortingSpeedLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sortingSpeedLabel.Location = new System.Drawing.Point(630, 102);
            this.sortingSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortingSpeedLabel.Name = "sortingSpeedLabel";
            this.sortingSpeedLabel.Size = new System.Drawing.Size(232, 25);
            this.sortingSpeedLabel.TabIndex = 14;
            this.sortingSpeedLabel.Text = "Швидкість сортування";
            // 
            // sortingSpeedBox
            // 
            this.sortingSpeedBox.Location = new System.Drawing.Point(635, 131);
            this.sortingSpeedBox.Margin = new System.Windows.Forms.Padding(4);
            this.sortingSpeedBox.Name = "sortingSpeedBox";
            this.sortingSpeedBox.Size = new System.Drawing.Size(249, 30);
            this.sortingSpeedBox.TabIndex = 15;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1316, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(42, 37);
            this.minimizeButton.TabIndex = 16;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // generationBorderLabel
            // 
            this.generationBorderLabel.AutoSize = true;
            this.generationBorderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.generationBorderLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generationBorderLabel.Location = new System.Drawing.Point(431, 84);
            this.generationBorderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generationBorderLabel.Name = "generationBorderLabel";
            this.generationBorderLabel.Size = new System.Drawing.Size(166, 25);
            this.generationBorderLabel.TabIndex = 17;
            this.generationBorderLabel.Text = "Межі генерації";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.BackColor = System.Drawing.Color.Transparent;
            this.methodLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.methodLabel.Location = new System.Drawing.Point(630, 13);
            this.methodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(188, 25);
            this.methodLabel.TabIndex = 18;
            this.methodLabel.Text = "Метод сортування";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.saveResultButton);
            this.panel1.Controls.Add(this.manualInputButton);
            this.panel1.Controls.Add(this.instantSortCheck);
            this.panel1.Controls.Add(this.buttonToSortNumbers);
            this.panel1.Controls.Add(this.swapCounter);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.compCounter);
            this.panel1.Controls.Add(this.swapLabel);
            this.panel1.Controls.Add(this.comparisonLabel);
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.lowerLimitBox);
            this.panel1.Controls.Add(this.methodLabel);
            this.panel1.Controls.Add(this.generationBorderLabel);
            this.panel1.Controls.Add(this.sortingSpeedBox);
            this.panel1.Controls.Add(this.higherLimitLabel);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.lowerLimitLabel);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.errorBox);
            this.panel1.Controls.Add(this.higherLimitBox);
            this.panel1.Controls.Add(this.sortingSpeedLabel);
            this.panel1.Controls.Add(this.quantityBox);
            this.panel1.Controls.Add(this.buttonToGenerateNumbers);
            this.panel1.Controls.Add(this.pickMethodBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 301);
            this.panel1.TabIndex = 19;
            // 
            // saveResultButton
            // 
            this.saveResultButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveResultButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveResultButton.FlatAppearance.BorderSize = 0;
            this.saveResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveResultButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.saveResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.saveResultButton.Location = new System.Drawing.Point(775, 210);
            this.saveResultButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(126, 64);
            this.saveResultButton.TabIndex = 25;
            this.saveResultButton.Text = "Зберегти";
            this.saveResultButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveResultButton.UseVisualStyleBackColor = false;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // manualInputButton
            // 
            this.manualInputButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualInputButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manualInputButton.FlatAppearance.BorderSize = 0;
            this.manualInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualInputButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.manualInputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.manualInputButton.Location = new System.Drawing.Point(13, 168);
            this.manualInputButton.Margin = new System.Windows.Forms.Padding(4);
            this.manualInputButton.Name = "manualInputButton";
            this.manualInputButton.Size = new System.Drawing.Size(237, 35);
            this.manualInputButton.TabIndex = 24;
            this.manualInputButton.Text = "Задати масив вручну";
            this.manualInputButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manualInputButton.UseVisualStyleBackColor = false;
            this.manualInputButton.Click += new System.EventHandler(this.manualInputButton_Click);
            // 
            // instantSortCheck
            // 
            this.instantSortCheck.AutoSize = true;
            this.instantSortCheck.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.instantSortCheck.Location = new System.Drawing.Point(635, 168);
            this.instantSortCheck.Name = "instantSortCheck";
            this.instantSortCheck.Size = new System.Drawing.Size(229, 29);
            this.instantSortCheck.TabIndex = 23;
            this.instantSortCheck.Text = "Миттєве сортування";
            this.instantSortCheck.UseVisualStyleBackColor = true;
            this.instantSortCheck.CheckedChanged += new System.EventHandler(this.instantSortCheck_CheckedChanged);
            // 
            // swapCounter
            // 
            this.swapCounter.AutoSize = true;
            this.swapCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.swapCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.swapCounter.Location = new System.Drawing.Point(220, 249);
            this.swapCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.swapCounter.Name = "swapCounter";
            this.swapCounter.Size = new System.Drawing.Size(0, 25);
            this.swapCounter.TabIndex = 22;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Black;
            this.time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.time.Location = new System.Drawing.Point(991, 6);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 25);
            this.time.TabIndex = 22;
            // 
            // compCounter
            // 
            this.compCounter.AutoSize = true;
            this.compCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.compCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.compCounter.Location = new System.Drawing.Point(264, 207);
            this.compCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.compCounter.Name = "compCounter";
            this.compCounter.Size = new System.Drawing.Size(0, 25);
            this.compCounter.TabIndex = 22;
            // 
            // swapLabel
            // 
            this.swapLabel.AutoSize = true;
            this.swapLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.swapLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.swapLabel.Location = new System.Drawing.Point(13, 249);
            this.swapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.swapLabel.Name = "swapLabel";
            this.swapLabel.Size = new System.Drawing.Size(199, 25);
            this.swapLabel.TabIndex = 21;
            this.swapLabel.Text = "Кількість замін -";
            // 
            // comparisonLabel
            // 
            this.comparisonLabel.AutoSize = true;
            this.comparisonLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.comparisonLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comparisonLabel.Location = new System.Drawing.Point(13, 207);
            this.comparisonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comparisonLabel.Name = "comparisonLabel";
            this.comparisonLabel.Size = new System.Drawing.Size(243, 25);
            this.comparisonLabel.TabIndex = 20;
            this.comparisonLabel.Text = "Кількість порівнянь -";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionBox.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.descriptionBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionBox.Location = new System.Drawing.Point(908, 79);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionBox.Size = new System.Drawing.Size(489, 222);
            this.descriptionBox.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 10000;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // numbersBox
            // 
            this.numbersBox.AcceptsReturn = true;
            this.numbersBox.AcceptsTab = true;
            this.numbersBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numbersBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numbersBox.CausesValidation = false;
            this.numbersBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.numbersBox.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbersBox.HideSelection = false;
            this.numbersBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numbersBox.Location = new System.Drawing.Point(0, 306);
            this.numbersBox.Multiline = true;
            this.numbersBox.Name = "numbersBox";
            this.numbersBox.ReadOnly = true;
            this.numbersBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.numbersBox.Size = new System.Drawing.Size(1400, 554);
            this.numbersBox.TabIndex = 0;
            this.numbersBox.Visible = false;
            // 
            // panelDisplaySorting
            // 
            this.panelDisplaySorting.Location = new System.Drawing.Point(0, 320);
            this.panelDisplaySorting.Margin = new System.Windows.Forms.Padding(4);
            this.panelDisplaySorting.Name = "panelDisplaySorting";
            this.panelDisplaySorting.Size = new System.Drawing.Size(1400, 588);
            this.panelDisplaySorting.TabIndex = 2;
            this.panelDisplaySorting.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.numbersBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDisplaySorting);
            this.Font = new System.Drawing.Font("Cascadia Code", 14.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3 Сортування";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToGenerateNumbers;
        private System.Windows.Forms.Button buttonToSortNumbers;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox lowerLimitBox;
        private System.Windows.Forms.TextBox higherLimitBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.Label higherLimitLabel;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.ComboBox pickMethodBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label sortingSpeedLabel;
        private System.Windows.Forms.TextBox sortingSpeedBox;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label generationBorderLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelDisplaySorting;
        private System.Windows.Forms.TextBox numbersBox;
        private System.Windows.Forms.Label descriptionBox;
        private System.Windows.Forms.Label swapLabel;
        private System.Windows.Forms.Label comparisonLabel;
        private System.Windows.Forms.Label compCounter;
        private System.Windows.Forms.Label swapCounter;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.CheckBox instantSortCheck;
        private System.Windows.Forms.Button manualInputButton;
        private System.Windows.Forms.Button saveResultButton;
    }
}

