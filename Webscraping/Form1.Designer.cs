namespace Webscraping
{
    partial class Form1
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
            this.btnHaalFrequenciesOp = new System.Windows.Forms.Button();
            this.GVFrequencies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMinRange = new System.Windows.Forms.TextBox();
            this.tbMaxRange = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coordinaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OmroepLocatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omroep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHaalFrequenciesOp
            // 
            this.btnHaalFrequenciesOp.Location = new System.Drawing.Point(394, 278);
            this.btnHaalFrequenciesOp.Name = "btnHaalFrequenciesOp";
            this.btnHaalFrequenciesOp.Size = new System.Drawing.Size(174, 23);
            this.btnHaalFrequenciesOp.TabIndex = 0;
            this.btnHaalFrequenciesOp.Text = "Haal lijst FM Frequencies op";
            this.btnHaalFrequenciesOp.UseVisualStyleBackColor = true;
            this.btnHaalFrequenciesOp.Click += new System.EventHandler(this.btnHaalFrequenciesOp_Click);
            // 
            // GVFrequencies
            // 
            this.GVFrequencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVFrequencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frequency,
            this.Provincie,
            this.Coordinaten,
            this.OmroepLocatie,
            this.Omroep});
            this.GVFrequencies.Location = new System.Drawing.Point(26, 24);
            this.GVFrequencies.Name = "GVFrequencies";
            this.GVFrequencies.Size = new System.Drawing.Size(542, 250);
            this.GVFrequencies.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min. Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max. Range";
            // 
            // tbMinRange
            // 
            this.tbMinRange.Location = new System.Drawing.Point(91, 280);
            this.tbMinRange.Name = "tbMinRange";
            this.tbMinRange.Size = new System.Drawing.Size(54, 20);
            this.tbMinRange.TabIndex = 4;
            // 
            // tbMaxRange
            // 
            this.tbMaxRange.Location = new System.Drawing.Point(222, 283);
            this.tbMaxRange.Name = "tbMaxRange";
            this.tbMaxRange.Size = new System.Drawing.Size(54, 20);
            this.tbMaxRange.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(686, 494);
            this.textBox1.TabIndex = 6;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            // 
            // Provincie
            // 
            this.Provincie.HeaderText = "Provincie";
            this.Provincie.Name = "Provincie";
            // 
            // Coordinaten
            // 
            this.Coordinaten.HeaderText = "Coordinaten";
            this.Coordinaten.Name = "Coordinaten";
            // 
            // OmroepLocatie
            // 
            this.OmroepLocatie.HeaderText = "OmroepLocatie";
            this.OmroepLocatie.Name = "OmroepLocatie";
            // 
            // Omroep
            // 
            this.Omroep.HeaderText = "Omroepnaam";
            this.Omroep.Name = "Omroep";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 530);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbMaxRange);
            this.Controls.Add(this.tbMinRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GVFrequencies);
            this.Controls.Add(this.btnHaalFrequenciesOp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GVFrequencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHaalFrequenciesOp;
        private System.Windows.Forms.DataGridView GVFrequencies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMinRange;
        private System.Windows.Forms.TextBox tbMaxRange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coordinaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn OmroepLocatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omroep;
    }
}

