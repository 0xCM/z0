//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        /// <summary>
        /// Allocates a bitspan with a specified length
        /// </summary>
        /// <param name="len">The length of the bitstring</param>
        [Op]
        public static BitSpan32 alloc32(int len)
            => new BitSpan32(sys.alloc<Bit32>(len));
    }
}