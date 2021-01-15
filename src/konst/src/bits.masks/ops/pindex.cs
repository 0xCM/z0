//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitMasks
    {
        /// <summary>
        /// Defines a parity index j from a source integer i and a parity bit p, j := i*2 + p
        /// </summary>
        /// <param name="i">The source integer</param>
        /// <param name="p">The parity bit</param>
        [MethodImpl(Inline), Op]
        public static byte pindex(byte i, byte p)
            => ScalarCast.uint8(i*2 + p);
    }
}