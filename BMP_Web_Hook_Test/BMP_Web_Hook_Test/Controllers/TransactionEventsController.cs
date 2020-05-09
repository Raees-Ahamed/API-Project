using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMP_Web_Hook_Test.Models;
using MailChimp.Net.Core;
using Microsoft.AspNetCore.Mvc;

namespace BMP_Web_Hook_Test.Controllers
{
    public class TransactionEventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost ]
        public ActionResult ClientResponse200([FromBody] TransactionSettledWebHookModel requestBody)
        {
            var nonce = new NonceObject()
            {
                Nonce = requestBody.Nonce
            };

            return Ok(nonce);
        }

        [HttpPost]
        public ActionResult ClientResponse400([FromBody] TransactionSettledWebHookModel requestBody)
        {
            return BadRequest();
        }

        [HttpPost]
        public ActionResult ClientResponse404([FromBody] TransactionSettledWebHookModel requestBody)
        {
            return NotFound();
        }

        [HttpPost]
        public ActionResult ClientResponse500([FromBody] TransactionSettledWebHookModel requestBody)
        {
            throw new Exception();
        }

        [HttpPost]
        public ActionResult ClientResponse406([FromBody] TransactionSettledWebHookModel requestBody)
        {
            throw new Exception();
        }
        [HttpPost]
        public ActionResult ClientResponse403([FromBody] TransactionSettledWebHookModel requestBody)
        {
            throw new Exception();
        }

    }
}