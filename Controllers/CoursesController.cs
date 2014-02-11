﻿using Angular4DotNetMvc.Models.Courses;
using Angular4DotNetMvc.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly RegistrationViewModelBuilder _registrationViewModelBuilder = new RegistrationViewModelBuilder();

        public CourseViewModel[] Get()
        {
            return _registrationViewModelBuilder.GetCoursesVms();
        }

    }
}
