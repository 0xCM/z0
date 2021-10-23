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
    /// Defines a character string over an embedded resource
    /// </summary>
    public unsafe struct EmbeddedWord
    {
        readonly MemoryAddress BaseAddress;

        /// <summary>
        /// The maximum number of symbols in the string
        /// </summary>
        public uint Length {get;}

        [MethodImpl(Inline)]
        public EmbeddedWord(ReadOnlySpan<char> src)
        {
            BaseAddress = address(first(src));
            Length = (uint)src.Length;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<char>();
        }

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => cover(BaseAddress.Pointer<char>(), Length);
        }

        [MethodImpl(Inline)]
        public MemoryAddress Address(ulong index)
            => address(skip(View,index));

        [MethodImpl(Inline)]
        public MemoryAddress Address(long index)
            => address(skip(View,index));

        [MethodImpl(Inline)]
        public ref readonly char Symbol(ulong index)
            => ref skip(View,index);

        [MethodImpl(Inline)]
        public ref readonly char Symbol(long index)
            => ref skip(View,index);

        [MethodImpl(Inline)]
        public ConstWord Substring(ulong index, ulong length)
            => strings.word(this,index,length);

        [MethodImpl(Inline)]
        public ConstWord Substring(long index, long length)
            => strings.word(this,index,length);

        public ref readonly char this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public ref readonly char this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public ConstWord this[long offset, long length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        public ConstWord this[ulong offset, ulong length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        public string Format()
            => strings.format(this);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator EmbeddedWord(ReadOnlySpan<char> src)
            => new EmbeddedWord(src);

        [MethodImpl(Inline)]
        public static implicit operator EmbeddedWord(string src)
            => new EmbeddedWord(src);
    }
}