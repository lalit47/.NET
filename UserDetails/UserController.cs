using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserDetails.Models;

namespace UserDetails.Controllers
{
    
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<User> userslist = new List<User>();
            string CS = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            
                SqlCommand cmd = new SqlCommand("GetUserDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                sd.Fill(dt);
                

                foreach (DataRow dr in dt.Rows)
                {
                    userslist.Add(
                        new User
                        {
                            UserId = Convert.ToInt32(dr["UserId"]),
                            Name = Convert.ToString(dr["Name"]),
                            CityId = Convert.ToInt16(dr["CityId"]),
                            EmailId = Convert.ToString(dr["EmailId"]),
                            UserName = Convert.ToString(dr["UserName"]),
                            Password = Convert.ToString(dr["Password"]),
                            PhoneNo = Convert.ToInt32(dr["PhoneNo"])
                        });
                }
            con.Close();
            
            return View(userslist);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            string CS = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            try
            {
               
                    SqlCommand cmd = new SqlCommand("AddNewUser", con);
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@CityId", user.CityId);
                    cmd.Parameters.AddWithValue("@Address", user.EmailId);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@PhoneNo", user.PhoneNo);
                    cmd.Parameters.AddWithValue("@Name", user.Name);

                    
                    int i = cmd.ExecuteNonQuery();
                    // TODO: Add insert logic here

                    
                    return RedirectToAction("Index");
                    
                
            }
            catch
            {
                return View();
            }
            finally
            {
                con.Close();
            }
            
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
