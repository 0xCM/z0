//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines encoded byte package for a uri-identified operation
    /// </summary>
    public readonly struct AsmOpData : IFormattable<AsmOpData>
    {
        [MethodImpl(Inline)]
        public static AsmOpData Define(OpUri uri, byte[] data)
            => new AsmOpData(uri,data);

        [MethodImpl(Inline)]
        public static AsmOpData Define(ParseResult<OpUri> result, byte[] data)
            => result.MapValueOrSource(uri => new AsmOpData(uri,data), text => new AsmOpData(text, data));

        [MethodImpl(Inline)]
        AsmOpData(OpUri uri, byte[] bytes)
        {
            this.Uri = uri;
            this.Bytes = bytes;
            this.Identifier = uri.Identifier;
        }

        [MethodImpl(Inline)]
        AsmOpData(string id, byte[] bytes)
        {
            this.Uri = OpUri.Empty;
            this.Bytes = bytes;
            this.Identifier = id;
        }

        /// <summary>
        /// The operation uri
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// The encoded operation bytes
        /// </summary>
        public readonly byte[] Bytes;

        public string Identifier {get;}

        public string Format()
            => text.concat(Uri.Identifier, text.spaces(5), Bytes.FormatHex());

        public string Format(int uripad)
            => text.concat(Uri.Identifier.PadRight(uripad), Bytes.FormatHex());
    }
}