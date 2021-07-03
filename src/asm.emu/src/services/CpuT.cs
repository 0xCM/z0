//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class Cpu<T> : Cpu
        where T : unmanaged
    {
        Index<CpuCore<T>> _Cores;

        [MethodImpl(Inline)]
        internal Cpu(CpuCore<T>[] cores)
        {
            _Cores = cores;
        }

        public CpuCore<T> Core(uint id)
        {
            return _Cores[id];
        }
    }
}