using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnlineExam_WEBAPI_MVC.Models;

namespace OnlineExam_WEBAPI_MVC.Controllers
{
    public class ExamController : ApiController
    {
        [HttpGet]
        public IHttpActionResult onlineexam()
        {
            ExamDBEntities examDBEntities = new ExamDBEntities();
            IList<OnlineExamClass> oe = examDBEntities.OnlineExams.Include("OnlineExam").Select(x => new OnlineExamClass()
            {
                Qid = x.Qid,
                Question = x.Question,
                Option1 = x.option1,
                Option2 = x.option2,
                Option3 = x.option3,
                Option4 = x.option4,
                corrans = x.Correctans
            }).ToList<OnlineExamClass>();
            return Ok(oe);
        }

    }
}
