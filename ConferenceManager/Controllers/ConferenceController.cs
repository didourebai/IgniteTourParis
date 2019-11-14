﻿using System.Linq;
using ConferenceManager.Entities.Models;
using ConferenceManager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIs.Controllers
{
    //[Route("v1/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class ConferenceController: ControllerBase
    {
        private readonly IConferenceRepo repo;

        public ConferenceController(IConferenceRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var conferences = repo.GetAll();
            if (!conferences.Any())
                return new NoContentResult();

            return new ObjectResult(conferences);
        }

        [HttpPost]
        public ConferenceModel Add(ConferenceModel conference)
        {
            return repo.Add(conference);
        }
    }
}
