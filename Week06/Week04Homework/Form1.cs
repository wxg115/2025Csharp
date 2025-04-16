using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager : Form
    {
        //인스턴스 필드(변수), 멤버 변수
        Department[] departments;
        List<Professor> professors;
        Dictionary<string, Student> students;

        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣어준다
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();
            
            for (int i = 1; i <= 4; i++)
            {
                cmbYear.Items.Add(i);
            }
            cmbClass.Items.AddRange(new object[] { "A", "B", "C" });

            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");
            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[]
            {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9
            };
            departments[0] = new Department()
            {
                Code = "A001",
                Name = "컴퓨터정보"
            };
            departments[1] = new Department()
            {
                Code = "A0",
                Name = "컴퓨터시스템"
            };
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] != null)
                {
                    lbxDepartment.Items.Add(departments[i]);
                }
            }
            professors.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2020001",
                Name = "김인하"
            });
            professors.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2023003",
                Name = "김정석"
            });
            professors.Add(new Professor()
            {
                DepartmentCode = departments[1].Code,
                Number = "2023004",
                Name = "이공전"
            });
            students.Add("20240001", new Student()
            {
                Number = "20240001",
                Name = "김미영",
                RegStatus = "재학",
                Year = 1,
                BirthInfo = new DateTime(2004, 01, 01),
                DepartmentCode = "A001",
                AdvisorNumber = "2020001",
                Class = "B",
                Address = "인천 남구 용현동 100",
                Contact = "032-870-0000"
            });
            foreach (var student in students)
            {
                if (student.Value != null)
                {
                    lbxDictionary.Items.Add(student.Value);
                }
            }
        }
        

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {

            //(구현)학과코드가 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다
            if (tbxDepartmentCode.Text == "")
            {
                MessageBox.Show("학과코드가 비어있습니다.");
                tbxDepartmentCode.Focus();
                return;
            }
            //(구현)학과이름이 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다
            if (tbxDepartmentName.Text == "")
            {
                MessageBox.Show("학과이름이 비어있습니다.");
                tbxDepartmentName.Focus();
                return;
            }

            int index = -1;
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] == null)
                {
                    if (index < 0)
                    {
                        index = i;
                    }
                }
                else
                {
                    if (departments[i].Code == tbxDepartmentCode.Text)
                    {
                        //(구현)동일한 코드는 사용이 불가능하다는 메시지를 띄우고 포커스 이동한다
                        MessageBox.Show("동일한 코드는 사용이 불가능합니다.");
                        return;
                    }
                }
            }

            if (index < 0)
            {
                //(구현)더 이상 신규 학과정보를 입력할 수 없을 메세지로 알린다
                MessageBox.Show("더 이상 신규 학과정보를 등록할 수 없습니다.");
                return;
            }

            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);

            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)
            {
                //(구현) 삭제할 학과를 선택하라는 메세지를 띄운다
                MessageBox.Show("삭제할 학과를 선택해주세요.");
                return;
            }

            //is 연산자, 타입 확인용으로 사용
            if (lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;

                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }
                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
                lbxDepartment.SelectedIndex = -1;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }
                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbDepartment.Items.Add(department);
                        }
                        cmbDepartment.SelectedIndex = -1;
                    }
                    cmbAdvisor.Items.Clear();
                    foreach (var professor in professors)
                    {
                        cmbAdvisor.Items.Add(professor);
                    }
                    cmbAdvisor.SelectedIndex = -1;
                    break;
                case 3:
                    //(숙제) 성적처리(TEST)의 모든 Control을 지우는 내용을 만들 것
                    ClearTestScoreInfo();
                    break;
                default:
                    break;
            }
        }

        private void ClearTestScoreInfo()
        {
            lblTestName.Text = "";
            tbxTestScore1.Text = "";
            tbxTestScore2.Text = "";
            tbxTestScore3.Text = "";
            tbxTestScore4.Text = "";
            tbxTestScore5.Text = "";
            tbxTestScore6.Text = "";
            tbxTestScore7.Text = "";
            tbxTestScore8.Text = "";
            tbxTestScore9.Text = "";
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index값 검사해서 진행여부 결정
            //(구현) 조회할 학과를 선택하라는 메세지를 띄우고 종료한다.
            //(주의)실제로 메세지 띄우는 것은 좋지 않은 것으로 보인다.
            lbxProfessor.Items.Clear();
            //as 형변환 연산자.
            //형변환이 정상적이지 않으면 null 반환.
            var department = cmbProfessorDepartment.SelectedItem as Department;
            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor != null && professor.DepartmentCode == department.Code)
                    {
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            if (tbxProfessorNumber.Text == "")
            {
                MessageBox.Show("교수번호가 비어있습니다.");
                tbxProfessorNumber.Focus();
                return;
            }
            if (tbxProfessorName.Text == "")
            {
                MessageBox.Show("교수이름이 비어있습니다.");
                tbxProfessorName.Focus();
                return;
            }
            for (int i = 0; i < professors.Count; i++)
            {
                foreach (var professor in professors)
                {
                    if (professor != null && professor.Number == tbxProfessorNumber.Text)
                    {
                        MessageBox.Show("동일한 교수번호는 사용이 불가능합니다.");
                        return;
                    }
                }
            }
            if (professors.Count >= 100)
            {
                MessageBox.Show("더 이상 신규 교수정보를 등록할 수 없습니다.");
                return;
            }

            Professor prof = new Professor();
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;
            prof.DepartmentCode = (cmbProfessorDepartment.SelectedItem as Department)?.Code;

            professors.Add(prof);
            lbxProfessor.Items.Add(prof);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 교수를 선택해주세요.");
                return;
            }
            var selectedItem = lbxProfessor.SelectedItem;
            if (lbxProfessor.SelectedItem is Professor)
            {
                var target = (Professor)lbxProfessor.SelectedItem;
                professors.Remove(target);
                lbxProfessor.Items.Remove(selectedItem);
            }
            lbxProfessor.SelectedItem = -1;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();
            var department = cmbDepartment.SelectedItem as Department;
            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor != null && professor.DepartmentCode == department.Code)
                    {
                        cmbAdvisor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();
            lbxDictionary.SelectedIndex = -1;
        }

        private void ClearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = string.Empty;
            tbxContact.Text = string.Empty;

            //(숙제)
            //tbxNumber의 읽기전용을 해제한다.
            //SelectedStudent를 초기화 한다.
            //btnRegister의 글자를 "등록"으로 설정한다.
            //lbxDictionary의 선택을 초기화 한다.
            tbxNumber.ReadOnly = false;
            selectedStudent = null;
            btnRegister.Text = "등록";
        }

        Student selectedStudent = null;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                RegisterStudent();
            }
            else
            {
                UpdateStudent(); //call
            }
        }

        private void RegisterStudent()
        {
            //(숙제)
            //학번이 비었거나 8자리가 아닌 경우 처리하지 않는다.
            //이름이 비었거나 2자 미만인 경우 처리하지 않는다.
            if (string.IsNullOrEmpty(tbxNumber.Text.Trim()) && tbxNumber.Text.Trim().Length != 8)
            {
                MessageBox.Show("학번이 잘못 입력되었습니다.");
                return;
            }
            if (string.IsNullOrEmpty(tbxName.Text.Trim()) && tbxName.Text.Trim().Length < 2)
            {
                MessageBox.Show("이름이 잘못 입력되었습니다.");
                return;
            }

            var number = tbxNumber.Text.Trim();
            //실제 많이 사용하는 방법1
            if (true == students.ContainsKey(number))
            {
                tbxNumber.Focus();
                return;
            }

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth; // , birthDay;
            if (int.TryParse(tbxBirthYear.Text, out birthYear))
            {
                //(숙제)유효숫자확인 : 1900~9000 
                if (birthYear < 1900 && birthYear > 9000)
                {
                    MessageBox.Show("생년월일이 잘못 입력되었습니다.");
                    tbxBirthYear.Focus();
                    return;
                }
            }
            else
            {
                return;
            }
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                //(숙제)유효숫자확인 : 1~12
                if (birthMonth < 1 && birthMonth > 12)
                {
                    MessageBox.Show("생년월일이 잘못 입력되었습니다.");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            else
            {
                return;
            }
            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                //(숙제)유효숫자확인 : 1~31
                if (birthDay < 1 || birthDay > 31)
                {
                    MessageBox.Show("생년월일이 잘못 입력되었습니다.");
                    tbxBirthDay.Focus();
                    return;
                }
            }
            else
            {
                return;
            }
            //현재 시간: DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                //cmbDepartment.Focus();
                //return;
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }
            //(숙제)
            //지도교수를 설정한다. 선택한 지도교수가 없으면 null처리한다. 
            //학년을 설정한다. 선택한 학년이 없으면 진행하지 않는다. 
            //반을 설정한다. 선택한 반이 없으면 진행하지 않는다. 
            //재적상태를 설정한다. 선택한 재적상태이 없으면 진행하지 않는다.
            //주소를 설정한다.
            //연락처를 설정한다.

            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            }
            else
            {
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }

            if (cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년이 선택되지 않았습니다.");
                return;
            }
            else
            {
                student.Year = (int)cmbYear.SelectedItem;
            }

            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("분반이 선택되지 않았습니다.");
                return;
            }
            else
            {
                student.Class = cmbClass.SelectedItem.ToString();
            }

            if (cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("재적상태가 선택되지 않았습니다.");
                return;
            }
            else
            {
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }

            student.Address = tbxAddress.Text;
            student.Contact = tbxContact.Text;

            students[number] = student; // 딕셔너리에 데이터 추가 방법1
            //students.Add(number, student); // 딕셔너리에 데이터 추가 방법2
            lbxDictionary.Items.Add(student);
        }

        private void UpdateStudent() //define
        {
            //(숙제)
            //수정은 학번을 고칠 수 없다.
            //학번을 제외한 모든 사항은 위의 RegisterStudent()와 동일하게 진행한다.
            //모든 사항의 확인 및 수정이 끝나면 수정완료 메세지를 띄운 후 화면을 초기화 상태로 만든다.
            if (string.IsNullOrEmpty(tbxName.Text.Trim()) && tbxName.Text.Trim().Length < 2)
            {
                MessageBox.Show("이름이 잘못 입력되었습니다.");
                return;
            }
            var number = tbxNumber.Text.Trim();
            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;
            if (int.TryParse(tbxBirthYear.Text, out birthYear))
            {
                if (birthYear < 1900 && birthYear > 9000)
                {
                    MessageBox.Show("생년월일이 잘못 입력되었습니다.");
                    tbxBirthYear.Focus();
                    return;
                }
            }
            else
            {
                return;
            }
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                if (birthMonth < 1 && birthMonth > 12)
                {
                    MessageBox.Show("생년월일이 잘못 입력되었습니다.");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            else
            {
                return;
            }
            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay < 1 && birthDay > 31)
                {
                    MessageBox.Show("생년월일이 잘못 입력되었습니다.");
                    tbxBirthDay.Focus();
                    return;
                }
            }
            else
            {
                return;
            }
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }
            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            }
            else
            {
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }

            if (cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년이 선택되지 않았습니다.");
                return;
            }
            else
            {
                student.Year = (int)cmbYear.SelectedItem;
            }

            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("분반이 선택되지 않았습니다.");
                return;
            }
            else
            {
                student.Class = cmbClass.SelectedItem.ToString();
            }

            if (cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("재적상태가 선택되지 않았습니다.");
                return;
            }
            else
            {
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }

            student.Address = tbxAddress.Text;
            student.Contact = tbxContact.Text;
            lbxDictionary.Items.Add(student);

            for (int i = 0; i < lbxDictionary.Items.Count; i++)
            {
                if (lbxDictionary.Items[i] is Student existingStudent && existingStudent.Number == student.Number)
                {
                    lbxDictionary.Items.RemoveAt(i);
                    break;
                }
            }

            MessageBox.Show("수정 완료");
            ClearStudentInfo();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDictionary.SelectedIndex < 0)
            {
                return;
            }
            var student = (lbxDictionary.SelectedItem as Student);
            btnNew_Click(sender, EventArgs.Empty);
            if (student != null)
            {
                DisplaySelectedStudent(student);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            selectedStudent = student;
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();

            //(숙제) 생년월일 중 월을 가져와 설정한다.
            //(숙제) 생년월일 중 일을 가져와 설정한다.
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();

            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                if ((cmbDepartment.Items[i] as Department).Code == student.DepartmentCode)
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }
            //(숙제)
            //지도교수,학년,반,재적상태,주소,연락처의 정보를 가져와 설정한다.
            //btnRegister의 글씨를 "수정"으로 변경한다.
            Professor advisorProfessor = null;
            foreach (var professor in professors)
            {
                if (professor.Number == student.AdvisorNumber)
                {
                    advisorProfessor = professor;
                    break;
                }
            }
            if (advisorProfessor != null)
            {
                cmbAdvisor.SelectedItem = advisorProfessor;
            }
            else
            {
                return;
            }
            cmbYear.SelectedItem = student.Year;
            cmbClass.SelectedItem = student.Class;
            cmbRegStatus.SelectedItem = student.RegStatus;
            tbxAddress.Text = student.Address;
            tbxContact.Text = student.Contact;
            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            //(숙제) ClearTestScoreInfo()를 호출해서 화면을 정리한다.
            //(숙제) 학번이 입력되었는지 여부를 확인하고, 그에 맞는 처리를 진행한다.
            ClearTestScoreInfo();
            if (tbxTestNumber.Text.Trim().Length != 8)
            {
                MessageBox.Show("학번이 제대로 입력되지 않았습니다.");
                return;
            }
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text.Trim());
            //(숙제) 검색한 학번이 없으면, 그에 맞는 처리를 진행한다.
            //(숙제) 학번을 통해 검색한 학생 정보에서 이름을 가져와 lblTestName에 설정한다.
            string searchNumber = tbxTestNumber.Text.Trim();
            if (students.ContainsKey(searchNumber))
            {
                Student student = students[searchNumber];
                lblTestName.Text = student.Name;
            }
            Grade grade = searchGradeByNumber(selectedStudent.Number);
