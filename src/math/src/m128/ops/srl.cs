//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Math128
    {
        /// <summary>
        /// Shifts the source integer leftwards
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        /// <param name="offset">The number of bits to shift letward</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Srl]
        public static ConstPair<ulong> srl(in ConstPair<ulong> x, byte offset)
            => offset < 64
              ?  Tuples.@const((x.Right >> offset), (x.Left >> offset) | ((x.Right << 1) << 63 - offset))
              : offset < 128
              ? Tuples.@const(z64, x.Left >> (offset - 64))
              : ConstPair.zero(z64);

    }
}