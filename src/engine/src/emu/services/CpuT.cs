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
        Index<Core<T>> _Cores;

        [MethodImpl(Inline)]
        internal Cpu(Core<T>[] cores)
        {
            _Cores = cores;
        }

        public Core<T> Core(uint id)
        {
            return _Cores[id];
        }

    }
}