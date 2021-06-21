//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.Vector128;
    using static Root;
    using static core;

    /// <summary>
    /// A reference to a (hopefully) interned or resource string
    /// </summary>
    [ApiHost]
    public unsafe readonly struct StringRef : ITextual
    {
        readonly Vector128<ulong> Data;

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='MemoryAddress'/> and memory size
        /// </summary>
        /// <param name="address">The reference address</param>
        /// <param name="length">The size, in bytes, of the segment</param>
        [MethodImpl(Inline), Op]
        public static StringRef create(MemoryAddress address, ByteSize size)
            => new StringRef(address, size);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='string'/>
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="user">The user data, if any</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef create(string src)
            => create((ulong)pchar(src), (uint)src.Length*2);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='MemorySeg'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static StringRef create(MemorySeg src)
            => create(src.BaseAddress, (ulong)src.Size);

        /// <summary>
        /// Reveals the character data identified by a string reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> view(in StringRef src)
            => cover<byte>(src.BaseAddress.Pointer<byte>(), src.Size);

        /// <summary>
        /// Reveals the character data identified by a string reference as a mutable span
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        static unsafe Span<byte> edit(in StringRef src)
            => cover<byte>(src.BaseAddress.Pointer<byte>(), src.Size);

        [MethodImpl(Inline)]
        StringRef(MemoryAddress address, ByteSize size)
            => Data = Create((ulong)address, (ulong)size);

        /// <summary>
        /// The size, in bytes, of the represented string
        /// </summary>
        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Data.GetElement(1);
        }

        /// <summary>
        /// The string content presented as a readonly span
        /// </summary>
        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => view(this);
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => TextTools.format(recover<char>(View));
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Data.GetElement(0);
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref skip(View, index);
        }

        public ref readonly byte this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref skip(View, index);
        }

        /// <summary>
        /// The string content presented as a mutable span
        /// </summary>
        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => edit(this);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Size != 0;
        }

        public StringRef Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public static StringRef Empty
        {
            [MethodImpl(Inline)]
            get => new StringRef(MemoryAddress.Zero, ByteSize.Zero);
        }


        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(MemorySeg src)
            => new StringRef(src.BaseAddress, src.Size);

        [MethodImpl(Inline)]
        public static implicit operator string(StringRef src)
            => src.Text;

        [MethodImpl(Inline)]
        public static unsafe implicit operator StringRef(string src)
            => create(src);
   }
}