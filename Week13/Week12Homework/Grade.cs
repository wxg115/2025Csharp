﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    class Grade
    {
        public const int MAX_GRADE_COUNT = 9;

        private string _studentNumber;
        public string StudentNumber
        {
            get { return _studentNumber; }
        }

        private List<double> _scores = new List<double>();

        public Grade(string studentNumber)
        {
            _studentNumber = studentNumber;
        }

        public int Count()
        {
            return _scores.Count;
        }
        public double Get(int i)
        {
            return _scores[i];
        }

        public double Average()
        {
            if (this._scores.Count == 0) {
                return -1.0;
            }

            double sum = 0.0;
            foreach (var score in this._scores) {
                sum += score;
            }
            return sum / _scores.Count;
        }

        public void Clear()
        {
            _scores.Clear();
        }

        public bool Add(double score)
        {
            if (_scores.Count >= Grade.MAX_GRADE_COUNT) {
                return false;
            }

            _scores.Add(score);
            return true;
        }
    }
}