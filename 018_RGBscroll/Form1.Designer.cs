namespace _018_RGBscroll
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.scR = new System.Windows.Forms.HScrollBar();
            this.tRed = new System.Windows.Forms.TextBox();
            this.tGre = new System.Windows.Forms.TextBox();
            this.scG = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tBlu = new System.Windows.Forms.TextBox();
            this.scB = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 177);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // scR
            // 
            this.scR.Location = new System.Drawing.Point(82, 259);
            this.scR.Name = "scR";
            this.scR.Size = new System.Drawing.Size(560, 27);
            this.scR.TabIndex = 4;
            this.scR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // tRed
            // 
            this.tRed.Location = new System.Drawing.Point(667, 259);
            this.tRed.Name = "tRed";
            this.tRed.Size = new System.Drawing.Size(100, 25);
            this.tRed.TabIndex = 5;
            this.tRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tRed.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // tGre
            // 
            this.tGre.Location = new System.Drawing.Point(667, 317);
            this.tGre.Name = "tGre";
            this.tGre.Size = new System.Drawing.Size(100, 25);
            this.tGre.TabIndex = 8;
            this.tGre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tGre.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // scG
            // 
            this.scG.Location = new System.Drawing.Point(82, 317);
            this.scG.Name = "scG";
            this.scG.Size = new System.Drawing.Size(560, 27);
            this.scG.TabIndex = 7;
            this.scG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green";
            // 
            // tBlu
            // 
            this.tBlu.Location = new System.Drawing.Point(667, 369);
            this.tBlu.Name = "tBlu";
            this.tBlu.Size = new System.Drawing.Size(100, 25);
            this.tBlu.TabIndex = 11;
            this.tBlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBlu.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // scB
            // 
            this.scB.Location = new System.Drawing.Point(82, 369);
            this.scB.Name = "scB";
            this.scB.Size = new System.Drawing.Size(560, 27);
            this.scB.TabIndex = 10;
            this.scB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 427);
            this.Controls.Add(this.tBlu);
            this.Controls.Add(this.scB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tGre);
            this.Controls.Add(this.scG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tRed);
            this.Controls.Add(this.scR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar scR;
        private System.Windows.Forms.TextBox tRed;
        private System.Windows.Forms.TextBox tGre;
        private System.Windows.Forms.HScrollBar scG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBlu;
        private System.Windows.Forms.HScrollBar scB;
        private System.Windows.Forms.Label label3;
    }
}

