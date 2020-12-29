//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static z;

    /// <summary>
    /// A string?
    /// </summary>
    public readonly struct StringRef : ITextual, IConstSpan<StringRef,char>
    {
        internal readonly Vector128<ulong> Data;

        [MethodImpl(Inline)]
        public StringRef(in MemorySegment src)
            => Data = MemRefs.location(src);

        [MethodImpl(Inline)]
        public StringRef(MemoryAddress address, uint length, uint user = 0)
            => Data = MemRefs.pack(address, length, user);

        [MethodImpl(Inline)]
        public StringRef(Vector128<ulong> data)
            => Data = data;

        [MethodImpl(Inline)]
        public StringRef(Cell128 data)
            => Data = data;

        public Vector128<ulong> Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// The length of the represented string
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)MemRefs.length<char>(Data);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Length;
        }

        public uint User
        {
            [MethodImpl(Inline)]
            get => MemRefs.user(Data);
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => View.ToString();
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => MemRefs.location(Data);
        }

        public ref readonly char this[int index]
        {
            [MethodImpl(Inline)]
            get => ref skip(View,(uint)index);
        }

        /// <summary>
        /// The string content presented as a readonly span
        /// </summary>
        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => view(this);
        }

        /// <summary>
        /// The string content presented as a mutable span
        /// </summary>
        public Span<char> Edit
        {
            [MethodImpl(Inline)]
            get => edit(this);
        }

        /// <summary>
        /// The string content presented as a span
        /// </summary>
        ReadOnlySpan<char> IConstSpan<StringRef,char>.Data
        {
            [MethodImpl(Inline)]
            get => view(this);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length != 0;
        }

        public StringRef Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public static StringRef Empty
        {
            [MethodImpl(Inline)]
            get => empty();
        }

        [MethodImpl(Inline), Op]
        public static StringRef empty()
            => new StringRef(MemorySegment.Empty);

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(MemorySegment src)
            => new StringRef(src);

        [MethodImpl(Inline)]
        public static implicit operator string(StringRef src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(string src)
            => @ref(src);
   }
}