//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op]
        public static Declaration<Bitvector> bitvector(string name, uint width)
            => new Declaration<Bitvector>(name, new Bitvector(width));
    }
}