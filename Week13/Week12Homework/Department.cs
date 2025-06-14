﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week09Homework
{
    class Department : IFile
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            private set {
                if (false == string.IsNullOrEmpty(value)) {
                    _code = value;
                } else {
                    throw new Exception("Value is Empty");
                }
            }
        }

        public string GetCode()
        {
            return _code;
        }

        private void SetCode(string value)
        {
            if (false == string.IsNullOrEmpty(value)) {
                _code = value;
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            private set {
                if (false == string.IsNullOrEmpty(value)
                    && value.Length >= 2) {
                    _name = value;
                } else {
                    throw new Exception("Value is Empty");
                }
            }
        }

        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }

        public string Record
        {
            get { return $"{Code}|{Name}"; }
        }

#if false
        public Department()
        {
        
        }
#endif

        public Department(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public static Department Restore(string record)
        {
            Department dept = null;
            //참고
            try {
                var splitdatas = record.Trim().Split(new char[] { '|' });
                dept = new Department(splitdatas[0], splitdatas[1]);
            } catch (IndexOutOfRangeException ex) {
                MessageBox.Show("파일 포맷이 잘못되었음");
                Console.WriteLine(ex);
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
            return dept;
        }
    }
}
