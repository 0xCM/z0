//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// The hex bits found at the end of a uri
    /// </summary>
    public readonly struct ApiExtractBlock : IComparable<ApiExtractBlock>
    {
        /// <summary>
        /// The operation uri
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The enExtractd operation data
        /// </summary>
        public ExtractBlock Extract {get;}

        [MethodImpl(Inline)]
        public ApiExtractBlock(MemoryAddress @base, OpUri uri, BinaryCode src)
        {
            Uri = uri;
            Extract = new ExtractBlock(@base, src);
        }

        [MethodImpl(Inline)]
        public ApiExtractBlock(OpUri uri, ExtractBlock src)
        {
            Uri = uri;
            Extract = src;
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Extract.Storage;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Extract.Storage;
        }

        /// <summary>
        /// The Extract's base address
        /// </summary>
        public MemoryAddress BaseAddress
        {
             [MethodImpl(Inline)]
             get => Extract.BaseAddress;
        }

        public OpIdentity OpId
        {
             [MethodImpl(Inline)]
             get => Uri.OpId;
        }

        /// <summary>
        /// An identifier populated with parsed operation uri text, when possible; otherwise populated with unparsed uri text
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
        /// The enExtractd operation data
        /// </summary>
        public readonly BinaryCode Encoded
        {
            [MethodImpl(Inline)]
            get => Extract;
        }

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Storage;
        }

        public uint Size
        {
            [MethodImpl(Inline)]
            get => (uint)Encoded.Length;
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
        public bool Equals(ApiExtractBlock src)
            => Encoded.Equals(src.Encoded);

        public string Format(int uripad)
            => text.concat(BaseAddress.Format(), Space, OpUri.UriText.PadRight(uripad), Space, Encoded.Format());

        public string Format()
            => Format(60);


        public override string ToString()
            => Format();

        public int CompareTo(ApiExtractBlock src)
            => BaseAddress.CompareTo(src.BaseAddress);

        /// <summary>
        /// No Extract, no identity, no life
        /// </summary>
        public static ApiExtractBlock Empty
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(ApiExtractBlock src)
            => src.Extract;

        [MethodImpl(Inline)]
        public static implicit operator ExtractBlock(ApiExtractBlock src)
            => src.Extract;
    }
}