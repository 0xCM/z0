//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryOffsets : IReadOnlyIndex<MemoryOffset>
    {
        readonly MemoryOffset[] Offsets;
        
        [MethodImpl(Inline)]
        public static MemoryOffset legacy(MemoryAddress @base, MemoryAddress relative)
        {
            var offset = @base.Location - relative.Location;
            if(offset <= byte.MaxValue)
                return Addresses.offset(@base, (byte)offset);
            else if(offset <= ushort.MaxValue)
                return Addresses.offset(@base, (ushort)offset);
            else if(offset <= uint.MaxValue)
                return Addresses.offset(@base, (uint)offset);
            else
                return Addresses.offset(@base, (ulong)offset);
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
        internal MemoryOffsets(MemoryOffset[] src)
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
            get => ref Root.skip(Content,index);
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