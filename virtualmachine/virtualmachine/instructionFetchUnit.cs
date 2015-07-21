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
        InstructionDispatchUnit m_instructionDispatchUnit;
        public InstructionFetchUnit(BIOS bios, InstructionDispatchUnit instructionDispatchUnit)
        {
            m_BIOS = bios;
            m_instructionDispatchUnit = instructionDispatchUnit;
        }
        public void Tick(Core m_core) 
        {
            int instruction = m_BIOS.GetData((int)m_core.m_instructionPointer);
            m_instructionDispatchUnit.SetInstruction(instruction);
            m_core.m_instructionPointer++;
        }
    }
}
