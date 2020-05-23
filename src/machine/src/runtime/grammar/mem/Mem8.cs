//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Mem8 : IMemory8<Mem8>
    {
        [MethodImpl(Inline)]
        public Mem8(byte src)
        {
            Data = src;
        }
        
        public byte Data {get;}

        public DataWidth Width => DataWidth.W8;
    }
}