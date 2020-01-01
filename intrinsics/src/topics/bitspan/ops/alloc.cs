//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

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