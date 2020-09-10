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

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static MemSlotView<E> slots<E>(Type src)
            where E : unmanaged, Enum
                => new MemSlotView<E>(slots(src));

        [MethodImpl(Inline)]
        public static MemSlotView<E> slots<E>(params SegRef[] src)
            where E : unmanaged, Enum
                => new MemSlotView<E>(src);

        [MethodImpl(Inline), Op]
        public static MemSlotView slots(Type src)
            => FunctionDynamic.jit(src).Map(m => new SegRef(m.Address, m.Size));

        public static MemSlotView<E> slots<E,T>(T src)
            where E : unmanaged, Enum
                => slots<E>(typeof(T));
    }
}