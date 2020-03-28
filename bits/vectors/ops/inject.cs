//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;    

    partial class BitVector
    {
        /// <summary>
        /// Creates a 4-bit vector directly from the source data, bypassing masked initialization
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        internal static BitVector4 inject(N4 n, byte data)
            => new BitVector4(data,true);
    }
}