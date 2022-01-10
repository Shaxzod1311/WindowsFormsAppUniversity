using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1

{
    
    public class Database
    {
      
        public const string Students_DbPath = @"..\..\Database\student_db.json";
        public const string Teachers_DbPath = @"..\..\Database\techers_db.json";
        
        public static void WriteStDb(dynamic obj)
        {
            string info = File.ReadAllText(Students_DbPath);
            List<Student> list = new List<Student>();
            
            if (info != null)
            {
                list = JsonConvert.DeserializeObject<List<Student>>(info);
            }

            list.AddRange(obj);

            info = JsonConvert.SerializeObject(list);
            
            File.WriteAllText(Students_DbPath, info);

        }
       
        public static void WriteTeacherDb(dynamic obj)
        {
            string info = File.ReadAllText(Teachers_DbPath);
            
            List<Teacher> list = new List<Teacher>();

            if (info != null) 
            {
              list = JsonConvert.DeserializeObject<List<Teacher>>(info);
            }

            list.AddRange(obj);

            info = JsonConvert.SerializeObject(list);

            File.WriteAllText(Teachers_DbPath, info);

        }

        public static dynamic ReadStInfoFromDb()
        {

            string info = File.ReadAllText(Database.Students_DbPath);

            return info != null ? JsonConvert.DeserializeObject<List<Student>>(info) : null;

        }

        public static dynamic ReadTeachersFromDb()
        {

            string info = File.ReadAllText(Database.Teachers_DbPath);

            return info != null ? JsonConvert.DeserializeObject<List<Teacher>>(info) : null;

        }

        public static dynamic SearchStudent(string Phone)
        {
            List<Student> students = ReadStInfoFromDb();
           
            return students.FindAll(p => p.Phone == Phone);
        }

        public static dynamic SearchTeacher(string Phone)
        {
            List<Teacher> teachers = ReadTeachersFromDb();
            
            return teachers.FindAll(p => p.Phone == Phone);
        }

        public static void RemStFromDb(string phone)
        {
            List<Student> students = ReadStInfoFromDb();
            students.Remove(students.Find(p => p.Phone == phone));

            string json  = JsonConvert.SerializeObject(students);
            File.WriteAllText(Database.Students_DbPath, json);
        }

        public static void RemTeachFromDb(string phone)
        {
            List<Teacher> teachers = ReadTeachersFromDb();
            teachers.Remove(teachers.Find(p => p.Phone == phone));

            string json = JsonConvert.SerializeObject(teachers);
            File.WriteAllText(Database.Teachers_DbPath, json);
        }
    }
}
