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

    /// <summary>
    /// Defines an indexed view over <see cref='SegRef'/> values
    /// </summary>
    public readonly struct MemorySlots
    {
        public static string[] format<E>(MemorySlots<E> src)
            where E : unmanaged, Enum
        {
            var dst = sys.alloc<string>(src.Length);
            format(src,dst);
            return dst;
        }

        public static void format<E>(MemorySlots<E> src, Span<string> dst)
            where E : unmanaged, Enum
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