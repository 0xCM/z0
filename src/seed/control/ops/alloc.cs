//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static T[] alloc<T>(int count)
            => new T[count];


        [MethodImpl(Inline)]
        public static T[] alloc<T>(ulong count)
            => new T[count];
    }
}