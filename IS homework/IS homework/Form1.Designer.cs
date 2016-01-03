namespace IS_homework
{
    partial class formMain
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
            this.lbRules = new System.Windows.Forms.ListBox();
            this.tbRule = new System.Windows.Forms.TextBox();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbStepByStep = new System.Windows.Forms.RadioButton();
            this.rbAlgorithm = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.Items.AddRange(new object[] {
            "Тест"});
            this.lbRules.Location = new System.Drawing.Point(629, 24);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(523, 160);
            this.lbRules.TabIndex = 0;
            this.lbRules.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbRule
            // 
            this.tbRule.Location = new System.Drawing.Point(27, 24);
            this.tbRule.Multiline = true;
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(474, 160);
            this.tbRule.TabIndex = 1;
            this.tbRule.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbAlgorithm);
            this.gbMode.Controls.Add(this.rbStepByStep);
            this.gbMode.Location = new System.Drawing.Point(27, 261);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(200, 100);
            this.gbMode.TabIndex = 2;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Избор рада";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1278, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // rbStepByStep
            // 
            this.rbStepByStep.AutoSize = true;
            this.rbStepByStep.Location = new System.Drawing.Point(33, 20);
            this.rbStepByStep.Name = "rbStepByStep";
            this.rbStepByStep.Size = new System.Drawing.Size(104, 17);
            this.rbStepByStep.TabIndex = 0;
            this.rbStepByStep.TabStop = true;
            this.rbStepByStep.Text = "Корак по корак";
            this.rbStepByStep.UseVisualStyleBackColor = true;
            // 
            // rbAlgorithm
            // 
            this.rbAlgorithm.AutoSize = true;
            this.rbAlgorithm.Location = new System.Drawing.Point(33, 53);
            this.rbAlgorithm.Name = "rbAlgorithm";
            this.rbAlgorithm.Size = new System.Drawing.Size(80, 17);
            this.rbAlgorithm.TabIndex = 1;
            this.rbAlgorithm.TabStop = true;
            this.rbAlgorithm.Text = "Алгоритам";
            this.rbAlgorithm.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(301, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Избор алгоритма";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.tbRule);
            this.Controls.Add(this.lbRules);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Резоновање на основу фактора извесности";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.TextBox tbRule;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.RadioButton rbAlgorithm;
        private System.Windows.Forms.RadioButton rbStepByStep;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

