using System;
using System.Collections.Generic;


namespace lifeauthor.Models

{

    public class Users : BaseEntity

    {

        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string password { get; set; }
       

    }

}