//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        [MethodImpl(Inline), Op]
        public static gbv<Cell128> bv(N128 n, uint width, Cell128 src)
            => new gbv<Cell128>(width, src);

        [MethodImpl(Inline), Op]
        public static gbv<Cell512> bv(N512 n, uint width, Cell512 src)
            => new gbv<Cell512>(width, src);

        [MethodImpl(Inline), Op]
        public static gbv<Cell256> bv(N256 n, uint width, Cell256 src)
            => new gbv<Cell256>(width, src);

    }
}