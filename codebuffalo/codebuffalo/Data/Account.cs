using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace codebuffalo.Data
{

    /* Class for individual user
     * holds profile settings
     */
    public class Account
    {
        public Account()
        {

        }

        public String UserID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public String Radius { get; set; }
        public String PhoneNumber { get; set; }
        public String DOB { get; set; }

    }
}
