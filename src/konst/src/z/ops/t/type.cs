//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Type type<T>()
            => sys.type<T>();

        [MethodImpl(Inline), Op]
        public static Type type(NumericKind nk)
            => NumericKinds.type(nk);
    }
}