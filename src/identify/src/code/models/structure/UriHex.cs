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
    public readonly struct UriHex : IUriCode<UriHex,BinaryCode>
    {
        [MethodImpl(Inline)]
        public static UriHex Define(OpUri uri, BinaryCode src)
            => new UriHex(uri,src);

        /// <summary>
        /// No code, no identity, no life
        /// </summary>
        public static UriHex Empty 
            => new UriHex(OpUri.Empty, BinaryCode.Empty);

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
        public OpUri OpUri {get;}

        /// <summary>
        /// The identifier of the defined operation
        /// </summary>
        public OpIdentity Id { [MethodImpl(Inline)] get  => OpUri.OpId; }

        public ApiHostUri Host { [MethodImpl(Inline)] get => OpUri.Host; }

        public ReadOnlySpan<byte> Bytes  { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref Encoded.Head;}
        
        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref Encoded[index]; }

        /// <summary>
        /// Defines uri bits with a potentially bad uri (for diagnostic purposes)
        /// </summary>
        /// <param name="perhaps">The uri, perhaps</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UriHex Define(ParseResult<OpUri> perhaps, BinaryCode src)
            => perhaps.MapValueOrSource(
                    uri => new UriHex(uri,src), 
                    baduri => new UriHex(baduri, src)
                    );

        [MethodImpl(Inline)]
        public UriHex(OpUri uri, BinaryCode src)
        {
            this.OpUri = uri;
            this.Encoded = src;
            this.Identifier = uri.UriText;
        }

        [MethodImpl(Inline)]
        UriHex(string baduri, BinaryCode src)
        {
            Identifier = baduri;
            OpUri = OpUri.Empty;
            Encoded = src;
        }

        [MethodImpl(Inline)]
        public bool Equals(UriHex src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => text.concat(OpUri.UriText, text.spaces(5), Encoded.Format());

        public string Format(int uripad)
            => text.concat(OpUri.UriText.PadRight(uripad), Encoded.Format());            
    }
}