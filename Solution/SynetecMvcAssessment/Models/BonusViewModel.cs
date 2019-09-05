using InterviewTestTemplatev2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Models
{
    public class BonusViewModel
    {
        public int ID { get; set; }
        public IEnumerable<Data.HrEmployee> Employees { get; set; } 
        public int BonusPoolAllocationPerc { get; set; }
        public int TotalBonusPool { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }

        public BonusViewModel()
        {

        }

        public BonusViewModel(HrEmployee model)
        {
            ID = model.ID;
            FullName = model.Full_Name;
            Salary = model.Salary;

        }
    }
}