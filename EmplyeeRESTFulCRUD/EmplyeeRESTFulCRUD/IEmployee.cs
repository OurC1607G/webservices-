using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EmplyeeRESTFulCRUD
{
    [ServiceContract]
    interface IEmployee
    {
        [OperationContract]
        [WebInvoke(Method ="GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Bare,
            UriTemplate ="GetEmployeeList/")]
        
        List<Employee> GetEmployee();


    }
}
