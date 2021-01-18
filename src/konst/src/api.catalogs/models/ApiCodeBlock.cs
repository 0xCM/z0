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
    public readonly struct ApiCodeBlock : IComparable<ApiCodeBlock>
    {
        /// <summary>
        /// The operation uri
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The encoded operation data
        /// </summary>
        public CodeBlock Code {get;}

        [MethodImpl(Inline)]
        public ApiCodeBlock(MemoryAddress @base, OpUri uri, BinaryCode src)
        {
            Uri = uri;
            Code = new CodeBlock(@base, src);
        }

        [MethodImpl(Inline)]
        public ApiCodeBlock(OpUri uri, CodeBlock code)
        {
            Code = code;
            Uri = uri;
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Code.Storage;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Code.Storage;
        }

        /// <summary>
        /// The code's base address
        /// </summary>
        public MemoryAddress BaseAddress
        {
             [MethodImpl(Inline)]
             get => Code.BaseAddress;
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
        public bool Equals(ApiCodeBlock src)
            => Encoded.Equals(src.Encoded);

        public string Format(int uripad)
            => text.concat(BaseAddress.Format(), Space, OpUri.UriText.PadRight(uripad), Space, Encoded.Format());

        public string Format()
            => Format(60);


        public override string ToString()
            => Format();

        public int CompareTo(ApiCodeBlock src)
            => BaseAddress.CompareTo(src.BaseAddress);

        /// <summary>
        /// No code, no identity, no life
        /// </summary>
        public static ApiCodeBlock Empty
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(ApiCodeBlock src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator CodeBlock(ApiCodeBlock src)
            => new CodeBlock(src.BaseAddress, src.Code);
    }
}