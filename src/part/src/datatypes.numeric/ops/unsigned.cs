//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Numeric
    {
        /// <summary>
        /// This function exists to remediate, in certain situations, the compiler's blindly illogical devotion to signed 32-bit integers
        /// </summary>
        /// <param name="src">The source value that the compiler cannot interpret an unsigned 8-bit integer</param>
        [MethodImpl(Inline), Op]
        public static byte unsigned(byte src)
            => src;

        /// <summary>
        /// This function exists to remediate, in certain situations, the compiler's blindly illogical devotion to signed 32-bit integers
        /// </summary>
        /// <param name="src">The source value that the compiler cannot interpret an unsigned 16-bit integer</param>
        [MethodImpl(Inline), Op]
        public static ushort unsigned(ushort src)
            => src;
    }
}