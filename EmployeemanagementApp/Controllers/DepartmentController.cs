using EmployeemanagementApp.EmpMgmtSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeemanagementApp.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/

        public ActionResult Index()
        {
            List<Department> deptColl;
            using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
            {
                deptColl = svc.GetAllDepartments();
            }
            return View(deptColl);
        }

        //
        // GET: /Department/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Department/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Department/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var deptName = GetDeptName(collection);
                if (!(string.IsNullOrWhiteSpace(deptName)))
                {
                    using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
                    {

                        svc.CreateDepartment(deptName);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private  string GetDeptName(FormCollection collection)
        {
            var deptName = collection.GetValue("DepartmentName").AttemptedValue;
            return deptName;
        }

        //
        // GET: /Department/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Department/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                  var deptName = GetDeptName(collection);
                  if (!(string.IsNullOrWhiteSpace(deptName)))
                  {
                      using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
                      {
                         
                         
                      }
                  }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Department/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Department/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
