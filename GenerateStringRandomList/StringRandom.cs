using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateStringRandomList
{
    public class StringRandom
    {
        private List<string> lstString;
        public List<string> Values
        {
            get
            {
                return lstString;
            }
            set
            {
                lstString = value;
            }
        }

        public long Count
        {
            get
            {
                return Values.Count;

            }
        }

        public StringRandom()
        {

        }

    }
}
