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

    partial struct BitFlow
    {
        [ApiHost("bitflow.parsers")]
        public readonly partial struct Parsers
        {
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static BitsParser<T> bits<T>()
                where T : unmanaged
                    => default;
        }
    }
}