namespace Proj_Financial_202444071
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
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSetYearYear = new System.Windows.Forms.TextBox();
            this.tbxSetYearTargetAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetYearNewReset = new System.Windows.Forms.Button();
            this.btnSetYearSave = new System.Windows.Forms.Button();
            this.btnSetYearLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxSetIncomeYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxSetIncomeDetails = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSetIncomeAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxSetIncomeMonth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxSetIncomeDay = new System.Windows.Forms.TextBox();
            this.btnSetIncome = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetExpenditure = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxSetExpenditureDay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxSetExpenditureMonth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxSetExpenditureAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxSetExpenditureDetails = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxSetExpenditureYear = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSetNowIncome = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.tbxSetNowAmount = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbxSetNowDetails = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSetNowExpenditure = new System.Windows.Forms.Button();
            this.lbxIncome = new System.Windows.Forms.ListBox();
            this.lbxExpenditure = new System.Windows.Forms.ListBox();
            this.lbxAll = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(788, 499);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(23, 282);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 215);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxIncome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "수입 내역";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxExpenditure);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "지출 내역";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbxAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(886, 189);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "전체 내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetYearLoad);
            this.groupBox1.Controls.Add(this.btnSetYearSave);
            this.groupBox1.Controls.Add(this.btnSetYearNewReset);
            this.groupBox1.Controls.Add(this.tbxSetYearTargetAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxSetYearYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "연도 설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "연도:";
            // 
            // tbxSetYearYear
            // 
            this.tbxSetYearYear.Location = new System.Drawing.Point(78, 20);
            this.tbxSetYearYear.Name = "tbxSetYearYear";
            this.tbxSetYearYear.Size = new System.Drawing.Size(100, 21);
            this.tbxSetYearYear.TabIndex = 1;
            // 
            // tbxSetYearTargetAmount
            // 
            this.tbxSetYearTargetAmount.Location = new System.Drawing.Point(78, 57);
            this.tbxSetYearTargetAmount.Name = "tbxSetYearTargetAmount";
            this.tbxSetYearTargetAmount.Size = new System.Drawing.Size(129, 21);
            this.tbxSetYearTargetAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "목표액:";
            // 
            // btnSetYearNewReset
            // 
            this.btnSetYearNewReset.Location = new System.Drawing.Point(256, 20);
            this.btnSetYearNewReset.Name = "btnSetYearNewReset";
            this.btnSetYearNewReset.Size = new System.Drawing.Size(191, 23);
            this.btnSetYearNewReset.TabIndex = 4;
            this.btnSetYearNewReset.Text = "신규(초기화)";
            this.btnSetYearNewReset.UseVisualStyleBackColor = true;
            this.btnSetYearNewReset.Click += new System.EventHandler(this.btnSetYearNewReset_Click);
            // 
            // btnSetYearSave
            // 
            this.btnSetYearSave.Location = new System.Drawing.Point(256, 55);
            this.btnSetYearSave.Name = "btnSetYearSave";
            this.btnSetYearSave.Size = new System.Drawing.Size(99, 23);
            this.btnSetYearSave.TabIndex = 5;
            this.btnSetYearSave.Text = "저장하기";
            this.btnSetYearSave.UseVisualStyleBackColor = true;
            this.btnSetYearSave.Click += new System.EventHandler(this.btnSetYearSave_Click);
            // 
            // btnSetYearLoad
            // 
            this.btnSetYearLoad.Location = new System.Drawing.Point(355, 55);
            this.btnSetYearLoad.Name = "btnSetYearLoad";
            this.btnSetYearLoad.Size = new System.Drawing.Size(92, 23);
            this.btnSetYearLoad.TabIndex = 6;
            this.btnSetYearLoad.Text = "불러오기";
            this.btnSetYearLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(494, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "현재 상태";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "총 수입: 0원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "총 지출: 0원";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "잔액: 0원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "상태: 흑자";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetIncome);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbxSetIncomeDay);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbxSetIncomeMonth);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbxSetIncomeAmount);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbxSetIncomeDetails);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbxSetIncomeYear);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(23, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 147);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수입 등록";
            // 
            // tbxSetIncomeYear
            // 
            this.tbxSetIncomeYear.Location = new System.Drawing.Point(56, 29);
            this.tbxSetIncomeYear.Name = "tbxSetIncomeYear";
            this.tbxSetIncomeYear.Size = new System.Drawing.Size(62, 21);
            this.tbxSetIncomeYear.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "날짜:";
            // 
            // tbxSetIncomeDetails
            // 
            this.tbxSetIncomeDetails.Location = new System.Drawing.Point(56, 56);
            this.tbxSetIncomeDetails.Name = "tbxSetIncomeDetails";
            this.tbxSetIncomeDetails.Size = new System.Drawing.Size(222, 21);
            this.tbxSetIncomeDetails.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "내역:";
            // 
            // tbxSetIncomeAmount
            // 
            this.tbxSetIncomeAmount.Location = new System.Drawing.Point(56, 83);
            this.tbxSetIncomeAmount.Name = "tbxSetIncomeAmount";
            this.tbxSetIncomeAmount.Size = new System.Drawing.Size(151, 21);
            this.tbxSetIncomeAmount.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "금액:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "원";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "년";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "월";
            // 
            // tbxSetIncomeMonth
            // 
            this.tbxSetIncomeMonth.Location = new System.Drawing.Point(144, 29);
            this.tbxSetIncomeMonth.Name = "tbxSetIncomeMonth";
            this.tbxSetIncomeMonth.Size = new System.Drawing.Size(34, 21);
            this.tbxSetIncomeMonth.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "일";
            // 
            // tbxSetIncomeDay
            // 
            this.tbxSetIncomeDay.Location = new System.Drawing.Point(207, 29);
            this.tbxSetIncomeDay.Name = "tbxSetIncomeDay";
            this.tbxSetIncomeDay.Size = new System.Drawing.Size(34, 21);
            this.tbxSetIncomeDay.TabIndex = 14;
            // 
            // btnSetIncome
            // 
            this.btnSetIncome.Location = new System.Drawing.Point(56, 110);
            this.btnSetIncome.Name = "btnSetIncome";
            this.btnSetIncome.Size = new System.Drawing.Size(161, 23);
            this.btnSetIncome.TabIndex = 7;
            this.btnSetIncome.Text = "수입 등록";
            this.btnSetIncome.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSetExpenditure);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbxSetExpenditureDay);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbxSetExpenditureMonth);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.tbxSetExpenditureAmount);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.tbxSetExpenditureDetails);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.tbxSetExpenditureYear);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(323, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 147);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "지출 등록";
            // 
            // btnSetExpenditure
            // 
            this.btnSetExpenditure.Location = new System.Drawing.Point(56, 110);
            this.btnSetExpenditure.Name = "btnSetExpenditure";
            this.btnSetExpenditure.Size = new System.Drawing.Size(161, 23);
            this.btnSetExpenditure.TabIndex = 7;
            this.btnSetExpenditure.Text = "지출 등록";
            this.btnSetExpenditure.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "일";
            // 
            // tbxSetExpenditureDay
            // 
            this.tbxSetExpenditureDay.Location = new System.Drawing.Point(207, 29);
            this.tbxSetExpenditureDay.Name = "tbxSetExpenditureDay";
            this.tbxSetExpenditureDay.Size = new System.Drawing.Size(34, 21);
            this.tbxSetExpenditureDay.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(184, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 13;
            this.label15.Text = "월";
            // 
            // tbxSetExpenditureMonth
            // 
            this.tbxSetExpenditureMonth.Location = new System.Drawing.Point(144, 29);
            this.tbxSetExpenditureMonth.Name = "tbxSetExpenditureMonth";
            this.tbxSetExpenditureMonth.Size = new System.Drawing.Size(34, 21);
            this.tbxSetExpenditureMonth.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(124, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "년";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(213, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "원";
            // 
            // tbxSetExpenditureAmount
            // 
            this.tbxSetExpenditureAmount.Location = new System.Drawing.Point(56, 83);
            this.tbxSetExpenditureAmount.Name = "tbxSetExpenditureAmount";
            this.tbxSetExpenditureAmount.Size = new System.Drawing.Size(151, 21);
            this.tbxSetExpenditureAmount.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "금액:";
            // 
            // tbxSetExpenditureDetails
            // 
            this.tbxSetExpenditureDetails.Location = new System.Drawing.Point(56, 56);
            this.tbxSetExpenditureDetails.Name = "tbxSetExpenditureDetails";
            this.tbxSetExpenditureDetails.Size = new System.Drawing.Size(222, 21);
            this.tbxSetExpenditureDetails.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "내역:";
            // 
            // tbxSetExpenditureYear
            // 
            this.tbxSetExpenditureYear.Location = new System.Drawing.Point(56, 29);
            this.tbxSetExpenditureYear.Name = "tbxSetExpenditureYear";
            this.tbxSetExpenditureYear.Size = new System.Drawing.Size(62, 21);
            this.tbxSetExpenditureYear.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 12);
            this.label20.TabIndex = 4;
            this.label20.Text = "날짜:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSetNowExpenditure);
            this.groupBox5.Controls.Add(this.btnSetNowIncome);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.tbxSetNowAmount);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.tbxSetNowDetails);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Location = new System.Drawing.Point(623, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 147);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "빠른 입력(오늘 날짜)";
            // 
            // btnSetNowIncome
            // 
            this.btnSetNowIncome.Location = new System.Drawing.Point(53, 95);
            this.btnSetNowIncome.Name = "btnSetNowIncome";
            this.btnSetNowIncome.Size = new System.Drawing.Size(84, 23);
            this.btnSetNowIncome.TabIndex = 7;
            this.btnSetNowIncome.Text = "수입";
            this.btnSetNowIncome.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(210, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 12);
            this.label24.TabIndex = 10;
            this.label24.Text = "원";
            // 
            // tbxSetNowAmount
            // 
            this.tbxSetNowAmount.Location = new System.Drawing.Point(53, 68);
            this.tbxSetNowAmount.Name = "tbxSetNowAmount";
            this.tbxSetNowAmount.Size = new System.Drawing.Size(151, 21);
            this.tbxSetNowAmount.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 12);
            this.label25.TabIndex = 8;
            this.label25.Text = "금액:";
            // 
            // tbxSetNowDetails
            // 
            this.tbxSetNowDetails.Location = new System.Drawing.Point(53, 41);
            this.tbxSetNowDetails.Name = "tbxSetNowDetails";
            this.tbxSetNowDetails.Size = new System.Drawing.Size(222, 21);
            this.tbxSetNowDetails.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 44);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 12);
            this.label26.TabIndex = 6;
            this.label26.Text = "내역:";
            // 
            // btnSetNowExpenditure
            // 
            this.btnSetNowExpenditure.Location = new System.Drawing.Point(143, 95);
            this.btnSetNowExpenditure.Name = "btnSetNowExpenditure";
            this.btnSetNowExpenditure.Size = new System.Drawing.Size(84, 23);
            this.btnSetNowExpenditure.TabIndex = 11;
            this.btnSetNowExpenditure.Text = "지출";
            this.btnSetNowExpenditure.UseVisualStyleBackColor = true;
            // 
            // lbxIncome
            // 
            this.lbxIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxIncome.FormattingEnabled = true;
            this.lbxIncome.ItemHeight = 12;
            this.lbxIncome.Location = new System.Drawing.Point(3, 3);
            this.lbxIncome.Name = "lbxIncome";
            this.lbxIncome.Size = new System.Drawing.Size(880, 183);
            this.lbxIncome.TabIndex = 0;
            // 
            // lbxExpenditure
            // 
            this.lbxExpenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxExpenditure.FormattingEnabled = true;
            this.lbxExpenditure.ItemHeight = 12;
            this.lbxExpenditure.Location = new System.Drawing.Point(3, 3);
            this.lbxExpenditure.Name = "lbxExpenditure";
            this.lbxExpenditure.Size = new System.Drawing.Size(880, 183);
            this.lbxExpenditure.TabIndex = 0;
            // 
            // lbxAll
            // 
            this.lbxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAll.FormattingEnabled = true;
            this.lbxAll.ItemHeight = 12;
            this.lbxAll.Location = new System.Drawing.Point(3, 3);
            this.lbxAll.Name = "lbxAll";
            this.lbxAll.Size = new System.Drawing.Size(880, 183);
            this.lbxAll.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 542);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetYearLoad;
        private System.Windows.Forms.Button btnSetYearSave;
        private System.Windows.Forms.Button btnSetYearNewReset;
        private System.Windows.Forms.TextBox tbxSetYearTargetAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSetYearYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxSetIncomeAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxSetIncomeDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSetIncomeYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetIncome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxSetIncomeDay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxSetIncomeMonth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetExpenditure;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxSetExpenditureDay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxSetExpenditureMonth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxSetExpenditureAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxSetExpenditureDetails;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxSetExpenditureYear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSetNowExpenditure;
        private System.Windows.Forms.Button btnSetNowIncome;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbxSetNowAmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbxSetNowDetails;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListBox lbxIncome;
        private System.Windows.Forms.ListBox lbxExpenditure;
        private System.Windows.Forms.ListBox lbxAll;
    }
}

