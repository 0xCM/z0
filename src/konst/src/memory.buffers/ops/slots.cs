//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Buffers
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemorySlots<E> slots<E>(Type src)
            where E : unmanaged
                => new MemorySlots<E>(slots(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemorySlots<E> slots<E>(params SegRef[] src)
            where E : unmanaged
                => new MemorySlots<E>(src);

        [MethodImpl(Inline), Op]
        public static MemorySlots slots(Type src)
            => ClrDynamic.jit(src).Map(m => new SegRef(m.Address, m.Size));

        [MethodImpl(Inline)]
        public static MemorySlots<E> slots<E,T>(T src)
            where E : unmanaged, Enum
                => slots<E>(typeof(T));
    }
}