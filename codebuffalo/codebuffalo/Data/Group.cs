using System;
using System.Collections.Generic;

namespace codebuffalo.Data
{

    /* Group class.
     * Holds information for a "team" or group of people playing
     */
    public class Group
    {
        public Group()
        {
        }

        private List<Account> Members { get; set; }
        private Account Creator { get; set; }
        private String GameName { get; set; } //change to enum

    }
}
