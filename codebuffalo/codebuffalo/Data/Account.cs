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

        private String UserID { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private String Email { get; set; }
        private String City { get; set; }
        private String State { get; set; }
        private String Country { get; set; }
        private String Radius { get; set; }
        private String PhoneNumber { get; set; }
        private String DOB { get; set; }


        public Task<String> SetDefaults()
        {
            return Task.FromResult("yes");
        }



    }
}
