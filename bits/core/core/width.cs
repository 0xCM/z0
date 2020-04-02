//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Core;
    
    partial class Bits
    {
        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static int width(byte src)
            => 8 - nlz(src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static int width(ushort src)
            => 16 - nlz(src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static int width(uint src)
            => 32 - nlz(src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static int width(ulong src)
            => 64 - nlz(src);
    }
}