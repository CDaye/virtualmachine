﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualmachine
{
    class Core
    {
       
        public uint m_instructionPointer;
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
            m_instructionPointer = 0;
            m_pipelineStage = PipelineStages.InstructionFetch;
            m_instructionDispatchUnit = new InstructionDispatchUnit();
            m_fetchUnit = new InstructionFetchUnit(m_BIOS, m_instructionDispatchUnit);
            m_nextStage = PipelineStages.InstructionFetch;
            m_arithmaticLogicUnit=new ArithmeticLogicUnit();
            m_loadUnit= new LoadUnit ();
            m_storeUnit = new StoreUnit();

                     
        }
                public void Tick()
        {
            m_fetchUnit.Tick(this);
            m_arithmaticLogicUnit.Tick();
            m_instructionDispatchUnit.Tick();
            m_loadUnit.Tick();
            m_storeUnit.Tick();
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
