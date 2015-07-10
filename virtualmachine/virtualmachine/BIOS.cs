using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualmachine
{
    class BIOS
    {
       int[] m_biosData;
       
        public BIOS() 
       {
           m_biosData = new int[] { 32, 49, 57, 64, 83 };
       }
        public int GetData(int address)
        {
            return m_biosData[address];
        }

    }
}
