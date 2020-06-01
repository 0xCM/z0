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

    public readonly struct MemOp256 : IMemOp256<MemOp256>
    {
        [MethodImpl(Inline)]
        public MemOp256(Vector256<byte> src)
        {
            Data = src;
        }

        public Vector256<byte> Data {get;}

        public DataWidth Width => DataWidth.W256;
    }
}