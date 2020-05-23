//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    [ApiHost]
    public readonly struct MemoryOffsets : IApiHost<MemoryOffsets>, IReadOnlyIndex<MemoryOffset>
    {
        readonly MemoryOffset[] Offsets;
        
        [Op, MethodImpl(Inline)]
        public static MemoryOffsets from(params MemoryOffset[] src)
            => new MemoryOffsets(src);

        [Op, MethodImpl(Inline)]
        public static MemoryOffset define(MemoryAddress @base, byte offset)
            => new MemoryOffset(@base, offset, NumericWidth.W8);

        [Op, MethodImpl(Inline)]
        public static MemoryOffset define(MemoryAddress @base, ushort offset)
            => new MemoryOffset(@base, offset, NumericWidth.W16);

        [Op, MethodImpl(Inline)]
        public static MemoryOffset define(MemoryAddress @base, uint offset)
            => new MemoryOffset(@base, offset, NumericWidth.W32);

        [Op, MethodImpl(Inline)]
        public static MemoryOffset define(MemoryAddress @base, ulong offset)
            => new MemoryOffset(@base, offset, NumericWidth.W64);

        [Op, MethodImpl(Inline)]
        public static MemoryOffset from(MemoryAddress @base, MemoryAddress src)
        {
            var delta = src - @base;

            if(delta <= byte.MaxValue)
                return define(@base, (byte)delta);
            else if(delta <= ushort.MaxValue)
                return define(@base, (ushort)delta);
            else if(delta <= uint.MaxValue)
                return define(@base, (uint)delta);
            else
                return define(@base, delta);
        }

        [MethodImpl(Inline)]
        public static MemoryOffset legacy(MemoryAddress @base, MemoryAddress relative)
        {
            var offset = @base.Location - relative.Location;
            if(offset <= byte.MaxValue)
                return define(@base, (byte)offset);
            else if(offset <= ushort.MaxValue)
                return define(@base, (ushort)offset);
            else if(offset <= uint.MaxValue)
                return define(@base, (uint)offset);
            else
                return define(@base, offset);
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
        MemoryOffsets(MemoryOffset[] src)
        {
            this.Offsets = src;
        }

        public ReadOnlySpan<MemoryOffset> Content
        {
            [MethodImpl(Inline)]
            get => Offsets;
        }

        public ref readonly MemoryOffset this[int index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Content,index);
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