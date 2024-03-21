using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FindMate.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public string DNI { get; set; }
        public string Numero { get; set; }
    }
}
