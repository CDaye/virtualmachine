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
            if (m_core.m_pipelineStage == PipelineStages.InstructionFetch)
            {
                int instruction = m_BIOS.GetData((int)m_core.m_instructionPointer);
                int instructionPart2 = m_BIOS.GetData((int)m_core.m_instructionPointer + 1);
                m_instructionDispatchUnit.SetInstruction(instruction, instructionPart2);
                m_core.m_instructionPointer += 2;
                m_core.m_nextStage = PipelineStages.InstructionDispatch;
            }
        }
    }
}
