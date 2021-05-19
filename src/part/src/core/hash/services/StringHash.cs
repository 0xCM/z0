//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct StringHash : IHashFunction<string,uint>
    {
        [MethodImpl(Inline)]
        public uint Compute(in string src)
            => alg.hash.marvin(bytes(src));
    }
}