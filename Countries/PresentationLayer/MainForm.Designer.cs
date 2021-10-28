namespace PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Pregled = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxRegions = new System.Windows.Forms.ComboBox();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilosta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxInputRegion = new System.Windows.Forms.TextBox();
            this.textBoxInputArea = new System.Windows.Forms.TextBox();
            this.textBoxInputPopulation = new System.Windows.Forms.TextBox();
            this.textBoxInputCapital = new System.Windows.Forms.TextBox();
            this.textBoxInputName = new System.Windows.Forms.TextBox();
            this.labelKontinent = new System.Windows.Forms.Label();
            this.labelPovrsina = new System.Windows.Forms.Label();
            this.labelBroj = new System.Windows.Forms.Label();
            this.labelGlavniGrad = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxInputCode = new System.Windows.Forms.TextBox();
            this.labelKod = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.webBrowserKarta = new System.Windows.Forms.WebBrowser();
            this.Pregled.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pregled
            // 
            this.Pregled.Controls.Add(this.tabPage1);
            this.Pregled.Controls.Add(this.tabPage2);
            this.Pregled.Controls.Add(this.tabPage3);
            this.Pregled.Location = new System.Drawing.Point(1, 1);
            this.Pregled.Name = "Pregled";
            this.Pregled.SelectedIndex = 0;
            this.Pregled.Size = new System.Drawing.Size(989, 425);
            this.Pregled.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxActions);
            this.tabPage1.Controls.Add(this.dataGridViewCountries);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pregled";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.numericUpDownMax);
            this.groupBoxActions.Controls.Add(this.numericUpDownMin);
            this.groupBoxActions.Controls.Add(this.textBoxCapital);
            this.groupBoxActions.Controls.Add(this.textBoxName);
            this.groupBoxActions.Controls.Add(this.buttonFilter);
            this.groupBoxActions.Controls.Add(this.comboBoxRegions);
            this.groupBoxActions.Location = new System.Drawing.Point(10, 6);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(233, 240);
            this.groupBoxActions.TabIndex = 6;
            this.groupBoxActions.TabStop = false;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(75, 160);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(140, 26);
            this.numericUpDownMax.TabIndex = 5;
            this.numericUpDownMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(75, 125);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(140, 26);
            this.numericUpDownMin.TabIndex = 4;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(75, 91);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(140, 26);
            this.textBoxCapital.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(75, 55);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 26);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(15, 204);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(200, 30);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "FILTRIRAJ";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Location = new System.Drawing.Point(75, 20);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(140, 28);
            this.comboBoxRegions.TabIndex = 0;
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.bilosta,
            this.Capital,
            this.Population,
            this.Area,
            this.Region1});
            this.dataGridViewCountries.Location = new System.Drawing.Point(243, 6);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.RowHeadersWidth = 62;
            this.dataGridViewCountries.RowTemplate.Height = 28;
            this.dataGridViewCountries.Size = new System.Drawing.Size(725, 246);
            this.dataGridViewCountries.TabIndex = 5;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "code";
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            // 
            // bilosta
            // 
            this.bilosta.DataPropertyName = "name";
            this.bilosta.HeaderText = "Name";
            this.bilosta.MinimumWidth = 8;
            this.bilosta.Name = "bilosta";
            // 
            // Capital
            // 
            this.Capital.DataPropertyName = "capital";
            this.Capital.HeaderText = "Capital";
            this.Capital.MinimumWidth = 8;
            this.Capital.Name = "Capital";
            // 
            // Population
            // 
            this.Population.DataPropertyName = "population";
            this.Population.HeaderText = "Population";
            this.Population.MinimumWidth = 8;
            this.Population.Name = "Population";
            // 
            // Area
            // 
            this.Area.DataPropertyName = "area";
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 8;
            this.Area.Name = "Area";
            // 
            // Region1
            // 
            this.Region1.DataPropertyName = "region";
            this.Region1.HeaderText = "Region";
            this.Region1.MinimumWidth = 8;
            this.Region1.Name = "Region1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSpremi);
            this.tabPage2.Controls.Add(this.textBoxInputRegion);
            this.tabPage2.Controls.Add(this.textBoxInputArea);
            this.tabPage2.Controls.Add(this.textBoxInputPopulation);
            this.tabPage2.Controls.Add(this.textBoxInputCapital);
            this.tabPage2.Controls.Add(this.textBoxInputName);
            this.tabPage2.Controls.Add(this.labelKontinent);
            this.tabPage2.Controls.Add(this.labelPovrsina);
            this.tabPage2.Controls.Add(this.labelBroj);
            this.tabPage2.Controls.Add(this.labelGlavniGrad);
            this.tabPage2.Controls.Add(this.labelNaziv);
            this.tabPage2.Controls.Add(this.textBoxInputCode);
            this.tabPage2.Controls.Add(this.labelKod);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxInputRegion
            // 
            this.textBoxInputRegion.Location = new System.Drawing.Point(215, 219);
            this.textBoxInputRegion.Name = "textBoxInputRegion";
            this.textBoxInputRegion.Size = new System.Drawing.Size(200, 26);
            this.textBoxInputRegion.TabIndex = 11;
            // 
            // textBoxInputArea
            // 
            this.textBoxInputArea.Location = new System.Drawing.Point(215, 177);
            this.textBoxInputArea.Name = "textBoxInputArea";
            this.textBoxInputArea.Size = new System.Drawing.Size(200, 26);
            this.textBoxInputArea.TabIndex = 10;
            // 
            // textBoxInputPopulation
            // 
            this.textBoxInputPopulation.Location = new System.Drawing.Point(215, 134);
            this.textBoxInputPopulation.Name = "textBoxInputPopulation";
            this.textBoxInputPopulation.Size = new System.Drawing.Size(200, 26);
            this.textBoxInputPopulation.TabIndex = 9;
            // 
            // textBoxInputCapital
            // 
            this.textBoxInputCapital.Location = new System.Drawing.Point(215, 91);
            this.textBoxInputCapital.Name = "textBoxInputCapital";
            this.textBoxInputCapital.Size = new System.Drawing.Size(200, 26);
            this.textBoxInputCapital.TabIndex = 8;
            // 
            // textBoxInputName
            // 
            this.textBoxInputName.Location = new System.Drawing.Point(215, 53);
            this.textBoxInputName.Name = "textBoxInputName";
            this.textBoxInputName.Size = new System.Drawing.Size(200, 26);
            this.textBoxInputName.TabIndex = 7;
            // 
            // labelKontinent
            // 
            this.labelKontinent.AutoSize = true;
            this.labelKontinent.Location = new System.Drawing.Point(72, 222);
            this.labelKontinent.Name = "labelKontinent";
            this.labelKontinent.Size = new System.Drawing.Size(77, 20);
            this.labelKontinent.TabIndex = 6;
            this.labelKontinent.Text = "Kontinent";
            // 
            // labelPovrsina
            // 
            this.labelPovrsina.AutoSize = true;
            this.labelPovrsina.Location = new System.Drawing.Point(80, 183);
            this.labelPovrsina.Name = "labelPovrsina";
            this.labelPovrsina.Size = new System.Drawing.Size(69, 20);
            this.labelPovrsina.TabIndex = 5;
            this.labelPovrsina.Text = "Površina";
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Location = new System.Drawing.Point(32, 140);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(117, 20);
            this.labelBroj.TabIndex = 4;
            this.labelBroj.Text = "Broj stanovnika";
            this.labelBroj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGlavniGrad
            // 
            this.labelGlavniGrad.AutoSize = true;
            this.labelGlavniGrad.Location = new System.Drawing.Point(60, 97);
            this.labelGlavniGrad.Name = "labelGlavniGrad";
            this.labelGlavniGrad.Size = new System.Drawing.Size(89, 20);
            this.labelGlavniGrad.TabIndex = 3;
            this.labelGlavniGrad.Text = "Glavni grad";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(102, 53);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(47, 20);
            this.labelNaziv.TabIndex = 2;
            this.labelNaziv.Text = "Naziv";
            // 
            // textBoxInputCode
            // 
            this.textBoxInputCode.Location = new System.Drawing.Point(215, 12);
            this.textBoxInputCode.Name = "textBoxInputCode";
            this.textBoxInputCode.Size = new System.Drawing.Size(200, 26);
            this.textBoxInputCode.TabIndex = 1;
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(112, 18);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(37, 20);
            this.labelKod.TabIndex = 0;
            this.labelKod.Text = "Kod";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowserKarta);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(981, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Karta Svijeta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(36, 288);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(135, 54);
            this.buttonSpremi.TabIndex = 12;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // webBrowserKarta
            // 
            this.webBrowserKarta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserKarta.Location = new System.Drawing.Point(3, 3);
            this.webBrowserKarta.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserKarta.Name = "webBrowserKarta";
            this.webBrowserKarta.Size = new System.Drawing.Size(975, 386);
            this.webBrowserKarta.TabIndex = 0;
            this.webBrowserKarta.Url = new System.Uri("https://www.openstreetmap.org/#map=7/44.523/16.460", System.UriKind.Absolute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 422);
            this.Controls.Add(this.Pregled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "World Countries";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Pregled.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Pregled;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilosta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region1;
        private System.Windows.Forms.Label labelKontinent;
        private System.Windows.Forms.Label labelPovrsina;
        private System.Windows.Forms.Label labelBroj;
        private System.Windows.Forms.Label labelGlavniGrad;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textBoxInputCode;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.TextBox textBoxInputRegion;
        private System.Windows.Forms.TextBox textBoxInputArea;
        private System.Windows.Forms.TextBox textBoxInputPopulation;
        private System.Windows.Forms.TextBox textBoxInputCapital;
        private System.Windows.Forms.TextBox textBoxInputName;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.WebBrowser webBrowserKarta;
    }
}

