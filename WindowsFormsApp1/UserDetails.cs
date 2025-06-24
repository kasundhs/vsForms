using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserDetails
    {
        private string fName;
        private string lName;
        private string addLine1;
        private string addLine2;
        private string city;
        private string postCode;
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName{ get { return lName; } set { lName = value; } }
        public string City {  get { return city; } set { city = value; } }
        public string PostCode { get { return postCode; } set { postCode = value; } }
        public string AddLine1 {  get { return addLine1; } set { addLine1 = value; } }
        public string AddLine2 { get { return addLine2; } set { addLine2 = value; } }

    }
}
