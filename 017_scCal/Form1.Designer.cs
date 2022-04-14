namespace _017_scCal
{
    partial class 성적계산기
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
            this.성적입력 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tEng = new System.Windows.Forms.TextBox();
            this.tMat = new System.Windows.Forms.TextBox();
            this.tKor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tAve = new System.Windows.Forms.TextBox();
            this.tSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.성적입력.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 성적입력
            // 
            this.성적입력.Controls.Add(this.label3);
            this.성적입력.Controls.Add(this.label2);
            this.성적입력.Controls.Add(this.label1);
            this.성적입력.Controls.Add(this.tEng);
            this.성적입력.Controls.Add(this.tMat);
            this.성적입력.Controls.Add(this.tKor);
            this.성적입력.Location = new System.Drawing.Point(42, 38);
            this.성적입력.Name = "성적입력";
            this.성적입력.Size = new System.Drawing.Size(218, 168);
            this.성적입력.TabIndex = 0;
            this.성적입력.TabStop = false;
            this.성적입력.Text = "성적입력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "영어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "수학";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "국어";
            // 
            // tEng
            // 
            this.tEng.Location = new System.Drawing.Point(100, 132);
            this.tEng.Name = "tEng";
            this.tEng.Size = new System.Drawing.Size(100, 25);
            this.tEng.TabIndex = 2;
            this.tEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tMat
            // 
            this.tMat.Location = new System.Drawing.Point(100, 83);
            this.tMat.Name = "tMat";
            this.tMat.Size = new System.Drawing.Size(100, 25);
            this.tMat.TabIndex = 1;
            this.tMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tKor
            // 
            this.tKor.Location = new System.Drawing.Point(100, 31);
            this.tKor.Name = "tKor";
            this.tKor.Size = new System.Drawing.Size(100, 25);
            this.tKor.TabIndex = 0;
            this.tKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tAve);
            this.groupBox1.Controls.Add(this.tSum);
            this.groupBox1.Location = new System.Drawing.Point(305, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "평균";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "총점";
            // 
            // tAve
            // 
            this.tAve.Location = new System.Drawing.Point(100, 83);
            this.tAve.Name = "tAve";
            this.tAve.Size = new System.Drawing.Size(100, 25);
            this.tAve.TabIndex = 1;
            this.tAve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSum
            // 
            this.tSum.Location = new System.Drawing.Point(100, 31);
            this.tSum.Name = "tSum";
            this.tSum.Size = new System.Drawing.Size(100, 25);
            this.tSum.TabIndex = 0;
            this.tSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 성적계산기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.성적입력);
            this.Name = "성적계산기";
            this.Text = "성적계산기";
            this.Load += new System.EventHandler(this.성적계산기_Load);
            this.성적입력.ResumeLayout(false);
            this.성적입력.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 성적입력;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tEng;
        private System.Windows.Forms.TextBox tMat;
        private System.Windows.Forms.TextBox tKor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tAve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tSum;
    }
}

