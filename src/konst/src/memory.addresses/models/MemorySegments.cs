//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Indexes a sequence of memory references
    /// </summary>
    public readonly struct MemorySegments
    {
        readonly MemorySegment[] Refs;

        [MethodImpl(Inline)]
        public MemorySegments(MemorySegment[] src)
            => Refs = src;

        [MethodImpl(Inline)]
        public static MemorySegments create(params MemorySegment[] src)
            => new MemorySegments(src);

        [MethodImpl(Inline)]
        public static MemorySegments create(MemoryAddress src, uint size)
            => create(new MemorySegment(src, size));

        public ReadOnlySpan<MemorySegment> View
        {
            [MethodImpl(Inline)]
            get => Refs;
        }

        public Span<MemorySegment> Edit
        {
            [MethodImpl(Inline)]
            get => Refs;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Refs.Length;
        }

        public ref MemorySegment this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Refs[index];
        }

        public ref MemorySegment this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Refs[index];
        }

        /// <summary>
        /// Loads the data tracked by an index-identified memory reference
        /// </summary>
        /// <param name="index">The ref index</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load(ulong index)
            => Refs[index].Load();
    }
}