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
    /// Defines a reference to an immutable character sequence
    /// </summary>
    public unsafe readonly struct ConstWord
    {
        readonly MemoryAddress Base;

        public uint Length {get;}

        [MethodImpl(Inline)]
        internal ConstWord(MemoryAddress @base, uint length)
        {
            Base = @base;
            Length = length;
        }

        public ref readonly char this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<char>(), index);
        }

        public ref readonly char this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<char>(), index);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<char>();
        }

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => cover<char>(Base.Pointer<char>(), Length);
        }

        public string Format()
            => strings.format(this);


        public override string ToString()
            => Format();
    }
}