//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// The bits found at the end of a uri
    /// </summary>
    public readonly struct UriBits : IUriCode<UriBits,BinaryCode>
    {
        /// <summary>
        /// No code, no identity, no life
        /// </summary>
        public static UriBits Empty => new UriBits(OpUri.Empty, BinaryCode.Empty);

        /// <summary>
        /// The encoded operation data
        /// </summary>
        public BinaryCode Encoded {get;}

        /// <summary>
        /// An identifier populated with parsed operation uri text, when possible; otherwise populated with unparseable uri text 
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The operation uri
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The identifier of the defined operation
        /// </summary>
        public OpIdentity Id { [MethodImpl(Inline)] get  => Uri.OpId; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public ReadOnlySpan<byte> Bytes  { [MethodImpl(Inline)] get => Encoded.Bytes; }

        [MethodImpl(Inline)]
        public static UriBits Define(OpUri uri, BinaryCode src)
            => new UriBits(uri,src);

        /// <summary>
        /// Defines uri bits with a potentially bad uri (for diagnostic purposes)
        /// </summary>
        /// <param name="perhaps">The uri, perhaps</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UriBits Define(ParseResult<OpUri> perhaps, BinaryCode src)
            => perhaps.MapValueOrSource(
                    uri => new UriBits(uri,src), 
                    baduri => new UriBits(baduri, src)
                    );

        [MethodImpl(Inline)]
        public UriBits(OpUri uri, BinaryCode src)
        {
            this.Uri = uri;
            this.Encoded = src;
            this.Identifier = uri.IdentityText;
        }

        [MethodImpl(Inline)]
        UriBits(string baduri, BinaryCode src)
        {
            Identifier = baduri;
            Uri = OpUri.Empty;
            Encoded = src;
        }

        [MethodImpl(Inline)]
        public bool Equals(UriBits src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => text.concat(Uri.IdentityText, text.spaces(5), Encoded.Format());

        public string Format(int uripad)
            => text.concat(Uri.IdentityText.PadRight(uripad), Encoded.Format());            
    }
}