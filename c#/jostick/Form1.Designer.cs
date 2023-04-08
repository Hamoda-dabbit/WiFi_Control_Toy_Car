namespace jostick
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtuup = new System.Windows.Forms.TextBox();
            this.txtdown = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnFarward = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(830, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtuup
            // 
            this.txtuup.Location = new System.Drawing.Point(706, 129);
            this.txtuup.Name = "txtuup";
            this.txtuup.Size = new System.Drawing.Size(43, 20);
            this.txtuup.TabIndex = 3;
            // 
            // txtdown
            // 
            this.txtdown.Location = new System.Drawing.Point(706, 170);
            this.txtdown.Name = "txtdown";
            this.txtdown.Size = new System.Drawing.Size(43, 20);
            this.txtdown.TabIndex = 4;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(755, 148);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(43, 20);
            this.txtr.TabIndex = 5;
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(657, 148);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(43, 20);
            this.txtl.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(305, 226);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(337, 57);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(270, 20);
            this.txtip.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(97, 79);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 17;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(158, 50);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 16;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(42, 50);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 15;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnFarward
            // 
            this.btnFarward.Location = new System.Drawing.Point(97, 21);
            this.btnFarward.Name = "btnFarward";
            this.btnFarward.Size = new System.Drawing.Size(75, 23);
            this.btnFarward.TabIndex = 14;
            this.btnFarward.Text = "^";
            this.btnFarward.UseVisualStyleBackColor = true;
            this.btnFarward.Click += new System.EventHandler(this.btnFarward_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(657, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnFarward);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(337, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 130);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 283);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtdown);
            this.Controls.Add(this.txtuup);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtuup;
        private System.Windows.Forms.TextBox txtdown;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnFarward;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

