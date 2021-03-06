﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        string username;
        string password;
        string name;
        int age;

        public User(string username, string name, int age)
        {
            this.Username = username;
            this.Name = name;
            this.Age = age;
            this.Password = "123456";
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public bool CheckCredentials(string username, string pass)
        {
            if (this.Username.Equals(username) && this.Password.Equals(pass))
                return true;
            return false;
        }
    }
}
