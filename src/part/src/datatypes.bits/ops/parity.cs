//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct bit
    {
        /// <summary>
        /// Defines a parity index j from a source integer i and a parity bit p, j := i*2 + p
        /// </summary>
        /// <param name="i">The source integer</param>
        /// <param name="p">The parity bit</param>
        [MethodImpl(Inline), Op]
        public static byte parity(uint i, bit p)
            => (byte)(i*2 + (uint)p);
    }
}