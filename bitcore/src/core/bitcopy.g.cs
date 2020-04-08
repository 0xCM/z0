//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class gbits
    {
        /// <summary>
        /// Overwrites a target bit segment dst[index..(start + count)] with a corresponding 
        /// segment src[index..(start + count)] in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The source/target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T bitcopy<T>(T src, byte index, byte count, T dst)
            where T : unmanaged
        {
            var dstidx = index;
            var sliced = bitslice(src, index, count);
            var cleared = gbits.bitclear(dst, dstidx, count);
            return gmath.or(cleared, gmath.sll(sliced, dstidx));            
        }

        /// <summary>
        /// Overwrites a target bit segment dst[index..(start + count)] with a corresponding 
        /// segment src[index..(start + count)] in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The source/target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref T bitcopy<T>(T src, byte index, byte count, ref T dst)
            where T : unmanaged
        {
            dst = bitcopy(src,index,count, dst);
            return ref dst;
        }

        /// <summary>
        /// Overwrites a target bit segment dst[dstidx..(dstidx + count)] with a corresponding 
        /// segment src[srcidx..(srcidx + count)] in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcidx">The source start index</param>
        /// <param name="dstidx">The target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T bitcopy<T>(T src, byte srcidx, byte dstidx, byte count, T dst)
            where T : unmanaged
        {
            var sliced = bitslice(src, srcidx, count);
            var cleared = gbits.bitclear(dst, dstidx, count);
            return gmath.or(cleared, gmath.sll(sliced, dstidx));            
        }

        /// <summary>
        /// Overwrites a target bit segment dst[dstidx..(dstidx + count)] with a corresponding 
        /// segment src[srcidx..(srcidx + count)] in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcidx">The source start index</param>
        /// <param name="dstidx">The target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref T bitcopy<T>(T src, byte srcidx, byte dstidx, byte count, ref T dst)
            where T : unmanaged
        {
            dst = bitcopy(src,srcidx, dstidx, count, dst);
            return ref dst;
        }
    }
}