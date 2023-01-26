namespace PomocnikSkrotowy
{
    partial class UstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UstForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nOknaTextBox = new System.Windows.Forms.TextBox();
            this.nPrzyciskuBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlLab = new System.Windows.Forms.Label();
            this.shiftLab = new System.Windows.Forms.Label();
            this.altLab = new System.Windows.Forms.Label();
            this.lSkrotuBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zapiszButt = new System.Windows.Forms.Button();
            this.tabLab = new System.Windows.Forms.Label();
            this.macroDataSet = new System.Data.DataSet();
            this.macroDt = new System.Data.DataTable();
            this.IdColumn1 = new System.Data.DataColumn();
            this.klawisz1Dcolumn = new System.Data.DataColumn();
            this.klawisz2Dcolumn = new System.Data.DataColumn();
            this.klawisz3Dcolumn = new System.Data.DataColumn();
            this.klawisz4Dcolumn = new System.Data.DataColumn();
            this.klawisz5Dcolumn = new System.Data.DataColumn();
            this.literyDcolumn = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klawisz1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klawisz2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klawisz3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klawisz4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klawisz5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodajButton = new System.Windows.Forms.Button();
            this.usunButton = new System.Windows.Forms.Button();
            this.enterLab = new System.Windows.Forms.Label();
            this.mojTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.zawszeNaWierzchuCheck = new System.Windows.Forms.CheckBox();
            this.listaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.macroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa okna:";
            // 
            // nOknaTextBox
            // 
            this.nOknaTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nOknaTextBox.Location = new System.Drawing.Point(194, 19);
            this.nOknaTextBox.Name = "nOknaTextBox";
            this.nOknaTextBox.Size = new System.Drawing.Size(262, 29);
            this.nOknaTextBox.TabIndex = 1;
            this.mojTooltip.SetToolTip(this.nOknaTextBox, "Wprowadź nazwę okna programu w którym mają być wykonane skróty");
            // 
            // nPrzyciskuBox
            // 
            this.nPrzyciskuBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nPrzyciskuBox.Location = new System.Drawing.Point(194, 66);
            this.nPrzyciskuBox.Name = "nPrzyciskuBox";
            this.nPrzyciskuBox.Size = new System.Drawing.Size(262, 29);
            this.nPrzyciskuBox.TabIndex = 3;
            this.mojTooltip.SetToolTip(this.nPrzyciskuBox, "Wprowadź nazwę przycisku wykonawczego");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa przycisku:";
            // 
            // ctrlLab
            // 
            this.ctrlLab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ctrlLab.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctrlLab.Location = new System.Drawing.Point(25, 177);
            this.ctrlLab.Name = "ctrlLab";
            this.ctrlLab.Size = new System.Drawing.Size(59, 27);
            this.ctrlLab.TabIndex = 4;
            this.ctrlLab.Text = "ctrl";
            this.ctrlLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlLab.Click += new System.EventHandler(this.ctrlLab_Click);
            // 
            // shiftLab
            // 
            this.shiftLab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.shiftLab.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shiftLab.Location = new System.Drawing.Point(113, 177);
            this.shiftLab.Name = "shiftLab";
            this.shiftLab.Size = new System.Drawing.Size(59, 27);
            this.shiftLab.TabIndex = 5;
            this.shiftLab.Text = "shift";
            this.shiftLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shiftLab.Click += new System.EventHandler(this.shiftLab_Click);
            // 
            // altLab
            // 
            this.altLab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.altLab.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.altLab.Location = new System.Drawing.Point(201, 177);
            this.altLab.Name = "altLab";
            this.altLab.Size = new System.Drawing.Size(59, 27);
            this.altLab.TabIndex = 6;
            this.altLab.Text = "alt";
            this.altLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.altLab.Click += new System.EventHandler(this.altLab_Click);
            // 
            // lSkrotuBox
            // 
            this.lSkrotuBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSkrotuBox.Location = new System.Drawing.Point(140, 224);
            this.lSkrotuBox.Name = "lSkrotuBox";
            this.lSkrotuBox.Size = new System.Drawing.Size(262, 29);
            this.lSkrotuBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Litera skrótu:";
            // 
            // zapiszButt
            // 
            this.zapiszButt.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszButt.Location = new System.Drawing.Point(152, 464);
            this.zapiszButt.Name = "zapiszButt";
            this.zapiszButt.Size = new System.Drawing.Size(236, 40);
            this.zapiszButt.TabIndex = 9;
            this.zapiszButt.Text = "Zapisz";
            this.mojTooltip.SetToolTip(this.zapiszButt, "Zapisuje wprowadzone ustawienia");
            this.zapiszButt.UseVisualStyleBackColor = true;
            this.zapiszButt.Click += new System.EventHandler(this.zapiszButt_Click);
            // 
            // tabLab
            // 
            this.tabLab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabLab.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabLab.Location = new System.Drawing.Point(289, 177);
            this.tabLab.Name = "tabLab";
            this.tabLab.Size = new System.Drawing.Size(59, 27);
            this.tabLab.TabIndex = 10;
            this.tabLab.Text = "tab";
            this.tabLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabLab.Click += new System.EventHandler(this.tabLab_Click);
            // 
            // macroDataSet
            // 
            this.macroDataSet.DataSetName = "macroDataSet";
            this.macroDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.macroDt});
            // 
            // macroDt
            // 
            this.macroDt.Columns.AddRange(new System.Data.DataColumn[] {
            this.IdColumn1,
            this.klawisz1Dcolumn,
            this.klawisz2Dcolumn,
            this.klawisz3Dcolumn,
            this.klawisz4Dcolumn,
            this.klawisz5Dcolumn,
            this.literyDcolumn});
            this.macroDt.TableName = "Skroty";
            // 
            // IdColumn1
            // 
            this.IdColumn1.ColumnName = "Id";
            this.IdColumn1.DataType = typeof(int);
            // 
            // klawisz1Dcolumn
            // 
            this.klawisz1Dcolumn.ColumnName = "Klawisz1";
            // 
            // klawisz2Dcolumn
            // 
            this.klawisz2Dcolumn.ColumnName = "Klawisz2";
            // 
            // klawisz3Dcolumn
            // 
            this.klawisz3Dcolumn.ColumnName = "Klawisz3";
            // 
            // klawisz4Dcolumn
            // 
            this.klawisz4Dcolumn.ColumnName = "Klawisz4";
            // 
            // klawisz5Dcolumn
            // 
            this.klawisz5Dcolumn.ColumnName = "Klawisz5";
            // 
            // literyDcolumn
            // 
            this.literyDcolumn.ColumnName = "Litery";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.klawisz1DataGridViewTextBoxColumn,
            this.klawisz2DataGridViewTextBoxColumn,
            this.klawisz3DataGridViewTextBoxColumn,
            this.Klawisz4,
            this.Klawisz5,
            this.Litery});
            this.dataGridView1.DataMember = "Skroty";
            this.dataGridView1.DataSource = this.macroDataSet;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(19, 308);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(369, 150);
            this.dataGridView1.TabIndex = 11;
            this.mojTooltip.SetToolTip(this.dataGridView1, "Lista utworzonych skrótów");
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // klawisz1DataGridViewTextBoxColumn
            // 
            this.klawisz1DataGridViewTextBoxColumn.DataPropertyName = "Klawisz1";
            this.klawisz1DataGridViewTextBoxColumn.HeaderText = "Klawisz1";
            this.klawisz1DataGridViewTextBoxColumn.Name = "klawisz1DataGridViewTextBoxColumn";
            this.klawisz1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klawisz2DataGridViewTextBoxColumn
            // 
            this.klawisz2DataGridViewTextBoxColumn.DataPropertyName = "Klawisz2";
            this.klawisz2DataGridViewTextBoxColumn.HeaderText = "Klawisz2";
            this.klawisz2DataGridViewTextBoxColumn.Name = "klawisz2DataGridViewTextBoxColumn";
            this.klawisz2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klawisz3DataGridViewTextBoxColumn
            // 
            this.klawisz3DataGridViewTextBoxColumn.DataPropertyName = "Klawisz3";
            this.klawisz3DataGridViewTextBoxColumn.HeaderText = "Klawisz3";
            this.klawisz3DataGridViewTextBoxColumn.Name = "klawisz3DataGridViewTextBoxColumn";
            this.klawisz3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Klawisz4
            // 
            this.Klawisz4.DataPropertyName = "Klawisz4";
            this.Klawisz4.HeaderText = "Klawisz4";
            this.Klawisz4.Name = "Klawisz4";
            this.Klawisz4.ReadOnly = true;
            // 
            // Klawisz5
            // 
            this.Klawisz5.DataPropertyName = "Klawisz5";
            this.Klawisz5.HeaderText = "Klawisz5";
            this.Klawisz5.Name = "Klawisz5";
            this.Klawisz5.ReadOnly = true;
            // 
            // Litery
            // 
            this.Litery.DataPropertyName = "Litery";
            this.Litery.HeaderText = "Litery";
            this.Litery.Name = "Litery";
            this.Litery.ReadOnly = true;
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajButton.Location = new System.Drawing.Point(152, 262);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(236, 40);
            this.dodajButton.TabIndex = 12;
            this.dodajButton.Text = "Dodaj";
            this.mojTooltip.SetToolTip(this.dodajButton, "Dodaj skrót do listy");
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // usunButton
            // 
            this.usunButton.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.usunButton.Location = new System.Drawing.Point(395, 330);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(61, 27);
            this.usunButton.TabIndex = 13;
            this.usunButton.Text = "Usuń";
            this.mojTooltip.SetToolTip(this.usunButton, "Usuń ostatio wprowadzony skrót");
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // enterLab
            // 
            this.enterLab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.enterLab.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enterLab.Location = new System.Drawing.Point(377, 177);
            this.enterLab.Name = "enterLab";
            this.enterLab.Size = new System.Drawing.Size(78, 27);
            this.enterLab.TabIndex = 14;
            this.enterLab.Text = "enter";
            this.enterLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enterLab.Click += new System.EventHandler(this.enterLab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 15;
            // 
            // zawszeNaWierzchuCheck
            // 
            this.zawszeNaWierzchuCheck.AutoSize = true;
            this.zawszeNaWierzchuCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.zawszeNaWierzchuCheck.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zawszeNaWierzchuCheck.ForeColor = System.Drawing.Color.Snow;
            this.zawszeNaWierzchuCheck.Location = new System.Drawing.Point(146, 118);
            this.zawszeNaWierzchuCheck.Name = "zawszeNaWierzchuCheck";
            this.zawszeNaWierzchuCheck.Size = new System.Drawing.Size(202, 26);
            this.zawszeNaWierzchuCheck.TabIndex = 16;
            this.zawszeNaWierzchuCheck.Text = "Zawsze na wierzchu:";
            this.zawszeNaWierzchuCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.zawszeNaWierzchuCheck.UseVisualStyleBackColor = true;
            this.zawszeNaWierzchuCheck.Click += new System.EventHandler(this.zawszeNaWierzchuCheck_Click);
            // 
            // listaButton
            // 
            this.listaButton.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.listaButton.Location = new System.Drawing.Point(408, 226);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(61, 27);
            this.listaButton.TabIndex = 17;
            this.listaButton.Text = "Lista";
            this.mojTooltip.SetToolTip(this.listaButton, "Lista klawiszy funkcyjnych");
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // UstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(481, 522);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.zawszeNaWierzchuCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterLab);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabLab);
            this.Controls.Add(this.zapiszButt);
            this.Controls.Add(this.lSkrotuBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.altLab);
            this.Controls.Add(this.shiftLab);
            this.Controls.Add(this.ctrlLab);
            this.Controls.Add(this.nPrzyciskuBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nOknaTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ustawienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UstForm_FormClosed);
            this.Load += new System.EventHandler(this.UstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.macroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nOknaTextBox;
        private System.Windows.Forms.TextBox nPrzyciskuBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ctrlLab;
        private System.Windows.Forms.Label shiftLab;
        private System.Windows.Forms.Label altLab;
        private System.Windows.Forms.TextBox lSkrotuBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zapiszButt;
        private System.Windows.Forms.Label tabLab;
        private System.Data.DataSet macroDataSet;
        private System.Data.DataTable macroDt;
        private System.Data.DataColumn IdColumn1;
        private System.Data.DataColumn klawisz1Dcolumn;
        private System.Data.DataColumn klawisz2Dcolumn;
        private System.Data.DataColumn klawisz3Dcolumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button usunButton;
        private System.Data.DataColumn klawisz4Dcolumn;
        private System.Data.DataColumn klawisz5Dcolumn;
        private System.Data.DataColumn literyDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klawisz1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klawisz2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klawisz3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klawisz4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klawisz5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litery;
        private System.Windows.Forms.Label enterLab;
        private System.Windows.Forms.ToolTip mojTooltip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox zawszeNaWierzchuCheck;
        private System.Windows.Forms.Button listaButton;
    }
}