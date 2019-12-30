//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {
        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static byte xorsl(byte a, int offset)
            => (byte)xorsl((uint)a, offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static ushort xorsl(ushort a, int offset)
            => (ushort)xorsl((uint)a, offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static uint xorsl(uint a, int offset)
            => a^(a << offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static ulong xorsl(ulong a, int offset)
            => a^(a << offset);
    }
}