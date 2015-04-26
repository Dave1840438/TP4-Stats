namespace TP4_Loi_Normale
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
            this.TBX_Moyenne = new System.Windows.Forms.TextBox();
            this.GBX_Problemes = new System.Windows.Forms.GroupBox();
            this.RBTN_BetweenTwo = new System.Windows.Forms.RadioButton();
            this.RBTN_BiggerThanA = new System.Windows.Forms.RadioButton();
            this.RBTN_LessThanA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_EcartType = new System.Windows.Forms.TextBox();
            this.TBX_A = new System.Windows.Forms.TextBox();
            this.TBX_B = new System.Windows.Forms.TextBox();
            this.LBL_b = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_Result = new System.Windows.Forms.Label();
            this.BTN_Solve = new System.Windows.Forms.Button();
            this.GBX_Problemes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBX_Moyenne
            // 
            this.TBX_Moyenne.Location = new System.Drawing.Point(300, 29);
            this.TBX_Moyenne.Name = "TBX_Moyenne";
            this.TBX_Moyenne.Size = new System.Drawing.Size(100, 20);
            this.TBX_Moyenne.TabIndex = 1;
            this.TBX_Moyenne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Filter);
            // 
            // GBX_Problemes
            // 
            this.GBX_Problemes.Controls.Add(this.RBTN_BetweenTwo);
            this.GBX_Problemes.Controls.Add(this.RBTN_BiggerThanA);
            this.GBX_Problemes.Controls.Add(this.RBTN_LessThanA);
            this.GBX_Problemes.Location = new System.Drawing.Point(27, 12);
            this.GBX_Problemes.Name = "GBX_Problemes";
            this.GBX_Problemes.Size = new System.Drawing.Size(200, 100);
            this.GBX_Problemes.TabIndex = 2;
            this.GBX_Problemes.TabStop = false;
            this.GBX_Problemes.Text = "Problème à résoudre";
            // 
            // RBTN_BetweenTwo
            // 
            this.RBTN_BetweenTwo.AutoSize = true;
            this.RBTN_BetweenTwo.Location = new System.Drawing.Point(24, 68);
            this.RBTN_BetweenTwo.Name = "RBTN_BetweenTwo";
            this.RBTN_BetweenTwo.Size = new System.Drawing.Size(81, 17);
            this.RBTN_BetweenTwo.TabIndex = 2;
            this.RBTN_BetweenTwo.Text = "P(a < X < b)";
            this.RBTN_BetweenTwo.UseVisualStyleBackColor = true;
            this.RBTN_BetweenTwo.CheckedChanged += new System.EventHandler(this.RBTN_BetweenTwo_CheckedChanged);
            // 
            // RBTN_BiggerThanA
            // 
            this.RBTN_BiggerThanA.AutoSize = true;
            this.RBTN_BiggerThanA.Location = new System.Drawing.Point(24, 44);
            this.RBTN_BiggerThanA.Name = "RBTN_BiggerThanA";
            this.RBTN_BiggerThanA.Size = new System.Drawing.Size(63, 17);
            this.RBTN_BiggerThanA.TabIndex = 1;
            this.RBTN_BiggerThanA.Text = "P(X > a)";
            this.RBTN_BiggerThanA.UseVisualStyleBackColor = true;
            // 
            // RBTN_LessThanA
            // 
            this.RBTN_LessThanA.AutoSize = true;
            this.RBTN_LessThanA.Checked = true;
            this.RBTN_LessThanA.Location = new System.Drawing.Point(24, 20);
            this.RBTN_LessThanA.Name = "RBTN_LessThanA";
            this.RBTN_LessThanA.Size = new System.Drawing.Size(63, 17);
            this.RBTN_LessThanA.TabIndex = 0;
            this.RBTN_LessThanA.TabStop = true;
            this.RBTN_LessThanA.Text = "P(X < a)";
            this.RBTN_LessThanA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Moyenne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Écart type :";
            // 
            // TBX_EcartType
            // 
            this.TBX_EcartType.Location = new System.Drawing.Point(300, 70);
            this.TBX_EcartType.Name = "TBX_EcartType";
            this.TBX_EcartType.Size = new System.Drawing.Size(100, 20);
            this.TBX_EcartType.TabIndex = 5;
            this.TBX_EcartType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Filter);
            // 
            // TBX_A
            // 
            this.TBX_A.Location = new System.Drawing.Point(51, 127);
            this.TBX_A.Name = "TBX_A";
            this.TBX_A.Size = new System.Drawing.Size(100, 20);
            this.TBX_A.TabIndex = 6;
            this.TBX_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Filter);
            // 
            // TBX_B
            // 
            this.TBX_B.Location = new System.Drawing.Point(182, 127);
            this.TBX_B.Name = "TBX_B";
            this.TBX_B.Size = new System.Drawing.Size(100, 20);
            this.TBX_B.TabIndex = 7;
            this.TBX_B.Visible = false;
            this.TBX_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Filter);
            // 
            // LBL_b
            // 
            this.LBL_b.AutoSize = true;
            this.LBL_b.Location = new System.Drawing.Point(157, 131);
            this.LBL_b.Name = "LBL_b";
            this.LBL_b.Size = new System.Drawing.Size(19, 13);
            this.LBL_b.TabIndex = 8;
            this.LBL_b.Text = "b :";
            this.LBL_b.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "a :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Résultat :";
            // 
            // LBL_Result
            // 
            this.LBL_Result.AutoSize = true;
            this.LBL_Result.Location = new System.Drawing.Point(79, 174);
            this.LBL_Result.Name = "LBL_Result";
            this.LBL_Result.Size = new System.Drawing.Size(0, 13);
            this.LBL_Result.TabIndex = 11;
            // 
            // BTN_Solve
            // 
            this.BTN_Solve.Location = new System.Drawing.Point(27, 200);
            this.BTN_Solve.Name = "BTN_Solve";
            this.BTN_Solve.Size = new System.Drawing.Size(75, 23);
            this.BTN_Solve.TabIndex = 12;
            this.BTN_Solve.Text = "Résoudre";
            this.BTN_Solve.UseVisualStyleBackColor = true;
            this.BTN_Solve.Click += new System.EventHandler(this.CalculerProabilite);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 294);
            this.Controls.Add(this.BTN_Solve);
            this.Controls.Add(this.LBL_Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_b);
            this.Controls.Add(this.TBX_B);
            this.Controls.Add(this.TBX_A);
            this.Controls.Add(this.TBX_EcartType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GBX_Problemes);
            this.Controls.Add(this.TBX_Moyenne);
            this.Name = "Form1";
            this.Text = "La loi normale";
            this.GBX_Problemes.ResumeLayout(false);
            this.GBX_Problemes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Moyenne;
        private System.Windows.Forms.GroupBox GBX_Problemes;
        private System.Windows.Forms.RadioButton RBTN_BetweenTwo;
        private System.Windows.Forms.RadioButton RBTN_BiggerThanA;
        private System.Windows.Forms.RadioButton RBTN_LessThanA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_EcartType;
        private System.Windows.Forms.TextBox TBX_A;
        private System.Windows.Forms.TextBox TBX_B;
        private System.Windows.Forms.Label LBL_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_Result;
        private System.Windows.Forms.Button BTN_Solve;
    }
}

