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
    public readonly struct Segments
    {
        readonly SegRef[] Refs;

        [MethodImpl(Inline)]
        public Segments(SegRef[] src)
            => Refs = src;

        [MethodImpl(Inline)]
        public static Segments create(params SegRef[] src)
            => new Segments(src);

        [MethodImpl(Inline)]
        public static Segments create(MemoryAddress src, uint size)
            => create(new SegRef(src, size));

        public ReadOnlySpan<SegRef> View
        {
            [MethodImpl(Inline)]
            get => Refs;
        }

        public Span<SegRef> Edit
        {
            [MethodImpl(Inline)]
            get => Refs;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Refs.Length;
        }

        public ref SegRef this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Refs[index];
        }

        public ref SegRef this[ulong index]
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