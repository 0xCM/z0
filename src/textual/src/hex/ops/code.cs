//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static refs;
    using static HexSpecs;

    partial class Hex
    {
        /// <summary>
        /// Returns the hex character code for a number in the interval [0,15]
        /// </summary>
        /// <param name="value">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static byte code(byte value)
            => skip(in head(Uppercase), value & 0xf);
    }
}