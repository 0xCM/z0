//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static PrimalBitFieldSpec;

    partial struct Primitive
    {
        [MethodImpl(Inline), Op]
        public static ref readonly SegPos index(SegId i)
            => ref skip(Positions, (byte)i);        
    }
}