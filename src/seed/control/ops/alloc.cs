//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T[] alloc<T>(int count)
            => new T[count];
    }
}