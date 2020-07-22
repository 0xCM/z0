//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static Konst;

    partial class Bit
    {
        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Nlz]
        public static int nlz(byte src)
            => (int)(Lzcnt.LeadingZeroCount((uint)src) - 24);

        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Nlz]
        public static int nlz(ushort src)
            => (int)(Lzcnt.LeadingZeroCount((uint)src) - 16);

        /// <summary>
        /// _lzcnt_u32
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Nlz]
        public static int nlz(uint src)
            => (int)Lzcnt.LeadingZeroCount(src);

        /// <summary>
        /// _lzcnt_u64:
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Nlz]
        public static int nlz(ulong src)
            => (int)Lzcnt.X64.LeadingZeroCount(src);            
    }
}