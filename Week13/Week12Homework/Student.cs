﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    enum YEAR
    {
        ONE = 0,
        TWO,
        THREE,
        FOUR,

        END,
    }

    enum CLASS
    {
        A = 0,
        B,
        C,

        END,
    }

    enum REG_STATUS
    {
        ENROLLED = 0,
        GRADUATED,
        ONLEAVE,
        EXPELLED,

        END,
    }

    class Student : Member, IFile
    {
        //static 필드
        public static Dictionary<YEAR, string> YearName
            = new Dictionary<YEAR, string>{
                { YEAR.ONE,   "1학년" },
                { YEAR.TWO,   "2학년" },
                { YEAR.THREE, "3학년" },
                { YEAR.FOUR,  "4학년(심화)" },
            };

        public static Dictionary<REG_STATUS, string> RegStatusName
            = new Dictionary<REG_STATUS, string>{
                { REG_STATUS.ENROLLED,    "재학"},
                { REG_STATUS.GRADUATED,   "졸업"},
                { REG_STATUS.ONLEAVE,     "휴학"},
                { REG_STATUS.EXPELLED,    "퇴학"},
            };

        //public string Number { get; private set; }
        //public string Name { get; private set; }
        public DateTime BirthInfo { get; private set; }
        public void SetBirthInfo(int year, int month, int day)
        {
            BirthInfo = new DateTime(year, month, day);
        }
        //public string DepartmentCode { get; set; }
        public string AdvisorNumber { get; set; }
        public YEAR Year { get; set; }
        public CLASS Class { get; set; }
        public REG_STATUS RegStatus { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public Student(string number, string name)
            //: this(number, name, null)
            : base(number, name, null)
        {
            //Number = number;
            //Name = name;
        }
        public Student(string number, string name, Department dept)
             : base(number, name, dept)
        {
        }

        public override string ToString()
        {
            return $"[{this.Number}]{this.Name}";
        }

        public string Record {
            get { return $"{Number}|{Name}|{Dept.Code}|{BirthInfo:yyyy,MM,dd}|{AdvisorNumber}|{Year}|{(int)Class}|{(int)RegStatus}|{Address}|{Contact}"; }
        }

        public static Student Restore(string record, Department[] departments) {
            Student student = null;

            try {
                var sdata = record.Trim().Split(new char[] { '|' });

                if (sdata.Length == 10) {

                    // 0 학번
                    // 1 이름
                    // 2 학과
                    var dept = departments.FirstOrDefault(m => m != null && m.Code == sdata[2]);

                    student = new Student(sdata[0], sdata[1], dept);
                    // 3 생일
                    // 참고 : DateTime birthinfo = DataTime.ParseExact(sdata[3], "yyyy,MM,dd",null);
                    var ddata = sdata[3].Split(',');
                    if (ddata.Length == 3) {
                        if (int.TryParse(ddata[0], out int y)) {
                            if (int.TryParse(ddata[1], out int m)) {
                                if (int.TryParse(ddata[2], out int d)) {
                                    student.SetBirthInfo(y, m, d);
                                }
                            }
                        }
                    }
                    // 4 지도교수
                    student.AdvisorNumber = sdata[4];

                    // 5 학년
                    // 참고
                    if (Enum.TryParse<YEAR>(sdata[5], out var year)) {
                        student.Year = year;
                    } else {
                        student.Year = YEAR.ONE;
                    }

                    // 6 반
                    if (int.TryParse(sdata[6], out int tempclass)) {
                        student.Class = (CLASS)tempclass;
                    } else {
                        student.Class = CLASS.A;
                    }

                    // 7 등록상태
                    if (int.TryParse(sdata[7], out int tempregstt)) {
                        student.RegStatus = (REG_STATUS)tempregstt;
                    }
                    else {
                        student.RegStatus = REG_STATUS.ENROLLED;
                    }

                    // 8 주소
                    student.Address = sdata[8].Trim();
                    // 9 연락처
                    student.Contact = sdata[9].Trim();

                }

            } catch {
                Console.WriteLine("에러는 관심 없음");
                Console.WriteLine("죽지만 말자");
            }
            return student;
        }


    }
}
