//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    partial class Bits
    {                 
        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint posl(byte src)
            => log2(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint posl(ushort src)
            => log2(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint posl(uint src)
            => log2(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint posl(ulong src)
            => log2(blsi(src));    
    }
}