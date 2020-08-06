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
    using static z;

    partial struct LiteralFields
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FieldValues<T> from<T>(Type src)
            where T : unmanaged
                => search<T>(src).Select(f => (f,sys.constant<T>(f)));

    }
}