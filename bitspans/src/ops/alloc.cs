//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Memories;

    partial struct BitSpan
    {
        /// <summary>
        /// Allocates a bitspan with a specified length
        /// </summary>
        /// <param name="len">The length of the bitstring</param>
        public static BitSpan alloc(int len)
            => new BitSpan(new bit[len]);
    }
}