using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTester.Models
{
    public class Favorite
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}