namespace TKACIKJoesAutomotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.oilCheck = new System.Windows.Forms.CheckBox();
            this.lubeCheck = new System.Windows.Forms.CheckBox();
            this.radiatorCheck = new System.Windows.Forms.CheckBox();
            this.transmissionCheck = new System.Windows.Forms.CheckBox();
            this.inspectCheck = new System.Windows.Forms.CheckBox();
            this.mufflerCheck = new System.Windows.Forms.CheckBox();
            this.tireCheck = new System.Windows.Forms.CheckBox();
            this.partsInput = new System.Windows.Forms.TextBox();
            this.laborInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serviceOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.partsOutput = new System.Windows.Forms.Label();
            this.fessOutput = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubeCheck);
            this.groupBox1.Controls.Add(this.oilCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transmissionCheck);
            this.groupBox2.Controls.Add(this.radiatorCheck);
            this.groupBox2.Location = new System.Drawing.Point(218, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tireCheck);
            this.groupBox3.Controls.Add(this.mufflerCheck);
            this.groupBox3.Controls.Add(this.inspectCheck);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.laborInput);
            this.groupBox4.Controls.Add(this.partsInput);
            this.groupBox4.Location = new System.Drawing.Point(218, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fessOutput);
            this.groupBox5.Controls.Add(this.partsOutput);
            this.groupBox5.Controls.Add(this.taxOutput);
            this.groupBox5.Controls.Add(this.serviceOutput);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(12, 221);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 183);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // oilCheck
            // 
            this.oilCheck.AutoSize = true;
            this.oilCheck.Location = new System.Drawing.Point(6, 19);
            this.oilCheck.Name = "oilCheck";
            this.oilCheck.Size = new System.Drawing.Size(120, 17);
            this.oilCheck.TabIndex = 5;
            this.oilCheck.Text = "Oil Change ($26.00)";
            this.oilCheck.UseVisualStyleBackColor = true;
            this.oilCheck.CheckedChanged += new System.EventHandler(this.oilCheck_CheckedChanged);
            // 
            // lubeCheck
            // 
            this.lubeCheck.AutoSize = true;
            this.lubeCheck.Location = new System.Drawing.Point(6, 42);
            this.lubeCheck.Name = "lubeCheck";
            this.lubeCheck.Size = new System.Drawing.Size(112, 17);
            this.lubeCheck.TabIndex = 6;
            this.lubeCheck.Text = "Lube Job ($18.00)";
            this.lubeCheck.UseVisualStyleBackColor = true;
            this.lubeCheck.CheckedChanged += new System.EventHandler(this.lubeCheck_CheckedChanged);
            // 
            // radiatorCheck
            // 
            this.radiatorCheck.AutoSize = true;
            this.radiatorCheck.Location = new System.Drawing.Point(6, 19);
            this.radiatorCheck.Name = "radiatorCheck";
            this.radiatorCheck.Size = new System.Drawing.Size(136, 17);
            this.radiatorCheck.TabIndex = 6;
            this.radiatorCheck.Text = "Radiator Flush ($30.00)";
            this.radiatorCheck.UseVisualStyleBackColor = true;
            this.radiatorCheck.CheckedChanged += new System.EventHandler(this.radiatorCheck_CheckedChanged);
            // 
            // transmissionCheck
            // 
            this.transmissionCheck.AutoSize = true;
            this.transmissionCheck.Location = new System.Drawing.Point(6, 42);
            this.transmissionCheck.Name = "transmissionCheck";
            this.transmissionCheck.Size = new System.Drawing.Size(157, 17);
            this.transmissionCheck.TabIndex = 7;
            this.transmissionCheck.Text = "Transmission Flush ($80.00)";
            this.transmissionCheck.UseVisualStyleBackColor = true;
            this.transmissionCheck.CheckedChanged += new System.EventHandler(this.transmissionCheck_CheckedChanged);
            // 
            // inspectCheck
            // 
            this.inspectCheck.AutoSize = true;
            this.inspectCheck.Location = new System.Drawing.Point(6, 19);
            this.inspectCheck.Name = "inspectCheck";
            this.inspectCheck.Size = new System.Drawing.Size(117, 17);
            this.inspectCheck.TabIndex = 6;
            this.inspectCheck.Text = "Inspection ($15.00)";
            this.inspectCheck.UseVisualStyleBackColor = true;
            this.inspectCheck.CheckedChanged += new System.EventHandler(this.inspectCheck_CheckedChanged);
            // 
            // mufflerCheck
            // 
            this.mufflerCheck.AutoSize = true;
            this.mufflerCheck.Location = new System.Drawing.Point(6, 42);
            this.mufflerCheck.Name = "mufflerCheck";
            this.mufflerCheck.Size = new System.Drawing.Size(149, 17);
            this.mufflerCheck.TabIndex = 7;
            this.mufflerCheck.Text = "Replace Muffler ($100.00)";
            this.mufflerCheck.UseVisualStyleBackColor = true;
            this.mufflerCheck.CheckedChanged += new System.EventHandler(this.mufflerCheck_CheckedChanged);
            // 
            // tireCheck
            // 
            this.tireCheck.AutoSize = true;
            this.tireCheck.Location = new System.Drawing.Point(6, 65);
            this.tireCheck.Name = "tireCheck";
            this.tireCheck.Size = new System.Drawing.Size(129, 17);
            this.tireCheck.TabIndex = 8;
            this.tireCheck.Text = "Tire Rotation ($20.00)";
            this.tireCheck.UseVisualStyleBackColor = true;
            this.tireCheck.CheckedChanged += new System.EventHandler(this.tireCheck_CheckedChanged);
            // 
            // partsInput
            // 
            this.partsInput.Location = new System.Drawing.Point(80, 16);
            this.partsInput.Name = "partsInput";
            this.partsInput.Size = new System.Drawing.Size(100, 20);
            this.partsInput.TabIndex = 0;
            this.partsInput.TextChanged += new System.EventHandler(this.partsInput_TextChanged);
            // 
            // laborInput
            // 
            this.laborInput.Location = new System.Drawing.Point(80, 42);
            this.laborInput.Name = "laborInput";
            this.laborInput.Size = new System.Drawing.Size(100, 20);
            this.laborInput.TabIndex = 1;
            this.laborInput.TextChanged += new System.EventHandler(this.laborInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Labor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Service and Labor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tax (on parts)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total fees";
            // 
            // serviceOutput
            // 
            this.serviceOutput.BackColor = System.Drawing.Color.Transparent;
            this.serviceOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceOutput.Location = new System.Drawing.Point(179, 35);
            this.serviceOutput.Name = "serviceOutput";
            this.serviceOutput.Size = new System.Drawing.Size(90, 23);
            this.serviceOutput.TabIndex = 10;
            this.serviceOutput.Click += new System.EventHandler(this.serviceOutput_Click);
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxOutput.Location = new System.Drawing.Point(179, 91);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(90, 23);
            this.taxOutput.TabIndex = 11;
            this.taxOutput.Click += new System.EventHandler(this.taxOutput_Click);
            // 
            // partsOutput
            // 
            this.partsOutput.BackColor = System.Drawing.Color.Transparent;
            this.partsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsOutput.Location = new System.Drawing.Point(179, 63);
            this.partsOutput.Name = "partsOutput";
            this.partsOutput.Size = new System.Drawing.Size(90, 23);
            this.partsOutput.TabIndex = 12;
            this.partsOutput.Click += new System.EventHandler(this.partsOutput_Click);
            // 
            // fessOutput
            // 
            this.fessOutput.BackColor = System.Drawing.Color.Transparent;
            this.fessOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fessOutput.Location = new System.Drawing.Point(179, 119);
            this.fessOutput.Name = "fessOutput";
            this.fessOutput.Size = new System.Drawing.Size(90, 23);
            this.fessOutput.TabIndex = 13;
            this.fessOutput.Click += new System.EventHandler(this.fessOutput_Click);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 410);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 66);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(158, 410);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 66);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(318, 410);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 66);
            this.quitButton.TabIndex = 7;
            this.quitButton.Text = "Exit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 518);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lubeCheck;
        private System.Windows.Forms.CheckBox oilCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox transmissionCheck;
        private System.Windows.Forms.CheckBox radiatorCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox tireCheck;
        private System.Windows.Forms.CheckBox mufflerCheck;
        private System.Windows.Forms.CheckBox inspectCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox laborInput;
        private System.Windows.Forms.TextBox partsInput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label fessOutput;
        private System.Windows.Forms.Label partsOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label serviceOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
    }
}

