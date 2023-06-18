using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_List
{
    public class RandomList : List<string>
    {
        private Random random;
        public RandomList()
        {
            random = new Random();
        }
        public string RandomString()
        {
            return this[random.Next(0, this.Count)];
        }
    }
}
