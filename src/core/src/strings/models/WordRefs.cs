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
    public unsafe struct WordRefs
    {
        readonly MemoryAddress BaseAddress;

        /// <summary>
        /// The maximum number of symbols in the string
        /// </summary>
        public uint Length {get;}

        [MethodImpl(Inline)]
        public WordRefs(ReadOnlySpan<char> src)
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
        public WordRef Word(ulong index, ulong length)
            => strings.word(this, index, length);

        [MethodImpl(Inline)]
        public WordRef Word(long index, long length)
            => strings.word(this, index, length);

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

        public WordRef this[long offset, long length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        public WordRef this[ulong offset, ulong length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        public string Format()
            => strings.format(this);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator WordRefs(ReadOnlySpan<char> src)
            => new WordRefs(src);

        [MethodImpl(Inline)]
        public static implicit operator WordRefs(string src)
            => new WordRefs(src);
    }
}