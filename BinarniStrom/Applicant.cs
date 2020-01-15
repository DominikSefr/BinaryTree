using System;
using System.Collections.Generic;
using System.Text;

namespace BinarniStrom
{
    class Applicant : IComparable
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string RealName { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Applicant)
            {
                return this.Score.CompareTo((obj as Applicant).Score);
            }
            else
                throw new NotImplementedException();
        }

        public override string ToString()
        {
            //return Id + " / " + Score + " / " + RealName;
            return Score.ToString() + " ";
        }
    }
}
