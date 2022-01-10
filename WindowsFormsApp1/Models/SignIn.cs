using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SignIn
    {
        private const string Path = @"C:\Users\User\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database\signin.json";
        private string Login = "admin121";
        private string Password = "1234";


        public static object JosonConvert { get; private set; }

        public bool CheakAdmin(string log, string pass)
        {
           
            string json = File.ReadAllText(Path);
            List<SignIn> admins = JsonConvert.DeserializeObject<List<SignIn>>(json);

            return admins.Exists(p => p.Login == log && p.Password == pass);

            
        }
        
        public void WriteAdminDb(SignIn sign)
        {
            string json = File.ReadAllText(Path);
            List<SignIn> admins =JsonConvert.DeserializeObject<List<SignIn>>(json);
            
            if (admins.Exists(p => p.Login == sign.Login && p.Password == sign.Password) != true) admins.Add(sign);
            
            json = JsonConvert.SerializeObject(admins);

            File.WriteAllText(Path, json);
        } 

    }
}
