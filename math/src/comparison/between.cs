//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;    
    
    partial class math
    {
        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(byte t, byte min, byte max)    
            => t >= min && t <= max;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(sbyte t, sbyte min, sbyte max)    
            => t >= min && t <= max;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(short t, short min, short max)    
            => t >= min && t <= max;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(ushort t, ushort min, ushort max)    
            => t >= min && t <= max;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(int t, int min, int max)    
            => t >= min && t <= max;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(uint t, uint min, uint max)    
            => t >= min && t <= max;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(long t, long min, long max)    
            => t >= min && t <= max;

        /// <summary>
         /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
       /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline),Between]
        public static bit between(ulong t, ulong min, ulong max)    
            => t >= min && t <= max;
    }
}