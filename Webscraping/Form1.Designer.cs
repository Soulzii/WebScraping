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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omroep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OmroepLocatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHaalFrequenciesOp
            // 
            this.btnHaalFrequenciesOp.Location = new System.Drawing.Point(394, 483);
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
            this.Omroep,
            this.OmroepLocatie});
            this.GVFrequencies.Location = new System.Drawing.Point(26, 24);
            this.GVFrequencies.Name = "GVFrequencies";
            this.GVFrequencies.Size = new System.Drawing.Size(542, 453);
            this.GVFrequencies.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(673, 494);
            this.textBox1.TabIndex = 6;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            // 
            // Omroep
            // 
            this.Omroep.HeaderText = "Omroepnaam";
            this.Omroep.Name = "Omroep";
            // 
            // OmroepLocatie
            // 
            this.OmroepLocatie.HeaderText = "OmroepLocatie";
            this.OmroepLocatie.Name = "OmroepLocatie";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(49, 498);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 13);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "<Status>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 530);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omroep;
        private System.Windows.Forms.DataGridViewTextBoxColumn OmroepLocatie;
        private System.Windows.Forms.Label lbStatus;
    }
}

