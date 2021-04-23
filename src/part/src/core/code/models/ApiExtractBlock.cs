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
        /// The Extract's base address
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The operation uri
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The enExtractd operation data
        /// </summary>
        public readonly BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public ApiExtractBlock(MemoryAddress @base, OpUri uri, BinaryCode src)
        {
            BaseAddress = @base;
            Uri = uri;
            Encoded = src;
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Encoded.Storage;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Encoded.View;
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
            => src.Encoded;
    }
}