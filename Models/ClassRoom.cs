using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class ClassRoom
    {
        public string Teacher { get; set; } = "";
       
        private readonly ITeacher _teacher;

        public void GetTeacherInfo()
        {
            _teacher.GetInfo();
        }

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void ClassInfo()
        {
            Console.WriteLine("Teacher info: ");
            _teacher.GetInfo();
        }
    }
}
