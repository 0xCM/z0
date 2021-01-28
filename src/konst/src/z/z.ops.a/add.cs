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
        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, int count)
            => ref memory.add(src, count);

        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, uint count)
            => ref memory.add(src, count);

        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, byte count)
            => ref memory.add(src, count);

        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, ushort count)
            => ref memory.add(src, count);

        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, ulong count)
            => ref memory.add(src, count);
    }
}