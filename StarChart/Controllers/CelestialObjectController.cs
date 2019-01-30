using System;
using System.Collections.Generic;
using System.Linq;
using StarChart.Data;
using Microsoft.AspNetCore.Mvc;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
