using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Demo_Test.Models
{
    public class Login_Data
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
