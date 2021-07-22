//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class CpuMachine<T>
        where T : unmanaged
    {
        public CpuModel<T> Cpu  {get;}

        public CpuMachine(CpuModel<T> cpu)
        {
            Cpu = cpu;
        }
    }
}