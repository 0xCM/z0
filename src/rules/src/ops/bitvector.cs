//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op]
        public static Declaration<BitvectorType> bitvector(string name, uint width)
            => new Declaration<BitvectorType>(name, new BitvectorType(width));
    }
}