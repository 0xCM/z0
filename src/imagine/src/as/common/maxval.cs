//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T maxval<T>(T t = default)
            where T : unmanaged
                => NumericLiterals.maxval<T>();
    }
}