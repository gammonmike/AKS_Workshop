﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AKS_Workshop.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GreetingController : ControllerBase
  {

    public string Get(int id)
    {
      return "Hello World!";
    }

  }
}