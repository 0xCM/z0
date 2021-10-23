//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a reference to a mutable S-sequence
    /// </summary>
    public unsafe readonly struct Word<S>
        where S : unmanaged
    {
        readonly MemoryAddress Base;

        [MethodImpl(Inline)]
        internal Word(MemoryAddress @base, uint length)
        {
            Base = @base;
            Length = length;
        }

        public uint Length {get;}

        public ref S this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<S>(), index);
        }

        public ref S this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<S>(), index);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<S>();
        }

        public Span<S> Edit
        {
            [MethodImpl(Inline)]
            get => cover<S>(Base.Pointer<S>(), Length);
        }

        public ReadOnlySpan<S> View
        {
            [MethodImpl(Inline)]
            get => cover<S>(Base.Pointer<S>(), Length);
        }
    }
}