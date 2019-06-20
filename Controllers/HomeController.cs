using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Case_One.Models;
using ConsultingCompany.DataStore;
using Case_One;
namespace Case_One.Controllers
{
    //Calls the globals.cs file each. Since the data store is hardcoded, we can only initialize a Client object once, or else each time we switch pages it'll recreate the 
    //Client class and we'll see the hard coded values again. That's what the is_initialized variable is for. 
    public class HomeController : Controller
    {
        public Client ClientList { get; set; }
        public HomeController()
        {
            if (Case_One.Globals.is_initialized)
            {
                ClientList = new Client();
            }
            else {
                ClientList = Globals.Modified_ClientList;
            }
        }
        //View for adding a client 
        public IActionResult Index()
        {
            return View();
        }
        //View for displaying all the clients
        public IActionResult ViewClients()
        {
            ViewData.Model = ClientList;
            return View();
        }

        //Deletes a client. It takes the ClientId from the row that the user wishes to delete and returns a new client list without the deleted client. 
        public IActionResult DeleteClient(string id) {
            int ClientId = Int32.Parse(id);
            ClientList.Clients = ClientList.Clients.Where(x => x.ClientId != ClientId).ToList();
            Globals.Modified_ClientList.Clients = ClientList.Clients;
            Globals.is_initialized = false; //We only need to initialize the Client class one time...afterwards we can just call the modified client list. 
            return RedirectToAction("ViewClients");
        }
        //Only sends the client that the user wishes to edit to a separate edit client page, which is unaccessible from the nav bar. 
        public IActionResult EditClient(string id)
        {
            int ClientId = Int32.Parse(id);
            ViewBag.EditClient = ClientList.Clients.Where(x => x.ClientId == ClientId).ToList();
            return View();
        }

        //Takes the value from the edit page and replaces the old values with the new ones. 
        public IActionResult PostEditClient()
        {
            int ClientId = Int32.Parse(Request.Form["ClientId"]);
            int ClientIndex = Globals.Modified_ClientList.Clients.FindIndex(x => x.ClientId == ClientId);
            Globals.Modified_ClientList.Clients[ClientIndex].CompanyName = Request.Form["CompanyName"];
            Globals.Modified_ClientList.Clients[ClientIndex].ContactFirstName = Request.Form["FirstName"];
            Globals.Modified_ClientList.Clients[ClientIndex].ContactLastName = Request.Form["LastName"];
            Globals.Modified_ClientList.Clients[ClientIndex].City = Request.Form["City"];
            Globals.Modified_ClientList.Clients[ClientIndex].State = Request.Form["State"];
            Globals.Modified_ClientList.Clients[ClientIndex].Zip = Request.Form["Zip"];
            Globals.Modified_ClientList.Clients[ClientIndex].LastUpdated = DateTime.Now.ToString();
            Globals.is_initialized = false;
            return RedirectToAction("ViewClients");
        }
        //Post request that adds a client. 
        public IActionResult AddClient() {
            for(var i = 0; i < Globals.Modified_ClientList.Clients.Count; i++) //finds the new clientID to display, just one more from the max client id.
            {
                if (Globals.new_client_id < Globals.Modified_ClientList.Clients[i].ClientId)
                {
                    Globals.new_client_id = Globals.Modified_ClientList.Clients[i].ClientId;
                };
            };
            ConsultingCompany.Lib.Client NewClient = new ConsultingCompany.Lib.Client
            {
                ClientId = Globals.new_client_id + 1,
                CompanyName = Request.Form["CompanyName"],
                ContactFirstName = Request.Form["FirstName"],
                ContactLastName = Request.Form["LastName"],
                City = Request.Form["City"],
                State = Request.Form["State"],
                Zip = Request.Form["Zip"],
                LastUpdated = DateTime.Now.ToString()
            };
            ClientList.Clients.Add(NewClient);
            Globals.Modified_ClientList.Clients = ClientList.Clients;
            Globals.is_initialized = false;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
