//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct LiteralFields
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] values<T>(Type src)
            => z.map(search<T>(src),value<T>);        
    }
}