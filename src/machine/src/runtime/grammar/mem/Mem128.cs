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

    public readonly struct Mem128 : IMemory128<Mem128>
    {
        [MethodImpl(Inline)]
        public Mem128(Vector128<byte> src)
        {
            Data = src;
        }

        public Vector128<byte> Data {get;}

        public DataWidth Width => DataWidth.W128;
    }
}