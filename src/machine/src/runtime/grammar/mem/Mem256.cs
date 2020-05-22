//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public readonly struct Mem256 : IMemory256<Mem256>
    {
        [MethodImpl(Inline)]
        public Mem256(Vector256<byte> src)
        {
            Value = src;
        }

        public Vector256<byte> Value {get;}

        public DataWidth Width => DataWidth.W256;
    }
}