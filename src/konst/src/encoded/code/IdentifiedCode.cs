//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// The hex bits found at the end of a uri
    /// </summary>
    public readonly struct IdentifiedCode : IIdentifiedCode<IdentifiedCode,BinaryCode>
    {
        /// <summary>
        /// The code's base address
        /// </summary>
        public readonly MemoryAddress Base;

        /// <summary>
        /// The operation uri
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// The encoded operation data
        /// </summary>
        public readonly BinaryCode Code;

        [MethodImpl(Inline)]
        public IdentifiedCode(MemoryAddress @base, OpUri uri, BinaryCode src)
        {
            Base = @base;
            Uri = uri;
            Code = src;
        }

        [MethodImpl(Inline)]
        public IdentifiedCode(OpUri uri, BinaryCode src)
        {
            Base = 0ul;
            Uri = uri;
            Code = src;
        }

        /// <summary>
        /// An identifier populated with parsed operation uri text, when possible; otherwise populated with unparseable uri text
        /// </summary>
        public readonly string Identifier
        {
             [MethodImpl(Inline)]
             get => Uri.UriText;
        }

        /// <summary>
        /// The operation uri
        /// </summary>
        public readonly OpUri OpUri
        {
            [MethodImpl(Inline)]
            get => Uri;
        }

        /// <summary>
        /// The encoded operation data
        /// </summary>
        public readonly BinaryCode Encoded
        {
            [MethodImpl(Inline)]
            get => Code;
        }

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }

        /// <summary>
        /// The identifier of the defined operation
        /// </summary>
        public OpIdentity Id
        {
            [MethodImpl(Inline)]
            get => Uri.OpId;
        }

        [MethodImpl(Inline)]
        public bool Equals(IdentifiedCode src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => text.concat(OpUri.UriText, text.spaces(5), Encoded.Format());

        public string Format(int uripad)
            => text.concat(OpUri.UriText.PadRight(uripad), Space, Base.Format(), Space, Encoded.Format());

        public override string ToString()
            => Format();

        /// <summary>
        /// No code, no identity, no life
        /// </summary>
        public static IdentifiedCode Empty
            => new IdentifiedCode(MemoryAddress.Empty, OpUri.Empty, BinaryCode.Empty);
    }
}