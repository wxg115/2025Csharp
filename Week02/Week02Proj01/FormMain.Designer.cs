namespace Week02Proj01
{
    partial class FormMain
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
            this.tbxInput1 = new System.Windows.Forms.TextBox();
            this.tbxInput2 = new System.Windows.Forms.TextBox();
            this.tbxInput3 = new System.Windows.Forms.TextBox();
            this.tbxInput4 = new System.Windows.Forms.TextBox();
            this.tbxInput5 = new System.Windows.Forms.TextBox();
            this.btnOutput03 = new System.Windows.Forms.Button();
            this.btnOutput04 = new System.Windows.Forms.Button();
            this.btnOutput01 = new System.Windows.Forms.Button();
            this.btnOutput02 = new System.Windows.Forms.Button();
            this.btnOutput05 = new System.Windows.Forms.Button();
            this.btnOutput08 = new System.Windows.Forms.Button();
            this.btnOutput09 = new System.Windows.Forms.Button();
            this.btnOutput10 = new System.Windows.Forms.Button();
            this.btnOutput06 = new System.Windows.Forms.Button();
            this.btnOutput07 = new System.Windows.Forms.Button();
            this.btnOutput13 = new System.Windows.Forms.Button();
            this.btnOutput14 = new System.Windows.Forms.Button();
            this.btnOutput15 = new System.Windows.Forms.Button();
            this.btnOutput11 = new System.Windows.Forms.Button();
            this.btnOutput12 = new System.Windows.Forms.Button();
            this.chkToggle = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxInput1
            // 
            this.tbxInput1.Location = new System.Drawing.Point(12, 12);
            this.tbxInput1.Name = "tbxInput1";
            this.tbxInput1.Size = new System.Drawing.Size(100, 21);
            this.tbxInput1.TabIndex = 0;
            this.tbxInput1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxInput2
            // 
            this.tbxInput2.Location = new System.Drawing.Point(118, 12);
            this.tbxInput2.Name = "tbxInput2";
            this.tbxInput2.Size = new System.Drawing.Size(100, 21);
            this.tbxInput2.TabIndex = 0;
            this.tbxInput2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxInput3
            // 
            this.tbxInput3.Location = new System.Drawing.Point(224, 12);
            this.tbxInput3.Name = "tbxInput3";
            this.tbxInput3.Size = new System.Drawing.Size(100, 21);
            this.tbxInput3.TabIndex = 0;
            this.tbxInput3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxInput4
            // 
            this.tbxInput4.Location = new System.Drawing.Point(330, 12);
            this.tbxInput4.Name = "tbxInput4";
            this.tbxInput4.Size = new System.Drawing.Size(100, 21);
            this.tbxInput4.TabIndex = 0;
            this.tbxInput4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxInput5
            // 
            this.tbxInput5.Location = new System.Drawing.Point(436, 12);
            this.tbxInput5.Name = "tbxInput5";
            this.tbxInput5.Size = new System.Drawing.Size(100, 21);
            this.tbxInput5.TabIndex = 1;
            // 
            // btnOutput03
            // 
            this.btnOutput03.Location = new System.Drawing.Point(224, 39);
            this.btnOutput03.Name = "btnOutput03";
            this.btnOutput03.Size = new System.Drawing.Size(100, 23);
            this.btnOutput03.TabIndex = 2;
            this.btnOutput03.Text = "가감 3";
            this.btnOutput03.UseVisualStyleBackColor = true;
            this.btnOutput03.Click += new System.EventHandler(this.btnOutput03_Click);
            // 
            // btnOutput04
            // 
            this.btnOutput04.Location = new System.Drawing.Point(330, 39);
            this.btnOutput04.Name = "btnOutput04";
            this.btnOutput04.Size = new System.Drawing.Size(100, 23);
            this.btnOutput04.TabIndex = 2;
            this.btnOutput04.Text = "가감 4";
            this.btnOutput04.UseVisualStyleBackColor = true;
            this.btnOutput04.Click += new System.EventHandler(this.btnOutput04_Click);
            // 
            // btnOutput01
            // 
            this.btnOutput01.Location = new System.Drawing.Point(12, 39);
            this.btnOutput01.Name = "btnOutput01";
            this.btnOutput01.Size = new System.Drawing.Size(100, 23);
            this.btnOutput01.TabIndex = 2;
            this.btnOutput01.Text = "가감 1";
            this.btnOutput01.UseVisualStyleBackColor = true;
            this.btnOutput01.Click += new System.EventHandler(this.btnOutput01_Click);
            // 
            // btnOutput02
            // 
            this.btnOutput02.Location = new System.Drawing.Point(118, 39);
            this.btnOutput02.Name = "btnOutput02";
            this.btnOutput02.Size = new System.Drawing.Size(100, 23);
            this.btnOutput02.TabIndex = 2;
            this.btnOutput02.Text = "가감 2";
            this.btnOutput02.UseVisualStyleBackColor = true;
            this.btnOutput02.Click += new System.EventHandler(this.btnOutput02_Click);
            // 
            // btnOutput05
            // 
            this.btnOutput05.Location = new System.Drawing.Point(436, 39);
            this.btnOutput05.Name = "btnOutput05";
            this.btnOutput05.Size = new System.Drawing.Size(100, 23);
            this.btnOutput05.TabIndex = 2;
            this.btnOutput05.Text = "문자와 문자열";
            this.btnOutput05.UseVisualStyleBackColor = true;
            this.btnOutput05.Click += new System.EventHandler(this.btnOutput05_Click);
            // 
            // btnOutput08
            // 
            this.btnOutput08.Location = new System.Drawing.Point(224, 68);
            this.btnOutput08.Name = "btnOutput08";
            this.btnOutput08.Size = new System.Drawing.Size(100, 23);
            this.btnOutput08.TabIndex = 2;
            this.btnOutput08.UseVisualStyleBackColor = true;
            // 
            // btnOutput09
            // 
            this.btnOutput09.Location = new System.Drawing.Point(330, 68);
            this.btnOutput09.Name = "btnOutput09";
            this.btnOutput09.Size = new System.Drawing.Size(100, 23);
            this.btnOutput09.TabIndex = 2;
            this.btnOutput09.UseVisualStyleBackColor = true;
            // 
            // btnOutput10
            // 
            this.btnOutput10.Location = new System.Drawing.Point(436, 68);
            this.btnOutput10.Name = "btnOutput10";
            this.btnOutput10.Size = new System.Drawing.Size(100, 23);
            this.btnOutput10.TabIndex = 2;
            this.btnOutput10.UseVisualStyleBackColor = true;
            // 
            // btnOutput06
            // 
            this.btnOutput06.Location = new System.Drawing.Point(12, 68);
            this.btnOutput06.Name = "btnOutput06";
            this.btnOutput06.Size = new System.Drawing.Size(100, 23);
            this.btnOutput06.TabIndex = 2;
            this.btnOutput06.Text = "형 변환";
            this.btnOutput06.UseVisualStyleBackColor = true;
            this.btnOutput06.Click += new System.EventHandler(this.btnOutput06_Click);
            // 
            // btnOutput07
            // 
            this.btnOutput07.Location = new System.Drawing.Point(118, 68);
            this.btnOutput07.Name = "btnOutput07";
            this.btnOutput07.Size = new System.Drawing.Size(100, 23);
            this.btnOutput07.TabIndex = 2;
            this.btnOutput07.UseVisualStyleBackColor = true;
            // 
            // btnOutput13
            // 
            this.btnOutput13.Location = new System.Drawing.Point(224, 97);
            this.btnOutput13.Name = "btnOutput13";
            this.btnOutput13.Size = new System.Drawing.Size(100, 23);
            this.btnOutput13.TabIndex = 2;
            this.btnOutput13.UseVisualStyleBackColor = true;
            // 
            // btnOutput14
            // 
            this.btnOutput14.Location = new System.Drawing.Point(330, 97);
            this.btnOutput14.Name = "btnOutput14";
            this.btnOutput14.Size = new System.Drawing.Size(100, 23);
            this.btnOutput14.TabIndex = 2;
            this.btnOutput14.UseVisualStyleBackColor = true;
            // 
            // btnOutput15
            // 
            this.btnOutput15.Location = new System.Drawing.Point(436, 97);
            this.btnOutput15.Name = "btnOutput15";
            this.btnOutput15.Size = new System.Drawing.Size(100, 23);
            this.btnOutput15.TabIndex = 2;
            this.btnOutput15.UseVisualStyleBackColor = true;
            // 
            // btnOutput11
            // 
            this.btnOutput11.Location = new System.Drawing.Point(12, 97);
            this.btnOutput11.Name = "btnOutput11";
            this.btnOutput11.Size = new System.Drawing.Size(100, 23);
            this.btnOutput11.TabIndex = 2;
            this.btnOutput11.UseVisualStyleBackColor = true;
            // 
            // btnOutput12
            // 
            this.btnOutput12.Location = new System.Drawing.Point(118, 97);
            this.btnOutput12.Name = "btnOutput12";
            this.btnOutput12.Size = new System.Drawing.Size(100, 23);
            this.btnOutput12.TabIndex = 2;
            this.btnOutput12.UseVisualStyleBackColor = true;
            // 
            // chkToggle
            // 
            this.chkToggle.AutoSize = true;
            this.chkToggle.Location = new System.Drawing.Point(542, 14);
            this.chkToggle.Name = "chkToggle";
            this.chkToggle.Size = new System.Drawing.Size(15, 14);
            this.chkToggle.TabIndex = 3;
            this.chkToggle.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(13, 127);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(775, 314);
            this.lblResult.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkToggle);
            this.Controls.Add(this.btnOutput12);
            this.Controls.Add(this.btnOutput07);
            this.Controls.Add(this.btnOutput02);
            this.Controls.Add(this.btnOutput11);
            this.Controls.Add(this.btnOutput15);
            this.Controls.Add(this.btnOutput06);
            this.Controls.Add(this.btnOutput10);
            this.Controls.Add(this.btnOutput14);
            this.Controls.Add(this.btnOutput01);
            this.Controls.Add(this.btnOutput09);
            this.Controls.Add(this.btnOutput13);
            this.Controls.Add(this.btnOutput05);
            this.Controls.Add(this.btnOutput08);
            this.Controls.Add(this.btnOutput04);
            this.Controls.Add(this.btnOutput03);
            this.Controls.Add(this.tbxInput5);
            this.Controls.Add(this.tbxInput4);
            this.Controls.Add(this.tbxInput2);
            this.Controls.Add(this.tbxInput3);
            this.Controls.Add(this.tbxInput1);
            this.Name = "FormMain";
            this.Text = "2주차";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput1;
        private System.Windows.Forms.TextBox tbxInput2;
        private System.Windows.Forms.TextBox tbxInput3;
        private System.Windows.Forms.TextBox tbxInput4;
        private System.Windows.Forms.TextBox tbxInput5;
        private System.Windows.Forms.Button btnOutput03;
        private System.Windows.Forms.Button btnOutput04;
        private System.Windows.Forms.Button btnOutput01;
        private System.Windows.Forms.Button btnOutput02;
        private System.Windows.Forms.Button btnOutput05;
        private System.Windows.Forms.Button btnOutput08;
        private System.Windows.Forms.Button btnOutput09;
        private System.Windows.Forms.Button btnOutput10;
        private System.Windows.Forms.Button btnOutput06;
        private System.Windows.Forms.Button btnOutput07;
        private System.Windows.Forms.Button btnOutput13;
        private System.Windows.Forms.Button btnOutput14;
        private System.Windows.Forms.Button btnOutput15;
        private System.Windows.Forms.Button btnOutput11;
        private System.Windows.Forms.Button btnOutput12;
        private System.Windows.Forms.CheckBox chkToggle;
        private System.Windows.Forms.Label lblResult;
    }
}

