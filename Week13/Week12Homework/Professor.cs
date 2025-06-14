using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    class Professor : Member, IFile
    {
        //public string DepartmentCode { get; set; }

        //private string _number;
        //public string Number
        //{
        //    get { return _number; }
        //}
        //
        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }

        public Professor(string number, string name, Department dept)
            : base(number, name, dept)
        {
            //_number = number;
            //_name = name;
            //DepartmentCode = deptcode;
        }

        public string Record {
            get { return $"{Number}|{Name}|{Dept.Code}"; }
        }

        public static Professor Restore(string record, Department[] departments) {
            // i p o 생각. input process output / i, o미리 만들기
            //Professor prof = null;
            //return prof;
            //    Professor prof = null;
            //    try {

            //    } catch (Exception ex) {
            //        Console.WriteLine(ex);
            //        throw ex; // throw 던지다 에러정보 ex 호출자에 던진다. 
            //    }
            //    return prof;
            //}

            Professor prof = null;
            try {
                var sdatas = record.Trim().Split('|' ); // Split(new char[] { '|' })
                var dept = departments.FirstOrDefault(m => m != null && m.Code == sdatas[2]); // 순서는 null 검사부터 
                prof = new Professor(sdatas[0], sdatas[1], dept);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                throw ex; // throw 던지다 에러정보 ex 호출자에 던진다. 
            }
            return prof;
        }

    }
}
