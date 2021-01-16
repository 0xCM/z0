//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Encoded;

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    public readonly struct BinaryCode : IComparable<BinaryCode>, ITextual, IEncoded
    {
        /// <summary>
        /// The encoded bytes
        /// </summary>
        readonly byte[] Data;

        [MethodImpl(Inline)]
        public BinaryCode(byte[] bytes)
            => Data = bytes;

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// Covers the encoded content with a readonly span
        /// </summary>
        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// Covers the encoded content with a span
        /// </summary>
        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// Returns a reference to the encoded data
        /// </summary>
        public SegRef Ref
        {
            [MethodImpl(Inline)]
            get => memory.segref(in memory.first(Data), (uint)Length);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Data[0] == 0);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public ref byte this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref byte this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }


        [MethodImpl(Inline)]
        public bool Equals(BinaryCode src)
            => equals(this,src);

        public string Format()
            => Data.FormatHexBytes();

        public string Format(HexFormatOptions config)
            => Data.FormatHexBytes(config);

        public override int GetHashCode()
            => View.GetHashCode();

        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public EncodedStream Stream()
            => new EncodedStream(this);

        public int CompareTo(BinaryCode src)
            => View.SequenceCompareTo(src.View);

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(Span<byte> src)
            => new BinaryCode(src.ToArray());

        [MethodImpl(Inline)]
        public static implicit operator byte[](BinaryCode src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(byte[] src)
            => new BinaryCode(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(BinaryCode src)
            => src.Data;

        [MethodImpl(Inline)]
        public static bool operator==(BinaryCode a, BinaryCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BinaryCode a, BinaryCode b)
            => !a.Equals(b);

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static BinaryCode Empty
            => new BinaryCode(Array.Empty<byte>());
    }
}