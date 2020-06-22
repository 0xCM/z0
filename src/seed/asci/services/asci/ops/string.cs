//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    partial struct asci
    {
        [MethodImpl(Inline)]
        public static string @string<A>(in A src)
            where A : unmanaged, IAsciSequence
                => src.Text;

        [MethodImpl(NotInline), Op]
        public static string @string(ReadOnlySpan<char> src)
            => new string(src);

    }
}