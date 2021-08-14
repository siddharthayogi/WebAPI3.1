using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebAPI3._1.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace WebAPI3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public EmployeeController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        // GET: api/Employee
        [HttpGet] 
        public JsonResult Get()
        {
            try
            {

                return new JsonResult("");
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }

        }

        // GET: api/Employee/1
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
            return new JsonResult("");
        }

        // POST: api/Employee
        [HttpPost]
        public async Task<IActionResult> Post(Employee employee)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok("Inserted Successfully!");
                }
            }
            catch(Exception ex)
            {
                return new JsonResult(ex.Message);
            }           
        }

        // PUT: api/Employee/1
        [HttpPut]
        public JsonResult Put(int id, Employee employee)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
            return new JsonResult("Updated Successfully!");
        }

        // DELETE: api/Employee/1
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
            return new JsonResult("Deleted Successfully!");
        }

        [Route("SavePhoto")]
        [HttpPost]
        public JsonResult SavePhoto()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string fileName = postedFile.FileName;
                var physicalPath = _environment.ContentRootPath + "/Photo" + fileName;

                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(fileName);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
                //throw new Exception(ex.Message);
            }
        }
    }
}
