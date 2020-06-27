//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static PrimalKindBitField BitField(this PrimalKind src)
            => new PrimalKindBitField(src);

        [MethodImpl(Inline)]
        public static PrimalKindBitField BitField(this PrimalLiteralKind src)
            => new PrimalKindBitField(src);
    }
}