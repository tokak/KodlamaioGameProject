using KodlamaioGameProject.Abstract;
using KodlamaioGameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        //Kimlik Doğrulama 
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.BirthDay.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }

       
    }
}
