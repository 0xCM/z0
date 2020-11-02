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

    partial struct Sized
    {
        /// <summary>
        /// Shifts the source a rightwards by a specified bit count and shears the result to a specified width
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="n">The number of bits to shift</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 srl(byte src, N4 n, W4 w)
            => cut(Bytes.srl(src,4), w);
    }
}