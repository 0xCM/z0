//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryOffsets : IConstIndex<MemoryOffset>
    {
        readonly MemoryOffset[] Offsets;
        
        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, byte offset)
            => new MemoryOffset(@base, offset, NumericWidth.W8);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, ushort offset)
            => new MemoryOffset(@base, offset, NumericWidth.W16);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, uint offset)
            => new MemoryOffset(@base, offset, NumericWidth.W32);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, ulong offset)
            => new MemoryOffset(@base, offset, NumericWidth.W64);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, MemoryAddress src)
        {
            var delta = src - @base;

            if(delta <= byte.MaxValue)
                return offset(@base, (byte)delta);
            else if(delta <= ushort.MaxValue)
                return offset(@base, (ushort)delta);
            else if(delta <= uint.MaxValue)
                return offset(@base, (uint)delta);
            else
                return offset(@base, (ulong)delta);
        }        
        
        [MethodImpl(Inline)]
        public static implicit operator MemoryOffsets(MemoryOffset[] src)
            => new MemoryOffsets(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryOffsets(ReadOnlySpan<MemoryOffset> src)
            => new MemoryOffsets(src.ToArray());

        [MethodImpl(Inline)]
        public static implicit operator MemoryOffsets(Span<MemoryOffset> src)
            => new MemoryOffsets(src.ToArray());

        [MethodImpl(Inline)]
        public MemoryOffsets(MemoryOffset[] src)
            => Offsets = src;

        public ReadOnlySpan<MemoryOffset> Content
        {
            [MethodImpl(Inline)]
            get => Offsets;
        }

        public ref readonly MemoryOffset this[int index]
        {
            [MethodImpl(Inline)]
            get => ref z.skip(Content,(uint)index);
        }

        public ref readonly MemoryOffset this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref z.skip(Content,(uint)index);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Offsets.Length;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Offsets.Length;
        }
    }
}