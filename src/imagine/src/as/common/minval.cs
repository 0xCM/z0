//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsDeprecated
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T minval<T>(T rep = default)
            where T : unmanaged
                => NumericLiterals.minval<T>();
    }
}