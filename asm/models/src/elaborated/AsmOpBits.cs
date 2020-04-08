//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Defines encoded byte package for a uri-identified operation
    /// </summary>
    public readonly struct AsmOpBits : IFormattable<AsmOpBits>
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
        public static AsmOpBits Define(OpUri op, BinaryCode bits)
            => new AsmOpBits(op,bits);

        [MethodImpl(Inline)]
        public static AsmOpBits Define(ParseResult<OpUri> result, BinaryCode bits)
            => result.MapValueOrSource(uri => new AsmOpBits(uri,bits), text => new AsmOpBits(text, bits));

        [MethodImpl(Inline)]
        AsmOpBits(OpUri uri, BinaryCode bits)
        {
            this.Op = uri;
            this.Bits = bits;
            this.Identifier = uri.Identifier;
        }

        [MethodImpl(Inline)]
        AsmOpBits(string id, BinaryCode bits)
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