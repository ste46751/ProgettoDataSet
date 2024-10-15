namespace ProgettoDataSet
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Combo_f1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Combo_f2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Analizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1146, 603);
            this.dataGridView1.TabIndex = 1;
            // 
            // Combo_f1
            // 
            this.Combo_f1.FormattingEnabled = true;
            this.Combo_f1.Items.AddRange(new object[] {
            "Job Title",
            "Industry",
            "Company Size",
            "Location",
            "AI Adoption Level",
            "Automation Risk",
            "Required Skills",
            "Salary USD",
            "Remote Friendly",
            "Job Growth Projection"});
            this.Combo_f1.Location = new System.Drawing.Point(38, 21);
            this.Combo_f1.Name = "Combo_f1";
            this.Combo_f1.Size = new System.Drawing.Size(121, 21);
            this.Combo_f1.TabIndex = 2;
            this.Combo_f1.SelectedIndexChanged += new System.EventHandler(this.Combo_f1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Combo_f2);
            this.panel1.Controls.Add(this.Combo_f1);
            this.panel1.Location = new System.Drawing.Point(27, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 212);
            this.panel1.TabIndex = 3;
            // 
            // Combo_f2
            // 
            this.Combo_f2.FormattingEnabled = true;
            this.Combo_f2.Location = new System.Drawing.Point(38, 65);
            this.Combo_f2.Name = "Combo_f2";
            this.Combo_f2.Size = new System.Drawing.Size(121, 21);
            this.Combo_f2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cerca";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Combo_f1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Combo_f2;
        private System.Windows.Forms.Button button2;
    }
}

