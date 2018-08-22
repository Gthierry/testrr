using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheNumber.Models
{

    class Number
    {

        private int _NumberToFind;

        public int NumberToFind
        {
            get
            {
                return _NumberToFind;
            }
            set
            {

                _NumberToFind = value;
            }
        }

        public Number()
        {
            _NumberToFind = RandomNumber();
        }


        /// <summary>
        /// Method returning a random int between 0 and 100
        /// </summary>
        /// <returns></returns>
        public int RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0,101);
        }

    }
}
