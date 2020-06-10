//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int size<T>()
            => Unsafe.SizeOf<T>();
    }
}