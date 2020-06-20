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
        /// <summary>
        /// Defines uri bits with a potentially bad uri (for diagnostic purposes)
        /// </summary>
        /// <param name="perhaps">The uri, perhaps</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UriHex From(ParseResult<OpUri> perhaps, BinaryCode src)
            => perhaps.MapValueOrSource(
                    uri => new UriHex(uri,src), 
                    baduri => new UriHex(baduri, src)
                    );

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

        [MethodImpl(Inline)]
        public UriHex(OpUri uri, BinaryCode src)
        {
            OpUri = uri;
            Encoded = src;
            Identifier = uri.UriText;
        }

        [MethodImpl(Inline)]
        UriHex(string baduri, BinaryCode src)
        {
            Identifier = baduri;
            OpUri = OpUri.Empty;
            Encoded = src;
        }

        /// <summary>
        /// The identifier of the defined operation
        /// </summary>
        public OpIdentity Id 
        { 
            [MethodImpl(Inline)] 
            get => OpUri.OpId; 
        }

        [MethodImpl(Inline)]
        public bool Equals(UriHex src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => text.concat(OpUri.UriText, text.spaces(5), Encoded.Format());

        public string Format(int uripad)
            => text.concat(OpUri.UriText.PadRight(uripad), Encoded.Format());            

        /// <summary>
        /// No code, no identity, no life
        /// </summary>
        public static UriHex Empty 
            => new UriHex(OpUri.Empty, BinaryCode.Empty);
    }
}