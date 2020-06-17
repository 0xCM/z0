//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitBlocks
    {
        /// <summary>
        /// Tests a bit value in a T-sequence predicated on a linear index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The linear index of the target bit, relative to the sequence head</param>
        /// <typeparam name="T">The sequence type</typeparam>
        [MethodImpl(Inline), TestBit, Closures(AllNumeric)]
        public static bit testbit<T>(in Block256<T> src, int index)
            where T : unmanaged
        {
            var loc = gbits.bitpos<T>(index);
            return gbits.testbit(src[loc.CellIndex], (byte)loc.BitOffset);
        }

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by an inclusive position range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstpos">The sequence-relative position of the first bit</param>
        /// <param name="lastpos">The sequence-relative position of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Extract, Closures(UnsignedInts)]
        public static T bitseg<T>(in Block256<T> src, BitPos<T> firstpos, BitPos<T> lastpos)
            where T : unmanaged
                => gbits.extract(src.Data, firstpos,lastpos);

        /// <summary>
        /// Sets a bit value in a T-sequence predicated on a linear index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The linear index of the target bit, relative to the sequence head</param>
        /// <typeparam name="T">The sequence type</typeparam>
        [MethodImpl(Inline), SetBit, Closures(AllNumeric)]
        public static void setbit<T>(in Block256<T> src, int index, bit value)
            where T : unmanaged
        {
            var loc = gbits.bitpos<T>(index);
            src[loc.CellIndex] = gbits.setbit(src[loc.CellIndex], (byte)loc.BitOffset, value);
        }

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by 
        /// an inclusive linear index range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstidx">The sequence-relative index of the first bit</param>
        /// <param name="lastidx">The sequence-relative index of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Extract, Closures(UnsignedInts)]
        public static T bitseg<T>(in Block256<T> src, int firstidx, int lastidx)
            where T : unmanaged
                => gbits.extract(src.Data, gbits.bitpos<T>(firstidx), gbits.bitpos<T>(lastidx));         
        /// <summary>
        /// Reads a cell determined by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        internal static ref readonly X readcell<X>(in X src, int bitpos)
            where X : unmanaged
                => ref skip(in src, bitpos / bitsize<X>()); 

        [MethodImpl(Inline)]
        internal static bit readbit<X>(in X src, int bitpos)
            where X : unmanaged   
                => gbits.testbit(readcell(in src, bitpos), (byte)(bitpos % bitsize<X>()));

        /// <summary>
        /// Reads/manipulates a cell identified by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        internal static ref X cell<X>(ref X src, int bitpos)
            where X : unmanaged
                => ref seek(ref src, bitpos / bitsize<X>()); 

        /// <summary>
        /// Sets the state of a grid bit identified by its linear position
        /// </summary>
        /// <param name="bitpos">The 0-based linear bit index</param>
        /// <param name="state">The source state</param>
        /// <param name="dst">A reference to the grid storage</param>
        /// <typeparam name="T">The grid storage segment type</typeparam>
        [MethodImpl(Inline)]
        internal static void setbit<X>(int bitpos, bit state, ref X dst)    
            where X : unmanaged
                => cell(ref dst, bitpos) = gbits.setbit(cell(ref dst, bitpos), (byte)(bitpos % bitsize<X>()), state);      

        /// <summary>
        /// Transfers span content to a bitblock without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The bitblock length representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> transfer<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitBlock<N,T>(src,true);
        
        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        public static bit modprod<T>(in BitBlock<T> x, in BitBlock<T> y)
            where T : unmanaged
        {
            var result = 0u;
            for(var i=0; i<x.BitCount; i++)
            {
                var a = (uint)x[i];
                var b = (uint)y[i];
                result += a*b;
            }
            return gmath.odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two natural bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod<N,T>(in BitBlock<N,T> x, in BitBlock<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => modprod(x.Unsize(),y.Unsize());

        /// <summary>
        /// Computes the number of primal cells required to cover a specified number of bits
        /// </summary>
        /// <param name="bitcount">The number of bits to cover</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static int cellcount<T>(int bitcount)
            where T : unmanaged
        {
            var q = Math.DivRem(bitcount, bitsize<T>(), out int r);            
            return r == 0 ? q : q + 1;
        }


   }
}