#if false
            if (grade != null)
            {
                for (int i=1; i < grade.Scores.Count && i < tbxTestScores.Length; i++)
                {
                    tbxTestScores[i].Text = grade.Scores[i].ToString("0.0");
                }
            }
        }

        private Grade searchGradeByNumber(string number)
        {
            foreach (Grade grade in testGrades)
            {
                if (grade.StudentNumber == number)
                {
                    return grade;
                }
            }
            return null;
        }

        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number))
            {
                return students[number];
            }
            else
            {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                tbxTestNumber.Focus();
                return;
            }
            //학생의 성적 입력한 항목 중 중간이 비어있으면 안됨
            for (int i=1; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i - 1].Text) && false == string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    tbxTestScores[i - 1].Focus();
                    return;
                }
            }
            var grade = searchGradeByNumber(selectedStudent.Number);
            if (grade == null)
            {
                grade = new Grade();
                grade.StudentNumber = selectedStudent.Number;
            }
            grade.Scores.Clear();
            double temp;
            for (int i=0; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    break;
                }
                if (false == double.TryParse(tbxTestScores[i].Text, out temp))
                {
                    tbxTestScores[i].Focus();
                    return;
                }
                grade.Scores.Add(temp);
            }
            testGrades.Add(grade);
            lblTestTotalCount.Text = grade.Scores.Count.ToString();
            double average = grade.Average();
            lblTestAverage.Text = average.ToString("F1");
        }
    }
