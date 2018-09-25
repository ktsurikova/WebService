using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PL.Entities;

namespace PL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBasicOperationService" in both code and config file together.
    [ServiceContract]
    public interface IBasicOperationService
    {
        [OperationContract]
        Product GetNearest(string name, double longitude, double latitude);

        [OperationContract]
        Product GetCheapestInCity(string productName, string cityName);

        [OperationContract]
        Dictionary<Shop, decimal> GetManyCheapestInCity(IEnumerable<string> products, string cityName);

        [OperationContract]
        Dictionary<Shop, decimal> GetManyNearest(IEnumerable<string> products, double lat, double lon);

        [OperationContract]
        List<string> SearchForKeyword(string keyword);
    }
}
