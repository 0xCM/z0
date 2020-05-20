//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Mem8 : IMemory8<Mem8>
    {
        [MethodImpl(Inline)]
        public Mem8(byte src)
        {
            Value = src;
        }
        
        public byte Value {get;}

        public DataWidth Width => DataWidth.W8;
    }
}