#else
#endif
            if (grade != null)
            {
                for (int i = 1; i < grade.Count() && i < tbxTestScores.Length; i++)
                {
                    tbxTestScores[i].Text = grade.Get(i).ToString("0.0");
                }
            }
        }

        private Grade searchGradeByNumber(string number)
        {
            foreach (Grade grade in testGrades)
            {
                if (grade.StudentNumber == number)
                {
                    return grade;
                }
            }
            return null;
        }

        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number))
            {
                return students[number];
            }
            else
            {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                tbxTestNumber.Focus();
                return;
            }
            //학생의 성적 입력한 항목 중 중간이 비어있으면 안됨
            for (int i = 1; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i - 1].Text) && false == string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    tbxTestScores[i - 1].Focus();
                    return;
                }
            }
            var grade = searchGradeByNumber(selectedStudent.Number);
            if (grade == null)
            {
                grade = new Grade();
                grade.StudentNumber = selectedStudent.Number;
            }
#if false
            grade._scores.Clear();
#else
            grade.Clear();
#endif
            double temp;
            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    break;
                }
                if (false == double.TryParse(tbxTestScores[i].Text, out temp))
                {
                    tbxTestScores[i].Focus();
                    return;
                }
                grade.Add(temp);
            }
            testGrades.Add(grade);
            lblTestTotalCount.Text = grade.Count().ToString();
            double average = grade.Average();
            lblTestAverage.Text = average.ToString("F1");
        }
    }
}
        