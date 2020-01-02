//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {
        /// <summary>
        /// Computes a^(a >> offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static byte xorsr(byte a, int offset)
            => (byte)xorsr((uint)a, offset);

        /// <summary>
        /// Computes a^(a >> offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static ushort xorsr(ushort a, int offset)
            => (ushort)xorsr((uint)a, offset);

        /// <summary>
        /// Computes a^(a >> offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static uint xorsr(uint a, int offset)
            => a^(a >> offset);

        /// <summary>
        /// Computes a^(a >> offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static ulong xorsr(ulong a, int offset)
            => a^(a >> offset);

    }

}