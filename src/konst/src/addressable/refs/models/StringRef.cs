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

    using api = StringRefs;

    /// <summary>
    /// A string?
    /// </summary>
    public readonly struct StringRef : ITextual, IConstSpan<StringRef,char>
    {            
        internal readonly Vector128<ulong> Location;

        [MethodImpl(Inline)]
        public StringRef(in MemRef src)
            => Location = api.location(src);

        [MethodImpl(Inline)]
        public StringRef(MemoryAddress address, int length)
            => Location = api.location(address, length);

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
            get => (int)Hi/Scale;
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => z.@string(this);            
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Lo;
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
        /// Specifies the segment byte count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public uint DataSize 
        {
            [MethodImpl(Inline)]
            get => (uint)Hi;
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

        ulong Hi
        {
            [MethodImpl(Inline)]
            get => vcell(Location,1);
        }

        const byte Scale = 2;
   }
}