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

        public string XboxUsername { get; set; }
        public string PSUsername { get; set; }
        public string SteamUsername { get; set; }
        public string test { get; set; }

        public int Radius { get; set; }

        public Task<String> Yes()
        {
            return Task.FromResult("yes");
        }



    }
}
