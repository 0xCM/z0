//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct CpuModels
    {
        public class CpuCore
        {
            public uint Number {get;}

            public CpuCore(uint id)
            {
                Number  = id;
            }
        }

        public class CpuCore<T> : CpuCore
            where T : unmanaged
        {
            public CpuCore(uint id)
                : base(id)
            {

            }
        }

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
}