using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Wizzard
    {
        private int mAge = 0;
        /// <summary>
        /// Gets or sets the age
        /// </summary>
        public int Age
        {
            get
            {
                return mAge;
            }
            set
            {
                if (value > 200)
                {
                    mAge = 200;
                }
                else
                {
                    mAge = value;
                }

            }
        }
        //public int GetAge()
        //{
        //    return mAge;
        //}
        //public void SetAge(int nAge)
        //{
        //    mAge = nAge;
        //}

        //public int ReadOnlyAge
        //{
        //    get
        //    {
        //        return mAge;
        //    }
        //}
    }
}
