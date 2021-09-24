//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    unsafe partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static ScaledIndex scaled(W8 w, N4 n, sbyte dx, uint i)
            => new ScaledIndex(8, 4, dx, i);
    }
}