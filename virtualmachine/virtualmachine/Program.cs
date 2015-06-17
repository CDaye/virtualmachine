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
        static void Main(string[] args)
        {
            m_cpu = new CPU();
            bool running = true;
            while (running)
            {
                m_cpu.Tick();
            }
        }
    }
}
