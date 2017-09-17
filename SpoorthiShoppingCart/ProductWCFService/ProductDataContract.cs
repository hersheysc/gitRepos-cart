using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProductWCFService
{
    [DataContract]
    public class ProductDataContract
    {
        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public double UnitPrice { get; set; }

        [DataMember]
        public int Discontinued { get; set; }

        //bool boolValue = true;
        //string stringValue = "Hello ";

        //[DataMember]
        //public bool BoolValue
        //{
        //    get { return boolValue; }
        //    set { boolValue = value; }
        //}

        //[DataMember]
        //public string StringValue
        //{
        //    get { return stringValue; }
        //    set { stringValue = value; }
        //}
    }
}
