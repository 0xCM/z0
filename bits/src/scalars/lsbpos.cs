//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    partial class Bits
    {                 
        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int lsbpos(byte src)
            => ntz(src); //log2(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int lsbpos(ushort src)
            => ntz(src); //log2(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int lsbpos(uint src)
            => ntz(src);// log2(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int lsbpos(ulong src)
            => ntz(src); //log2(blsi(src));    


    }
}