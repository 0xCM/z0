//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Mem32 : IMemory32<Mem32>
    {
        [MethodImpl(Inline)]
        public Mem32(uint src)
        {
            Data = src;
        }

        public uint Data {get;}

        public DataWidth Width => DataWidth.W32;
    }
}