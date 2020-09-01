//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PrimalBitFieldSpec;

    partial struct Primitive
    {
        [MethodImpl(Inline), Op]
        public static PrimalKindId id(PrimalKindBitField f)
            => (PrimalKindId)select(f, SegId.KindId);        
    }
}