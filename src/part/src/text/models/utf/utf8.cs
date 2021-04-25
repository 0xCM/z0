//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = TextEncoders;

    [ApiComplete]
    public readonly struct utf8 : IDataTypeComparable<utf8>
    {
        readonly BinaryCode Data;

        [MethodImpl(Inline)]
        public utf8(byte[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public utf8(BinaryCode src)
            => Data = src;

        [MethodImpl(Inline)]
        public utf8(string src)
            => Data = api.GetUtf8Bytes(src);

        [MethodImpl(Inline)]
        public utf8(char[] src)
            => Data = api.GetUtf8Bytes(src);

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.marvin(Data);
        }

        [MethodImpl(Inline)]
        public bool Equals(utf8 src)
            => Data.View.SequenceEqual(src.Data.View);

        [MethodImpl(Inline), Ignore]
        public string Format()
            => IsNonEmpty ? api.DecodeUtf8(Data, out string _) : EmptyString;

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();

        public override bool Equals(object src)
          => src is utf8 x && Equals(x);

        [Ignore]
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

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(utf8 src)
            => src.Data;

        public static utf8 Empty
        {
            [MethodImpl(Inline)]
            get => new utf8(Array.Empty<byte>());
        }
    }
}