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

    public unsafe struct WordRefs<S>
        where S : unmanaged
    {
        readonly MemoryAddress BaseAddress;

        /// <summary>
        /// The maximum number of symbols in the string
        /// </summary>
        public uint Length {get;}

        [MethodImpl(Inline)]
        public WordRefs(ReadOnlySpan<S> src)
        {
            BaseAddress = address(first(src));
            Length = (uint)src.Length;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<S>();
        }

        public ReadOnlySpan<S> View
        {
            [MethodImpl(Inline)]
            get => cover(BaseAddress.Pointer<S>(), Length);
        }

        [MethodImpl(Inline)]
        public MemoryAddress Address(ulong index)
            => address(skip(View,index));

        [MethodImpl(Inline)]
        public MemoryAddress Address(long index)
            => address(skip(View,index));

        [MethodImpl(Inline)]
        public ref readonly S Symbol(ulong index)
            => ref skip(View,index);

        [MethodImpl(Inline)]
        public ref readonly S Symbol(long index)
            => ref skip(View,index);

        [MethodImpl(Inline)]
        public WordRef<S> Word(ulong index, ulong length)
            => strings.word(this, index, length);

        [MethodImpl(Inline)]
        public WordRef<S> Word(long index, long length)
            => strings.word(this, index, length);

        public ref readonly S this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public ref readonly S this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public WordRef<S> this[long offset, long length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        public WordRef<S> this[ulong offset, ulong length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        public string Format()
            => strings.format(this);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator WordRefs<S>(ReadOnlySpan<S> src)
            => new WordRefs<S>(src);
    }
}