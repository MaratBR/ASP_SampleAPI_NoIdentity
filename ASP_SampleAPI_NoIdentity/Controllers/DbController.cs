using ASP_SampleAPI_NoIdentity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_SampleAPI_NoIdentity.Controllers
{
    public class DbController : ControllerBase
    {
        protected readonly AppDbContext DbContext;

        public DbController(AppDbContext context)
        {
            DbContext = context;
        }
    }
}
