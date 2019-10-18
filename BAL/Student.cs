using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Student
    {
        public List<BO.Student> GetAllStudents()
        {
            DAL.Student dal_student = new DAL.Student();
            List<BO.Student> lststudents=dal_student.GetAllStudents();
            return lststudents;
        }
        public bool AddStudent(BO.Student uistudents)
        {
            DAL.Student dal_student = new DAL.Student();
            return dal_student.AddStudent(uistudents);
        }
        public void UpdateStudent(BO.Student uistudents)
        {
            DAL.Student dal_student = new DAL.Student();
            dal_student.UpdateStudent(uistudents);
        }
        public void DeleteStudent(BO.Student uistudents)
        {
            DAL.Student dal_student = new DAL.Student();
            dal_student.DeleteStudent(uistudents);

        }
    }
}
