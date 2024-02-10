using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.AppRouting
{
    public static class Router
    {
        public const string Root = "api/";
        public const string Version = "V1/";
        public const string Rule = Root + Version;

        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student/";

            public const string GetStudentsList = Prefix + "GetAll";
            public const string GetStudentById = Prefix + "GetById/{id}";
        }
    }
}
