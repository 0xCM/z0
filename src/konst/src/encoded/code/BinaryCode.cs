//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.IO;

    using static Konst;

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    public readonly struct BinaryCode : IEncoded<BinaryCode,byte[]>
    {
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public byte[] Encoded {get;}

        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded;
        }

        /// <summary>
        /// Covers the encoded content with a readonly span
        /// </summary>
        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Encoded;
        }

        /// <summary>
        /// Covers the encoded content with a span
        /// </summary>
        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Encoded;
        }

        /// <summary>
        /// Returns a reference to the encoded data
        /// </summary>
        public Ref Ref
        {
            [MethodImpl(Inline)]
            get => memory.@ref(in this[0], (uint)Length);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded?.Length ?? 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Encoded[0] == 0);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public ref byte this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public ref byte this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        [MethodImpl(Inline)]
        public BinaryCode(byte[] bytes)
            => Encoded = z.insist(bytes);

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(Span<byte> src)
            => new BinaryCode(src.ToArray());

        [MethodImpl(Inline)]
        public static implicit operator byte[](BinaryCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(byte[] src)
            => new BinaryCode(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(BinaryCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static bool operator==(BinaryCode a, BinaryCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BinaryCode a, BinaryCode b)
            => !a.Equals(b);

        public bool Equals(BinaryCode src)
        {
            if(IsNonEmpty && src.IsNonEmpty)
                return Encoded.SequenceEqual(src.Encoded);
            else
            {
                if(Length == 0 && src.Length == 0)
                    return true;
                else
                    return false;
            }
        }

        public string Format()
            => Encoded.FormatHexBytes();

        public string Format(HexFormatConfig config)
            => Encoded.FormatHexBytes(config);

        public override int GetHashCode()
            => View.GetHashCode();

        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public EncodedStream Stream()
            => new EncodedStream(this);

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static BinaryCode Empty
            => new BinaryCode(sys.empty<byte>());
    }
}