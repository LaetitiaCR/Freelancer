using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.Data;

namespace WebApplicationFreelancer.Controllers
{
    public class MyController 
    {
        private readonly FreelancerContext _context;

        public MyController(FreelancerContext context)
        {
            _context = context;
        }
        
       
    }
}
