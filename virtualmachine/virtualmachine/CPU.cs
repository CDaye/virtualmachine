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
        BIOS m_BIOS;
        public CPU(BIOS bios)
        {
            m_cores = new Core[1];
            m_BIOS = bios;
            m_cores[0] = new Core(m_BIOS);
        }
        public void Tick()
        {
            m_cores[0].Tick();
                   }
        
    }
}
