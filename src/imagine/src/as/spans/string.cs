//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op]
        public static string @string(ReadOnlySpan<char> src)
            => sys.@string(src); //@view<char,string>(first(src));
    }   
}