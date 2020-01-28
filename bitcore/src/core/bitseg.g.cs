//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {    
        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by an inclusive position range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstpos">The sequence-relative position of the first bit</param>
        /// <param name="lastpos">The sequence-relative position of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static T bitseg<T>(Span<T> src, BitPos<T> firstpos, BitPos<T> lastpos)
            where T : unmanaged
        {
            var bitcount = lastpos - firstpos;
            if(bitcount > bitsize<T>())
                return gmath.maxval<T>();

            var sameSeg = firstpos.CellIndex == lastpos.CellIndex;
            var firstCount = uint8(sameSeg ? bitcount : bitsize<T>() - firstpos.BitOffset);
            var part1 = gbits.bitslice(cell(src,firstpos), (byte)firstpos.BitOffset, firstCount);
            
            if(sameSeg)
                return part1;
            else
            {
                var lastCount = uint8(bitcount - firstCount);
                return gmath.or(part1, gmath.sal(gbits.bitslice(cell(src,lastpos), 0, lastCount), firstCount));              
            }
        }

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by an inclusive position range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstpos">The sequence-relative position of the first bit</param>
        /// <param name="lastpos">The sequence-relative position of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static T bitseg<T>(in Block256<T> src, BitPos<T> firstpos, BitPos<T> lastpos)
            where T : unmanaged
                => bitseg(src.Data, firstpos,lastpos);

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by 
        /// an inclusive linear index range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstidx">The sequence-relative index of the first bit</param>
        /// <param name="lastidx">The sequence-relative index of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static T bitseg<T>(Span<T> src, int firstidx, int lastidx)
            where T : unmanaged
                => bitseg(src, bitpos<T>(firstidx), bitpos<T>(lastidx)); 

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by 
        /// an inclusive linear index range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstidx">The sequence-relative index of the first bit</param>
        /// <param name="lastidx">The sequence-relative index of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static T bitseg<T>(in Block256<T> src, int firstidx, int lastidx)
            where T : unmanaged
                => bitseg(src.Data, bitpos<T>(firstidx), bitpos<T>(lastidx)); 

    }
}