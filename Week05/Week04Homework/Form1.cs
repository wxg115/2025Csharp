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

        List<Grade> testGrade;
        TextBox[] tbxTestScores;

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣어준다
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();
            for (int i=1; i <= 4; i++)
            {
                cmbYear.Items.Add(i);
            }
            for (char c = 'A'; c <= 'C'; c++)
            {
                cmbClass.Items.Add(c);
            }
            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");
            testGrade = new List<Grade>;
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
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index값 검사해서 진행여부 결정
            //(구현) 조회할 학과를 선택하라는 메세지를 띄우고 종료한다.
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("조회할 학과를 선택해주세요.");
                return;
            }
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
            if(department != null)
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
            tbxNumber.Text = "20";
            tbxBirthYear.Text = "20";
            tbxName.Text = "";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = "";
            tbxContact.Text = "";
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
                // if 1800 < 
            }
            else
            {
                return;
            }
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                // if 1~12
            }
            else
            {
                return;
            }
            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                // if 1~31
            }
            else
            {
                return;
            }
            //현재 시간: DateTime.Now;
            student.BirthInfo =  new DateTime(birthYear, birthMonth, birthDay);
            
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

            students[number] = student; // 딕셔너리에 데이터 추가 방법1
            //students.Add(number, student); // 딕셔너리에 데이터 추가 방법2
            lbxDictionary.Items.Add(student);
        }

        private void UpdateStudent() //define
        {
            throw new NotImplementedException();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            //교안 추가

            selectedStudent = (lbxDictionary.SelectedItems as Student);
            btnNew_Click(sender, EventArgs.Empty);

            if (selectedStudent != null)
            {
                DisplaySelectedStudent(selectedStudent);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text.Trim());
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
    }
}