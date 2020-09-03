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

    partial struct Primal
    {
        [MethodImpl(Inline), Op]
        public static TypeCode code(PrimalKindBitField f)
            => (TypeCode)select(f, SegId.KindId);

    }
}