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
    public readonly struct X86UriHex : IX86ApiMember<X86UriHex,BinaryCode>
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
        public static implicit operator BinaryCode(X86UriHex src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator X86Code(X86UriHex src)
            => new X86Code(src.Base, src.Code);

        [MethodImpl(Inline)]
        public X86UriHex(MemoryAddress @base, OpUri uri, BinaryCode src)
        {
            Base = @base;
            Uri = uri;
            Code = src;
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
        public bool Equals(X86UriHex src)
            => Encoded.Equals(src.Encoded);

        public string Format(int uripad)
            => text.concat(Base.Format(), Space, OpUri.UriText.PadRight(uripad), Space, Encoded.Format());

        public string Format()
            => Format(60);


        public override string ToString()
            => Format();

        /// <summary>
        /// No code, no identity, no life
        /// </summary>
        public static X86UriHex Empty
            => new X86UriHex(MemoryAddress.Empty, OpUri.Empty, BinaryCode.Empty);
    }
}