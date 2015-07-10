using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualmachine
{
    class InstructionFetchUnit
    {
        BIOS m_BIOS;
        public InstructionFetchUnit(BIOS bios)
        {
            m_BIOS = bios;
        }
        public void Tick(Core m_core) 
        {
            int instruction = m_BIOS.GetData((int)m_core.m_isntructionPointer);
            m_core.m_isntructionPointer++;
        }
    }
}
