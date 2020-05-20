//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public readonly struct Mem128 : IMemory128<Mem128>
    {
        [MethodImpl(Inline)]
        public Mem128(Vector128<byte> src)
        {
            Value = src;
        }

        public Vector128<byte> Value {get;}

        public DataWidth Width => DataWidth.W128;
    }
}