using CalculateBonus.Concrete;
using InterviewTestTemplatev2.Data;
using InterviewTestTemplatev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewTestTemplatev2.Controllers
{
    public class BonusController : Controller
    {
        private MvcInterviewV3Entities1 db = new MvcInterviewV3Entities1();
        CalculateEmployeeBonus bonus = new CalculateEmployeeBonus();
        // GET: Bonus
        public ActionResult Index()
        {
            BonusViewModel model = new BonusViewModel();
            model.Employees = db.HrEmployees.ToList<HrEmployee>();
            return View(model);
        }

        public ActionResult CalculateBonus()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(BonusViewModel model, int totalBonusPool) 
        {

             var selectedEmployeeId = model.ID;
            model.TotalBonusPool = totalBonusPool;
            
            
            var employeeSalary = model.Salary;

            //get the total salary budget for the company
            var totalSalary = (int)db.HrEmployees.Sum(item => item.Salary);

            var myBonus = bonus.CalculateBonusPercentage(employeeSalary, totalSalary);

            var result = bonus.CalculateBonusAllocation(myBonus, totalBonusPool);
            model.BonusPoolAllocationPerc = result;

            return View("CalculateBonus", model);
        }

    }
}