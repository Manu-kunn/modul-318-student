namespace MyTransportApp
{
  partial class Form1
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.nachBox = new System.Windows.Forms.ComboBox();
      this.vonBox = new System.Windows.Forms.ComboBox();
      this.sucheButton = new System.Windows.Forms.Button();
      this.abfahrtstafelButton = new System.Windows.Forms.Button();
      this.datumdp = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.nachLable = new System.Windows.Forms.Label();
      this.wechselnButton = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.ausgabeGrid = new System.Windows.Forms.DataGridView();
      this.titelLable = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.timedp = new System.Windows.Forms.DateTimePicker();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ausgabeGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.timedp);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.nachBox);
      this.groupBox1.Controls.Add(this.vonBox);
      this.groupBox1.Controls.Add(this.sucheButton);
      this.groupBox1.Controls.Add(this.abfahrtstafelButton);
      this.groupBox1.Controls.Add(this.datumdp);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.nachLable);
      this.groupBox1.Controls.Add(this.wechselnButton);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(12, 54);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(776, 113);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Suche";
      // 
      // nachBox
      // 
      this.nachBox.FormattingEnabled = true;
      this.nachBox.Location = new System.Drawing.Point(521, 17);
      this.nachBox.Name = "nachBox";
      this.nachBox.Size = new System.Drawing.Size(249, 21);
      this.nachBox.TabIndex = 10;
      // 
      // vonBox
      // 
      this.vonBox.FormattingEnabled = true;
      this.vonBox.Location = new System.Drawing.Point(42, 17);
      this.vonBox.Name = "vonBox";
      this.vonBox.Size = new System.Drawing.Size(249, 21);
      this.vonBox.TabIndex = 9;
      // 
      // sucheButton
      // 
      this.sucheButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.sucheButton.Location = new System.Drawing.Point(610, 61);
      this.sucheButton.Name = "sucheButton";
      this.sucheButton.Size = new System.Drawing.Size(160, 20);
      this.sucheButton.TabIndex = 8;
      this.sucheButton.Text = "Suche";
      this.sucheButton.UseVisualStyleBackColor = true;
      this.sucheButton.Click += new System.EventHandler(this.sucheButton_Click);
      // 
      // abfahrtstafelButton
      // 
      this.abfahrtstafelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.abfahrtstafelButton.Location = new System.Drawing.Point(610, 87);
      this.abfahrtstafelButton.Name = "abfahrtstafelButton";
      this.abfahrtstafelButton.Size = new System.Drawing.Size(160, 20);
      this.abfahrtstafelButton.TabIndex = 7;
      this.abfahrtstafelButton.Text = "Abfahrtstafel";
      this.abfahrtstafelButton.UseVisualStyleBackColor = true;
      this.abfahrtstafelButton.Click += new System.EventHandler(this.abfahrtstafelButton_Click);
      // 
      // datumdp
      // 
      this.datumdp.Location = new System.Drawing.Point(54, 68);
      this.datumdp.Name = "datumdp";
      this.datumdp.Size = new System.Drawing.Size(184, 20);
      this.datumdp.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label5.Location = new System.Drawing.Point(7, 74);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Datum:";
      // 
      // nachLable
      // 
      this.nachLable.AutoSize = true;
      this.nachLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.nachLable.Location = new System.Drawing.Point(479, 21);
      this.nachLable.Name = "nachLable";
      this.nachLable.Size = new System.Drawing.Size(36, 13);
      this.nachLable.TabIndex = 3;
      this.nachLable.Text = "Nach:";
      // 
      // wechselnButton
      // 
      this.wechselnButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.wechselnButton.Location = new System.Drawing.Point(360, 18);
      this.wechselnButton.Name = "wechselnButton";
      this.wechselnButton.Size = new System.Drawing.Size(75, 20);
      this.wechselnButton.TabIndex = 2;
      this.wechselnButton.Text = "wechseln";
      this.wechselnButton.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label3.Location = new System.Drawing.Point(7, 20);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Von:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.ausgabeGrid);
      this.groupBox2.Location = new System.Drawing.Point(12, 173);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(776, 265);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Ergebnis";
      // 
      // ausgabeGrid
      // 
      this.ausgabeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ausgabeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.Platform,
            this.Abfahrt,
            this.Ankunft,
            this.Zeit});
      this.ausgabeGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ausgabeGrid.Location = new System.Drawing.Point(7, 20);
      this.ausgabeGrid.Name = "ausgabeGrid";
      this.ausgabeGrid.Size = new System.Drawing.Size(763, 239);
      this.ausgabeGrid.TabIndex = 0;
      // 
      // titelLable
      // 
      this.titelLable.AutoSize = true;
      this.titelLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titelLable.ForeColor = System.Drawing.Color.Black;
      this.titelLable.Location = new System.Drawing.Point(87, 15);
      this.titelLable.Name = "titelLable";
      this.titelLable.Size = new System.Drawing.Size(277, 31);
      this.titelLable.TabIndex = 2;
      this.titelLable.Text = "Verbindungen suchen";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.SteelBlue;
      this.label2.Location = new System.Drawing.Point(9, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 41);
      this.label2.TabIndex = 3;
      this.label2.Text = "SBN";
      // 
      // Von
      // 
      this.Von.HeaderText = "Von";
      this.Von.Name = "Von";
      this.Von.Width = 95;
      // 
      // Nach
      // 
      this.Nach.HeaderText = "Nach";
      this.Nach.Name = "Nach";
      this.Nach.Width = 125;
      // 
      // Platform
      // 
      this.Platform.HeaderText = "Platform";
      this.Platform.Name = "Platform";
      // 
      // Abfahrt
      // 
      this.Abfahrt.HeaderText = "Abfahrt";
      this.Abfahrt.Name = "Abfahrt";
      this.Abfahrt.Width = 150;
      // 
      // Ankunft
      // 
      this.Ankunft.HeaderText = "Ankunft";
      this.Ankunft.Name = "Ankunft";
      this.Ankunft.Width = 150;
      // 
      // Zeit
      // 
      this.Zeit.HeaderText = "Dauer";
      this.Zeit.Name = "Zeit";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.Location = new System.Drawing.Point(263, 74);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Zeit:";
      // 
      // timedp
      // 
      this.timedp.Checked = false;
      this.timedp.CustomFormat = "HH:mm";
      this.timedp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.timedp.Location = new System.Drawing.Point(297, 68);
      this.timedp.Name = "timedp";
      this.timedp.ShowUpDown = true;
      this.timedp.Size = new System.Drawing.Size(55, 20);
      this.timedp.TabIndex = 12;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.titelLable);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.ForeColor = System.Drawing.Color.Aqua;
      this.Name = "Form1";
      this.Text = "Schweizerisches Bahnnetz";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ausgabeGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button wechselnButton;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label titelLable;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button sucheButton;
    private System.Windows.Forms.Button abfahrtstafelButton;
    private System.Windows.Forms.DateTimePicker datumdp;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label nachLable;
    private System.Windows.Forms.ComboBox nachBox;
    private System.Windows.Forms.ComboBox vonBox;
    private System.Windows.Forms.DataGridView ausgabeGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn Von;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
    private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
    private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
    private System.Windows.Forms.DateTimePicker timedp;
    private System.Windows.Forms.Label label1;
  }
}

