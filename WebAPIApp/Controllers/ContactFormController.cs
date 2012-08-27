using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using WebAPIApp.Models;

namespace WebAPIApp.Controllers
{
    public class ContactFormController : ApiController
    {
        // GET /api/contactform
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /api/contactform/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/// POST /api/contactform
        [HttpPost]
        public HttpResponseMessage Post(Contact contact)
        {
            // Process the Form data
            // contact.Name, contact.Email and contact.Message

            // Send the client an HTML message indicating the status of processing the Form
            string responseMessageHTML = ("<h3>Thank You!</h3>Thanks for contacting XYZ Company. Someone from our marketing team will be contacting " + contact.Name + ", at " + contact.Email);
            
            // Build an HTTPResponseMessage and return to client
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage.Content = new StringContent(responseMessageHTML);
            responseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return responseMessage;
        }

        // PUT /api/contactform/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/contactform/5
        public void Delete(int id)
        {
        }
    }
}