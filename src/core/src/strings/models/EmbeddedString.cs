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
    /// Defines a string over S-symbols allocated over a native buffer
    /// </summary>
    public unsafe struct EmbeddedString
    {
        readonly MemoryAddress BaseAddress;

        /// <summary>
        /// The maximum number of symbols in the string
        /// </summary>
        public uint Length {get;}

        [MethodImpl(Inline)]
        public EmbeddedString(ReadOnlySpan<char> src)
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
        public ConstStringRef Substring(ulong index, ulong length)
            => strings.substring(this,index,length);

        [MethodImpl(Inline)]
        public ConstStringRef Substring(long index, long length)
            => strings.substring(this,index,length);

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

        public ConstStringRef this[long offset, long length]
        {
            [MethodImpl(Inline)]
            get => strings.substring(this, offset, length);
        }

        public ConstStringRef this[ulong offset, ulong length]
        {
            [MethodImpl(Inline)]
            get => strings.substring(this, offset, length);
        }

        [MethodImpl(Inline)]
        public static implicit operator EmbeddedString(ReadOnlySpan<char> src)
            => new EmbeddedString(src);

        [MethodImpl(Inline)]
        public static implicit operator EmbeddedString(string src)
            => new EmbeddedString(src);
    }
}