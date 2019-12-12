//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// Replicates source bits [from..to] a specified number of times subject to the constraints imposed by the replicant type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="from">The first source bit</param>
        /// <param name="to">The last source bit</param>
        /// <param name="reps">The number of times to clone the defined segment</param>
        [MethodImpl(Inline)]
        public static byte replicate(byte src, int from, int to, int reps)
        {
            var width = to - from;
            var pattern = extract(src, from, to);
            byte dst = 0;
            for(var i=0; i<reps; i++)
                dst |= (byte)(pattern << i*width);
            return dst;
        }

        /// <summary>
        /// Replicates source bits [from..to] a specified number of times subject to the constraints imposed by the replicant type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="from">The first source bit</param>
        /// <param name="to">The last source bit</param>
        /// <param name="reps">The number of times to clone the defined segment</param>
        [MethodImpl(Inline)]
        public static ushort replicate(ushort src, int from, int to, int reps)
        {
            var width = to - from;
            var pattern = extract(src, from, to);
            ushort dst = 0;
            for(var i=0; i<reps; i++)
                dst |= (ushort)(pattern << i*width);
            return dst;
        }

        /// <summary>
        /// Replicates source bits [from..to] a specified number of times subject to the constraints imposed by the replicant type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="from">The first source bit</param>
        /// <param name="to">The last source bit</param>
        /// <param name="reps">The number of times to clone the defined segment</param>
        [MethodImpl(Inline)]
        public static uint replicate(uint src, int from, int to, int reps)
        {
            var width = to - from;
            var pattern = extract(src, from, to);
            var dst = 0u;
            for(var i=0; i<reps; i++)
                dst |= (pattern << i*width);
            return dst;
        }

        /// <summary>
        /// Replicates source bits [from..to] a specified number of times subject to the constraints imposed by the replicant type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="from">The first source bit</param>
        /// <param name="to">The last source bit</param>
        /// <param name="reps">The number of times to clone the defined segment</param>
        [MethodImpl(Inline)]
        public static ulong replicate(ulong src, int from, int to, int reps)
        {
            var width = to - from + 1;
            var pattern = extract(src, from, width);
            var dst = pattern;
            for(var i=1; i<reps; i++)
                dst |= (pattern << i*width);
            return dst;
        }
    }
}