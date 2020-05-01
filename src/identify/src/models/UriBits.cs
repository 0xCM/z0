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
    public readonly struct UriBits : ITextual<UriBits>
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
        public static UriBits Define(OpUri op, BinaryCode bits)
            => new UriBits(op,bits);

        [MethodImpl(Inline)]
        public static UriBits Define(ParseResult<OpUri> result, BinaryCode bits)
            => result.MapValueOrSource(uri => new UriBits(uri,bits), text => new UriBits(text, bits));

        [MethodImpl(Inline)]
        UriBits(OpUri uri, BinaryCode bits)
        {
            this.Op = uri;
            this.Bits = bits;
            this.Identifier = uri.Identifier;
        }

        [MethodImpl(Inline)]
        UriBits(string id, BinaryCode bits)
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