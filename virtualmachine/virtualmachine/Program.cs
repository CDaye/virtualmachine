using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualmachine
{
    class Program
    {
        static CPU m_cpu;
        static BIOS m_BIOS;
        static void Main(string[] args)
        {
            m_BIOS = new BIOS();
            m_cpu = new CPU(m_BIOS);
            bool running = true;
            while (running)
            {
                m_cpu.Tick();
            }
        }
    }
}
