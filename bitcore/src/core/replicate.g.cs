//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static Core;
    
   
    partial class gbits
    {                       
        /// <summary>
        /// Replicates an index-defined bitpattern a specified number of times
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The index of the first bit to include in the pattern</param>
        /// <param name="i1">The index of the last bit to include in the pattern</param>
        /// <param name="reps">The number of times to repeat the pattern</param>
        /// <typeparam name="T">The source/target type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T replicate<T>(T src, byte i0, byte i1, int reps)
            where T : unmanaged
                => convert<T>(Bits.replicate(convert<T,ulong>(src), i0, i1, reps));

        /// <summary>
        /// [000...000101] -> [101101...101101]
        /// Replicates a source bit pattern, determined by the most significant enabled bit,  throughout the range of the type
        /// </summary>
        /// <param name="src">The value defining the pattern to replicate</param>
        /// <typeparam name="T">The source/target type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T replicate<T>(T src)
            where T : unmanaged
        {         
            var index = (byte)msbpos(src);
            var count = (bitsize<T>() / (index + 1) +  1);
            var replicated = Bits.replicate(convert<T,ulong>(src), 0, index, count);
            return convert<T>(replicated);
        }

        /// <summary>
        /// Replicates the bit pattern defined by a byte either 2,4 or 8 times as determined by the primal target type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="t">A target type representative</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), NumericClosures(NumericKind.UnsignedInts)]
        public static T replicate<T>(byte src)
            where T : unmanaged
                => convert<T>(Bits.replicate((ulong)src, 0, 7, bitsize<T>() / 8));
    }
}