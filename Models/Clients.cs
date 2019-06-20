using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsultingCompany.DataStore;
using ConsultingCompany.Lib;

namespace Case_One.Models
{   //This model contains the client class, which is referenced from the data store itself. We only initialize the Client object once. 
    public class Client
    {
        public List<ConsultingCompany.Lib.Client> Clients { get; set; }

        public Client()
        {
            ConsultingCompanyRepository ClientList = new ConsultingCompanyRepository();
            Clients = ClientList.Clients;
        }
            
    }
}
