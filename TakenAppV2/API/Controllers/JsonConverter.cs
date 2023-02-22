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

        [HttpPost("Task")]
        public void PostTask(string subject, int priority, string state)
        {
            database.InsertTask(subject, priority, state);
        }

        [HttpDelete("Task")]
        public void Deletetask(int id)
        {
            database.DeleteTask(id);
        }

        [HttpPut("Task")]
        public void UpdateTask(int id, string subject, int priority, string state)
        {
            database.UpdateTask(id, subject, priority, state);
        }

    }
}
