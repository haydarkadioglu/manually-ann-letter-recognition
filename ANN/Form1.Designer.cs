namespace ANN
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
            this.label_resE = new System.Windows.Forms.Label();
            this.label_resD = new System.Windows.Forms.Label();
            this.label_resC = new System.Windows.Forms.Label();
            this.label_resB = new System.Windows.Forms.Label();
            this.label_resA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_predict = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_train = new System.Windows.Forms.Button();
            this.textBox_epoch = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_resE);
            this.groupBox2.Controls.Add(this.label_resD);
            this.groupBox2.Controls.Add(this.label_resC);
            this.groupBox2.Controls.Add(this.label_resB);
            this.groupBox2.Controls.Add(this.label_resA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(258, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label_resE
            // 
            this.label_resE.AutoSize = true;
            this.label_resE.Location = new System.Drawing.Point(58, 159);
            this.label_resE.Name = "label_resE";
            this.label_resE.Size = new System.Drawing.Size(0, 16);
            this.label_resE.TabIndex = 9;
            // 
            // label_resD
            // 
            this.label_resD.AutoSize = true;
            this.label_resD.Location = new System.Drawing.Point(58, 133);
            this.label_resD.Name = "label_resD";
            this.label_resD.Size = new System.Drawing.Size(0, 16);
            this.label_resD.TabIndex = 8;
            // 
            // label_resC
            // 
            this.label_resC.AutoSize = true;
            this.label_resC.Location = new System.Drawing.Point(58, 98);
            this.label_resC.Name = "label_resC";
            this.label_resC.Size = new System.Drawing.Size(0, 16);
            this.label_resC.TabIndex = 7;
            // 
            // label_resB
            // 
            this.label_resB.AutoSize = true;
            this.label_resB.Location = new System.Drawing.Point(58, 68);
            this.label_resB.Name = "label_resB";
            this.label_resB.Size = new System.Drawing.Size(0, 16);
            this.label_resB.TabIndex = 6;
            // 
            // label_resA
            // 
            this.label_resA.AutoSize = true;
            this.label_resA.Location = new System.Drawing.Point(58, 40);
            this.label_resA.Name = "label_resA";
            this.label_resA.Size = new System.Drawing.Size(0, 16);
            this.label_resA.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "E = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "D = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "C = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "B = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A = ";
            // 
            // button_predict
            // 
            this.button_predict.Location = new System.Drawing.Point(12, 317);
            this.button_predict.Name = "button_predict";
            this.button_predict.Size = new System.Drawing.Size(116, 29);
            this.button_predict.TabIndex = 2;
            this.button_predict.Text = "Predict";
            this.button_predict.UseVisualStyleBackColor = true;
            this.button_predict.Click += new System.EventHandler(this.button_predict_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 352);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(116, 31);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_train
            // 
            this.button_train.Location = new System.Drawing.Point(12, 389);
            this.button_train.Name = "button_train";
            this.button_train.Size = new System.Drawing.Size(116, 32);
            this.button_train.TabIndex = 4;
            this.button_train.Text = "Train";
            this.button_train.UseVisualStyleBackColor = true;
            this.button_train.Click += new System.EventHandler(this.button_train_Click);
            // 
            // textBox_epoch
            // 
            this.textBox_epoch.Location = new System.Drawing.Point(12, 427);
            this.textBox_epoch.Name = "textBox_epoch";
            this.textBox_epoch.Size = new System.Drawing.Size(116, 22);
            this.textBox_epoch.TabIndex = 5;
            this.textBox_epoch.Text = "EPOCHS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 533);
            this.Controls.Add(this.textBox_epoch);
            this.Controls.Add(this.button_train);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_predict);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_predict;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_train;
        private System.Windows.Forms.Label label_resC;
        private System.Windows.Forms.Label label_resB;
        private System.Windows.Forms.Label label_resA;
        private System.Windows.Forms.Label label_resE;
        private System.Windows.Forms.Label label_resD;
        private System.Windows.Forms.TextBox textBox_epoch;
    }
}

