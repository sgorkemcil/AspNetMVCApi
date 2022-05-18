﻿using AspNetMVCApi_BLL.ContractBLL;
using AspNetMVCApi_EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AspNetMVCApi_PL.Controllers
{
    [System.Web.Http.RoutePrefix("s")]
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        // GET s --> prefix var böyle çağrılır
        //Get api/student/GetAllStudents
        [System.Web.Http.Route("")]
        public ResponseData GetAllStudents()
        {
            try
            {
                var result = _studentService.GetAllStudents();
                return new ResponseData() { IsSuccess = true, Data = result };
            }
            catch (Exception ex)
            {
                // ex loglanabilir
                return new ResponseData()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }


        // GET api/<controller>/5

        //öğrenci ekleme
        [HttpPost]
        [System.Web.Http.Route("")]
        public ResponseData AddStudent([FromBody]StudentVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return new ResponseData()
                    {
                        IsSuccess = false,
                        Message = "Veri girişleri düzgün olmalıdır!"
                    };

                }
                model.RegisterDate = DateTime.Now;
               ResponseData result= _studentService.AddStudet(model);
                return new ResponseData()
                {
                    IsSuccess = true,
                    Message = "Yeni öğrenci kaydı yapılmıştır."
                };
            }
            catch (Exception ex)
            {
                 // ex loglanabilir
                return new ResponseData()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }

        }
        // POST api/<controller>

        // PUT api/<controller>/5

        // DELETE api/<controller>/5
    }
}