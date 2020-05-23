//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Mem64 : IMemory64<Mem64>
    {
        [MethodImpl(Inline)]
        public Mem64(ulong src)
        {
            Data = src;
        }

        public ulong Data {get;}

        public DataWidth Width => DataWidth.W64;
    }
}