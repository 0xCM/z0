//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {
        [MethodImpl(Inline), Op]
        public static string @string(in StringRef src)                
            => sys.@string(data(src));
    }
}