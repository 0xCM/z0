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
        [MethodImpl(Inline)]
        public static T ones<T>()
            where T : unmanaged
                => NumericLiterals.ones<T>();
    }
}