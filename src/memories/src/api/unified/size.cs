//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [MethodImpl(Inline)]
        public static int size<T>()
            => Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        public static int size<T>(T t)
            => Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        public static ulong usize<T>()
            => (ulong)Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        public static ulong usize<T>(T t)
            => (ulong)Unsafe.SizeOf<T>();

    }
}