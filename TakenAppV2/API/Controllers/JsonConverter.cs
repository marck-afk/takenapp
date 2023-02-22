using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using System.Text.Json;

namespace API.Controllers
{
    public class JsonConverter
    {
        DatabaseFunctions database = new DatabaseFunctions("localhost", "taken", "root", "");

        [HttpGet("Task")]
        public string GetAllTasks()
        {
            List<Tasks> l = new List<Tasks>();
            l = database.GetAllData();
            string x = JsonSerializer.Serialize(l);
            return x; 
        }

    }
}
