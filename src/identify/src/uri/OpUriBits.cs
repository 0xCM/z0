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
    /// Operation uri payload
    /// </summary>
    public readonly struct OpUriBits : IFormattable<OpUriBits>
    {
        public string Identifier {get;}

        /// <summary>
        /// The operation uri
        /// </summary>
        public readonly OpUri Op;

        /// <summary>
        /// The encoded operation bytes
        /// </summary>
        public readonly BinaryCode Bits;

        [MethodImpl(Inline)]
        public static OpUriBits Define(OpUri op, BinaryCode bits)
            => new OpUriBits(op,bits);

        [MethodImpl(Inline)]
        public static OpUriBits Define(ParseResult<OpUri> result, BinaryCode bits)
            => result.MapValueOrSource(uri => new OpUriBits(uri,bits), text => new OpUriBits(text, bits));

        [MethodImpl(Inline)]
        OpUriBits(OpUri uri, BinaryCode bits)
        {
            this.Op = uri;
            this.Bits = bits;
            this.Identifier = uri.Identifier;
        }

        [MethodImpl(Inline)]
        OpUriBits(string id, BinaryCode bits)
        {
            this.Op = OpUri.Empty;
            this.Bits = bits;
            this.Identifier = id;
        }

        public string Format()
            => text.concat(Op.Identifier, text.spaces(5), Bits.Format());

        public string Format(int uripad)
            => text.concat(Op.Identifier.PadRight(uripad), Bits.Format());            
    }
}