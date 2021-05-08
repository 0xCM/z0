//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Numeric
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NumericIndicator indicator<T>()
            where T : unmanaged
                => NumericKinds.indicator(Numeric.kind<T>());

        [MethodImpl(Inline), Op]
        public static NumericIndicator indicator(Type src)
            => NumericKinds.indicator(Numeric.kind(src));
    }
}