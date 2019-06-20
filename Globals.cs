using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Case_One.Models;
namespace Case_One
{   
    public static class Globals
    {
        public static bool is_initialized = true; //this is set at true initially so the Client object is only created once in the beginning.
        public static Client Modified_ClientList = new Client(); // When a client is added, edited, or deleted, then this becomes the new client list we use. 
        public static int new_client_id = 0; //The client ID is one above the current highest client id.
    }
}
