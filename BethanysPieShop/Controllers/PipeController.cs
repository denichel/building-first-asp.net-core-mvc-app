﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PipeController :  Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}