//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    partial class math
    {
        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static sbyte nonz(sbyte src, sbyte alt)
            => src != 0 ? alt : src;

        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static byte nonz(byte src, byte alt)
            => src != 0 ? alt : src;

        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static short nonz(short src, short alt)
            => src != 0 ? alt : src;

        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static ushort nonz(ushort src, ushort alt)
            => src != 0 ? alt : src;

        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static int nonz(int src, int alt)
            => src != 0 ? alt : src;

        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static uint nonz(uint src, uint alt)
            => src != 0 ? alt : src;

        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static long nonz(long src, long alt)
            => src != 0 ? alt : src;

        /// <summary>
        /// Defines the operator nonz(src,alt) := nonz(src) ? alt : src, returning the alternate 
        /// value if the nonz test succeeds and the source value otherwise
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="alt">The alternative value to return if the test succeeds</param>
        [MethodImpl(Inline), Op]
        public static ulong nonz(ulong src, ulong alt)
            => src != 0 ? alt : src;
    }
}