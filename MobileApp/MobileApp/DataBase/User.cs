using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileApp.DataBase
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
