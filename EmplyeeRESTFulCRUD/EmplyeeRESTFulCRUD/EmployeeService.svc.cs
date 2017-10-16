using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace EmplyeeRESTFulCRUD
{
    
    public class EmployeeService:IEmployee
    {
        EmployeeDataDataContext data = new EmployeeDataDataContext();

        public List<Employee> GetEmployee()
        {
            try
            {
                return (from employee in data.Employees select employee).ToList();
            }
            catch
            {
                return null;
            }

            //throw new NotImplementedException();
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
