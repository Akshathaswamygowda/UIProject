using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student
    {
        public List<BO.Student> GetAllStudents()
        {
            String scn = Utilities.GetConnectionString();
            using (SqlConnection cn = new SqlConnection(scn))
            {
                string qry = "Select *from Student";
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    SqlDataReader dr=cmd.ExecuteReader();
                    List<BO.Student> lststudents = new List<BO.Student>();
                    while(dr.Read())
                    {
                        BO.Student ostudents = new BO.Student();
                        ostudents.Sid = Convert.ToInt32(dr["sid"]);
                        ostudents.Name = dr["name"].ToString();
                        ostudents.Class = dr["class"].ToString();
                        lststudents.Add(ostudents);
                    }
                    dr.Close();
                    cn.Close();
                    return lststudents;
                }
            }
        }
        public bool AddStudent(BO.Student uistudents)
        {
            string scn = Utilities.GetConnectionString();
            using (SqlConnection cn = new SqlConnection(scn))
            {
                string qry = string.Format("insert into Student Values({0},'{1}','{2}')", uistudents.Sid, uistudents.Name, uistudents.Class);
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    int count=cmd.ExecuteNonQuery();
                    cn.Close();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public void UpdateStudent(BO.Student uistudents)
        {
            string scn = Utilities.GetConnectionString();
            SqlConnection cn = new SqlConnection(scn);
            string qry = string.Format("update Student set name='{0}',class='{1}' where sid={2}", uistudents.Name, uistudents.Class, uistudents.Sid);
            SqlCommand cmd = new SqlCommand(qry, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void DeleteStudent(BO.Student uistudents)
        {
            string scn = Utilities.GetConnectionString();
            SqlConnection cn = new SqlConnection(scn);
            string qry = string.Format("Delete Student where sid={0}", uistudents.Sid);
            SqlCommand cmd = new SqlCommand(qry, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }

}
