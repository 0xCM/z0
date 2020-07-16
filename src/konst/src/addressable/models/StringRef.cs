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
        public StringRef(in MemRef src)
            => Location = StringRefs.location(src);

        [MethodImpl(Inline)]
        public StringRef(MemoryAddress address, uint length, uint user = 0)
            => Location = StringRefs.pack(address, length, user);

        [MethodImpl(Inline)]
        internal StringRef(Vector128<ulong> data)
            => Location = data;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(MemRef src)
            => new StringRef(src);

        [MethodImpl(Inline)]
        public static implicit operator string(StringRef src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(string src)
            => z.@ref(src);

        /// <summary>
        /// The length of the represented string
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)StringRefs.length(Location);
        }

        public uint User
        {
            [MethodImpl(Inline)]
            get => StringRefs.user(Location);
        }
        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => z.@string(this);            
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get =>StringRefs.address(Location);
        }

        public ref readonly char this[int index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Data,(uint)index);
        }

        /// <summary>
        /// The string content presented as a span
        /// </summary>
        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => z.data(this);
        }

        /// <summary>
        /// The string content presented as a span
        /// </summary>
        ReadOnlySpan<char> IConstSpan<StringRef,char>.Data
        {
            [MethodImpl(Inline)]
            get => z.data(this);
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
            => new StringRef(MemRef.Empty);

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        ulong Lo
        {
            [MethodImpl(Inline)]
            get => vcell(Location,0);
        }
    
   }
}