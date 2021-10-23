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
    /// Defines a reference to an immutable S-sequence
    /// </summary>
    public unsafe readonly struct ConstWord<S>
        where S : unmanaged
    {
        readonly MemoryAddress Base;

        public uint Length {get;}

        [MethodImpl(Inline)]
        internal ConstWord(MemoryAddress @base, uint length)
        {
            Base = @base;
            Length = length;
        }

        public ref readonly S this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<S>(), index);
        }

        public ref readonly S this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<S>(), index);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<S>();
        }

        public ReadOnlySpan<S> View
        {
            [MethodImpl(Inline)]
            get => cover<S>(Base.Pointer<S>(), Length);
        }

        public string Format()
            => strings.format(this);


        public override string ToString()
            => Format();
    }
}