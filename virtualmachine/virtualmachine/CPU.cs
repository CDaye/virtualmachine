using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualmachine
{

    class CPU
    {
        Core[] m_cores;
        public CPU()
        { 
            m_cores = new Core[1];
            m_cores[0] = new Core();
        }
        public void Tick()
        {
            m_cores[0].Tick();
                   }
        
    }
}
