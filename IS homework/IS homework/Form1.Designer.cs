namespace etf.cfactor.zd130033d
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
            this.listBoxRules = new System.Windows.Forms.ListBox();
            this.tbRule = new System.Windows.Forms.TextBox();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbAlgorithm = new System.Windows.Forms.RadioButton();
            this.rbStepByStep = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbObserve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxObserve = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConclusion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxConclusion = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMD = new System.Windows.Forms.TextBox();
            this.btAddRule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.gbMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRules
            // 
            this.listBoxRules.FormattingEnabled = true;
            this.listBoxRules.Location = new System.Drawing.Point(561, 24);
            this.listBoxRules.Name = "listBoxRules";
            this.listBoxRules.Size = new System.Drawing.Size(392, 95);
            this.listBoxRules.TabIndex = 0;
            this.listBoxRules.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbRule
            // 
            this.tbRule.Location = new System.Drawing.Point(27, 24);
            this.tbRule.Multiline = true;
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(462, 56);
            this.tbRule.TabIndex = 1;
            this.tbRule.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbAlgorithm);
            this.gbMode.Controls.Add(this.rbStepByStep);
            this.gbMode.Location = new System.Drawing.Point(27, 429);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(198, 83);
            this.gbMode.TabIndex = 2;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Избор рада";
            // 
            // rbAlgorithm
            // 
            this.rbAlgorithm.AutoSize = true;
            this.rbAlgorithm.Checked = true;
            this.rbAlgorithm.Location = new System.Drawing.Point(30, 60);
            this.rbAlgorithm.Name = "rbAlgorithm";
            this.rbAlgorithm.Size = new System.Drawing.Size(80, 17);
            this.rbAlgorithm.TabIndex = 1;
            this.rbAlgorithm.TabStop = true;
            this.rbAlgorithm.Text = "Алгоритам";
            this.rbAlgorithm.UseVisualStyleBackColor = true;
            // 
            // rbStepByStep
            // 
            this.rbStepByStep.AutoSize = true;
            this.rbStepByStep.Location = new System.Drawing.Point(33, 19);
            this.rbStepByStep.Name = "rbStepByStep";
            this.rbStepByStep.Size = new System.Drawing.Size(104, 17);
            this.rbStepByStep.TabIndex = 0;
            this.rbStepByStep.Text = "Корак по корак";
            this.rbStepByStep.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Један";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(255, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Избор алгоритма";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Додавање правила";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Додата правила";
            // 
            // tbObserve
            // 
            this.tbObserve.Location = new System.Drawing.Point(27, 175);
            this.tbObserve.Multiline = true;
            this.tbObserve.Name = "tbObserve";
            this.tbObserve.Size = new System.Drawing.Size(124, 56);
            this.tbObserve.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Додавање опажања";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBoxObserve
            // 
            this.listBoxObserve.FormattingEnabled = true;
            this.listBoxObserve.Location = new System.Drawing.Point(561, 175);
            this.listBoxObserve.Name = "listBoxObserve";
            this.listBoxObserve.Size = new System.Drawing.Size(392, 95);
            this.listBoxObserve.TabIndex = 12;
            this.listBoxObserve.SelectedIndexChanged += new System.EventHandler(this.listBoxObserve_SelectedIndexChanged);
            this.listBoxObserve.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxObserve_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Додата опажања";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Додај опажање";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Додавање закључака";
            // 
            // tbConclusion
            // 
            this.tbConclusion.Location = new System.Drawing.Point(27, 317);
            this.tbConclusion.Multiline = true;
            this.tbConclusion.Name = "tbConclusion";
            this.tbConclusion.Size = new System.Drawing.Size(462, 56);
            this.tbConclusion.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Додај закљуачк";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxConclusion
            // 
            this.listBoxConclusion.FormattingEnabled = true;
            this.listBoxConclusion.Location = new System.Drawing.Point(561, 317);
            this.listBoxConclusion.Name = "listBoxConclusion";
            this.listBoxConclusion.Size = new System.Drawing.Size(392, 95);
            this.listBoxConclusion.TabIndex = 18;
            this.listBoxConclusion.SelectedIndexChanged += new System.EventHandler(this.listBoxConclusion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Додати закључци";
            // 
            // tbMB
            // 
            this.tbMB.Location = new System.Drawing.Point(195, 175);
            this.tbMB.Name = "tbMB";
            this.tbMB.Size = new System.Drawing.Size(109, 20);
            this.tbMB.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Measure of belief";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Measure of disbelief";
            // 
            // tbMD
            // 
            this.tbMD.Location = new System.Drawing.Point(195, 214);
            this.tbMD.Name = "tbMD";
            this.tbMD.Size = new System.Drawing.Size(109, 20);
            this.tbMD.TabIndex = 23;
            // 
            // btAddRule
            // 
            this.btAddRule.Location = new System.Drawing.Point(27, 105);
            this.btAddRule.Name = "btAddRule";
            this.btAddRule.Size = new System.Drawing.Size(124, 33);
            this.btAddRule.TabIndex = 24;
            this.btAddRule.Text = "Додај правило";
            this.btAddRule.UseVisualStyleBackColor = true;
            this.btAddRule.Click += new System.EventHandler(this.btAddRule_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Обриши правило";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 35);
            this.button4.TabIndex = 27;
            this.button4.Text = "Обриши опажање";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(355, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 33);
            this.button5.TabIndex = 28;
            this.button5.Text = "Промени правило";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(561, 448);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(392, 95);
            this.listBox1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Резултат алгоритма";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(355, 252);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 33);
            this.button6.TabIndex = 31;
            this.button6.Text = "Промени опажање";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(191, 379);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 35);
            this.button7.TabIndex = 32;
            this.button7.Text = "Обриши закључак";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(30, 536);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 33);
            this.button8.TabIndex = 33;
            this.button8.Text = "Следећи корак";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 581);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAddRule);
            this.Controls.Add(this.tbMD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxConclusion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbConclusion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxObserve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbObserve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.tbRule);
            this.Controls.Add(this.listBoxRules);
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

        private System.Windows.Forms.ListBox listBoxRules;
        private System.Windows.Forms.TextBox tbRule;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbAlgorithm;
        private System.Windows.Forms.RadioButton rbStepByStep;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbObserve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxObserve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConclusion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxConclusion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMD;
        private System.Windows.Forms.Button btAddRule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

