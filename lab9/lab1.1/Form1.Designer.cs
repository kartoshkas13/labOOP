namespace lab1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxH = new TextBox();
            textBoxM = new TextBox();
            textBoxS = new TextBox();
            buttonSet = new Button();
            buttonAdd = new Button();
            labelTime = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSub = new Button();
            SuspendLayout();
            // 
            // textBoxH
            // 
            textBoxH.Location = new Point(137, 101);
            textBoxH.Name = "textBoxH";
            textBoxH.Size = new Size(100, 23);
            textBoxH.TabIndex = 0;
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(321, 101);
            textBoxM.Name = "textBoxM";
            textBoxM.Size = new Size(100, 23);
            textBoxM.TabIndex = 1;
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(467, 101);
            textBoxS.Name = "textBoxS";
            textBoxS.Size = new Size(100, 23);
            textBoxS.TabIndex = 2;
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(199, 191);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(75, 23);
            buttonSet.TabIndex = 3;
            buttonSet.Text = "set time";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(346, 191);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "add time";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(341, 52);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(49, 15);
            labelTime.TabIndex = 5;
            labelTime.Text = "00:00:00";
            labelTime.Click += labelTime_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 73);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 6;
            label1.Text = "hour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 73);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "minute";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 73);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "second";
            label3.Click += label3_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(492, 191);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(75, 23);
            buttonSub.TabIndex = 9;
            buttonSub.Text = "minus time";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSub);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTime);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSet);
            Controls.Add(textBoxS);
            Controls.Add(textBoxM);
            Controls.Add(textBoxH);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxH;
        private TextBox textBoxM;
        private TextBox textBoxS;
        private Button buttonSet;
        private Button buttonAdd;
        private Label labelTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSub;
    }
}
