//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        [MethodImpl(Inline), Op]
        public static Decl<Bitvector> bitvector(Identifier name, BitWidth width)
            => new Decl<Bitvector>(name, new Bitvector(width));
    }
}