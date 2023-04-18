using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeDBContext dbContext = new EmployeeDBContext();
        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBContext db = new EmployeeDBContext())
            {
                return db.Employees.ToList();
            }
            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            using (EmployeeDBContext db = new EmployeeDBContext())
            {
                return db.Employees.FirstOrDefault(e => e.Userid == id);
            }
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody] Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Employees.Add(emp);
                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Invalid Model");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPut]
        // PUT api/<controller>/5
        public Employee Put(int Id,[FromBody] Employee emp)
        {          
                var obj = dbContext.Employees.Where(n => n.Userid == Id).SingleOrDefault();
                if (obj != null)
                {
                obj.Username = emp.Username;
                obj.Usermail = emp.Usermail;
                obj.Password = emp.Password;
                obj.MartialStatus = emp.MartialStatus;
                obj.Gender = emp.Gender;
                dbContext.SaveChanges();
                    
                }
            return obj;
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var obj = dbContext.Employees.Find(id);
                dbContext.Employees.Remove(obj);
                dbContext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}