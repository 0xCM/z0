//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Mem16 : IMemory16<Mem16>        
    {
        [MethodImpl(Inline)]
        public Mem16(ushort src)
        {
            Value = src;
        }

        public ushort Value {get;}

        public DataWidth Width => DataWidth.W16;
    }
}