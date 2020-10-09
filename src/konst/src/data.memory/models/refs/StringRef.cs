//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    /// <summary>
    /// A string?
    /// </summary>
    public readonly struct StringRef : ITextual, IConstSpan<StringRef,char>
    {
        internal readonly Vector128<ulong> Location;

        [MethodImpl(Inline)]
        public StringRef(in SegRef src)
            => Location = Refs.location(src);

        [MethodImpl(Inline)]
        public StringRef(MemoryAddress address, uint length, uint user = 0)
            => Location = Refs.pack(address, length, user);

        [MethodImpl(Inline)]
        internal StringRef(Vector128<ulong> data)
            => Location = data;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(SegRef src)
            => new StringRef(src);

        [MethodImpl(Inline)]
        public static implicit operator string(StringRef src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(string src)
            => @ref(src);

        /// <summary>
        /// The length of the represented string
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Refs.length<char>(Location);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Length;
        }

        public uint User
        {
            [MethodImpl(Inline)]
            get => Refs.user(Location);
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => View.ToString();
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Refs.location(Location);
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
            => new StringRef(SegRef.Empty);

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;
   }
}