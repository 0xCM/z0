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

    partial class Hex
    {
        /// <summary>
        /// Returns the hex character code for a number in the interval [0,15]
        /// </summary>
        /// <param name="n">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static byte code(UpperCased upper, byte n)
            => skip(in first(UpperDigits), (byte)(n & 0xf));

        /// <summary>
        /// Returns the hex character code for a number in the interval [0,15]
        /// </summary>
        /// <param name="n">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static byte code(LowerCased lower, byte n)
            => skip(in first(LowerDigits), (byte)(n & 0xf));
    }
}