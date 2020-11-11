using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsWebApiConsuming.Models
{
    public class Project // Projects Managing Class
    {
        [Key] // PK Project
        public int Id { get; set; }
        // title of the project
        public string Title { get; set; }
        // starting date
        public string StartingDate { get; set; }
        // ending date
        public string EndingDate { get; set; }
        // project budget
        public double Budget { get; set; }
    }
}
