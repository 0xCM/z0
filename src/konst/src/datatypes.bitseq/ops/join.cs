//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial struct BitSeq
    {

        /// <summary>
        /// (a,b) -> [ab]
        /// </summary>
        /// <param name="a">Source bit 0</param>
        /// <param name="b">Source bit 1</param>
        [MethodImpl(Inline), Op]
        public static uint3 join(uint1 a, uint1 b, uint1 c)
            => (uint3)a | ((uint3)b << 1) | ((uint3)c << 2);


    }
}