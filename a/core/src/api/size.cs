//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static int size<T>()
            => Unsafe.SizeOf<T>();


        [MethodImpl(Inline)]
        public static int size<T>(T t)
            => Unsafe.SizeOf<T>();

    }
}