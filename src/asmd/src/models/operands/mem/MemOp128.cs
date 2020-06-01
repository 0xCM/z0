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

    public readonly struct MemOp128 : IMemOp128<MemOp128>
    {
        [MethodImpl(Inline)]
        public MemOp128(Vector128<byte> src)
        {
            Data = src;
        }

        public Vector128<byte> Data {get;}

        public DataWidth Width => DataWidth.W128;
    }
}