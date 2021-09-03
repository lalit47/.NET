using Employee_Details_App.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Details_App.Controllers
{

    public class EmployeeController : Controller
    {
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employeeList = new List<Employee>();

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var employee = new Employee();

                    employee.EmpNo = Convert.ToInt32(dr["EmpNo"]);
                    employee.Name = dr["Name"].ToString();
                    employee.Basic = Convert.ToInt32(dr["Basic"]);
                    employee.DeptNo = Convert.ToInt16(dr["DeptNo"]);
                    employeeList.Add(employee);
                }
                return View(employeeList);
                dr.Close();
                con.Close();
            }
        }
            // GET: Employee/Details/5
            public ActionResult Details(int id=0)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employees where EmpNo="+"EmpNo", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    Employee employee = new Employee();
                while (dr.Read())
                {    

                        employee.EmpNo = Convert.ToInt32(dr["EmpNo"]);
                        employee.Name = dr["Name"].ToString();
                        employee.Basic = Convert.ToInt32(dr["Basic"]);
                        employee.DeptNo = Convert.ToInt16(dr["DeptNo"]);

                        
                    }
                return View(employee);
                    dr.Close();
                    con.Close();
                }
            }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee details)
        {
            try
            {
                // TODO: Add insert logic here
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    //SqlDataReader dr = cmd.ExecuteReader();
                    Employee employee = new Employee();
                    
                    
                        employee.EmpNo = details.EmpNo;
                        employee.Name =details.Name;
                        employee.Basic = details.Basic;
                        employee.DeptNo = details.DeptNo;
                        
                       return RedirectToAction("Index");
                       con.Close();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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

   