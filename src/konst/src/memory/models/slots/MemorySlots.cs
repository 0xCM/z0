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

    [ApiHost(ApiNames.MemorySlots, true)]
    public readonly struct MemorySlots
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static MemorySlots<E> define<E>(Type src)
            where E : unmanaged
                => new MemorySlots<E>(from(src));

        [MethodImpl(Inline), Op]
        public static MemorySlots from(Type src)
            => ApiDynamic.jit(src).Map(m => new SegRef(m.Address, m.Size));

        [MethodImpl(Inline)]
        public static MemorySlots<E> from<E,T>(T src)
            where E : unmanaged, Enum
                => define<E>(typeof(T));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static MemorySlots<E> define<E>(params SegRef[] src)
            where E : unmanaged
                => new MemorySlots<E>(src);

        public static string[] format<E>(MemorySlots<E> src)
            where E : unmanaged
        {
            var dst = sys.alloc<string>(src.Length);
            format(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void format<E>(MemorySlots<E> src, Span<string> dst)
            where E : unmanaged
        {
            var count = src.Length;
            ref readonly var lead = ref src.Lookup(default(E));
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(lead,i).Format();
        }

        readonly SegRef[] Data;

        [MethodImpl(Inline)]
        public static implicit operator MemorySlots(SegRef[] src)
            => new MemorySlots(src);

        [MethodImpl(Inline)]
        public static implicit operator SegRef[](MemorySlots src)
            => src.Data;

        [MethodImpl(Inline)]
        public MemorySlots(SegRef[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly SegRef Lookup(int index)
            => ref Data[index];

        public ref readonly SegRef this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup((int)index);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}