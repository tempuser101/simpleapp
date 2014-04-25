using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace MongoDBApp.Models
{
    public class User
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }
    }
}