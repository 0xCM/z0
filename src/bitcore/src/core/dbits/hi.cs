//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
   
    partial class Bits
    {               
        /// <summary>
        /// Extracts the upper 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline), Op]
        public static byte hi(byte src)
            => (byte)(src >> 4);

        /// <summary>
        /// Extracts the upper 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte hi(ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static ushort hi(uint src)
            => (ushort)(src >> 16); 

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static uint hi(ulong src)
            => (uint)(src >> 32);
    }
}