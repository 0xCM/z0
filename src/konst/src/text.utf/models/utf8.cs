//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [Datatype]
    public readonly struct utf8 : IDataTypeComparable<utf8>
    {
        static TextEncoding Encoder => TextEncoders.utf8();

        readonly byte[] Data;

        [MethodImpl(Inline)]
        public utf8(byte[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public utf8(string src)
            => Data = Encoder.GetBytes(src);

        [MethodImpl(Inline)]
        public utf8(char[] src)
            => Data = Encoder.GetBytes(src);

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == null || Data.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(Data);
        }

        [MethodImpl(Inline)]
        public bool Equals(utf8 src)
            => span(Data).SequenceEqual(src.Data);

        [MethodImpl(Inline)]
        public string Format()
            => IsNonEmpty ? Encoder.Decode(Data, out string _) : EmptyString;

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();

        public override bool Equals(object src)
          => src is utf8 x && Equals(x);

        public int CompareTo(utf8 src)
            => Format().CompareTo(src.Format());

        public static bool operator ==(utf8 a, utf8 b)
            => a.Equals(b);

        public static bool operator !=(utf8 a, utf8 b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator utf8(string src)
            => new utf8(src);

        [MethodImpl(Inline)]
        public static implicit operator string(utf8 src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator utf8(byte[] src)
            => new utf8(src);

        [MethodImpl(Inline)]
        public static implicit operator utf8(char[] src)
            => new utf8(src);

        [MethodImpl(Inline)]
        public static implicit operator utf8(BinaryCode src)
            => new utf8(src);

        public static utf8 Empty
        {
            [MethodImpl(Inline)]
            get => new utf8(Array.Empty<byte>());
        }
    }
}