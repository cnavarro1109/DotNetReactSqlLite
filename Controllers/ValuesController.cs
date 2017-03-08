using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCOREFORM.Models;
using Newtonsoft.Json;

namespace ASPNETCOREFORM.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        /*
        
        Instructions:
        Anywhere in the code containing [MyNameClass], change it
        to the name of the class you have defined in your Model.cs file.
         */

        // GET api/values
        [HttpGet]
        public List<[MyNameClass]]> Get()
        {
            var data = new List<[MyNameClass]>();
            using(var db = new InventoryContext()){
                data = db.Inventories.ToList();
            }
            return data;

        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody][MyNameClass] data)
        {
            /*
               Make sure to create a new instance of 
               inventoryContext. You may refer to your notes or gitbook.
               https://cn1109.gitbooks.io/saintermediate/content/dotnet-core-entityframework.html

               Look under the section: Updating the Values Controller to use Entity Framework
            */

            return "DONE!";
        }

        
    }
}
