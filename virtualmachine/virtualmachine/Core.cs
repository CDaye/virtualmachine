using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualmachine
{
    class Core
    {
       
        public uint m_isntructionPointer;
        public PipelineStages m_pipelineStage;
        InstructionFetchUnit m_fetchUnit;
        public PipelineStages m_nextStage;
        BIOS m_BIOS;
        ArithmeticLogicUnit m_arithmaticLogicUnit;
        InstructionDispatchUnit m_instructionDispatchUnit;
        LoadUnit m_loadUnit;
        StoreUnit m_storeUnit;

        public Core(BIOS bios)
        {
            m_BIOS = bios;
            m_isntructionPointer = 0;
            m_pipelineStage = PipelineStages.InstructionFetch;
            m_fetchUnit = new InstructionFetchUnit(m_BIOS);
            m_nextStage = PipelineStages.InstructionFetch;
                     
        }
                public void Tick()
        {
            m_fetchUnit.Tick(this);
            m_pipelineStage = m_nextStage;
        }
    }
    enum PipelineStages
    {
        BranchPredict,
        InstructionFetch,
        InstructionDispatch,
        Execution,
        Retirement
    }
}
