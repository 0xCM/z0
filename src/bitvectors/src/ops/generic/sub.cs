//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class BitVector
    {
        /// <summary>
        /// Computes the arithmetic difference z := x - y for generic bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Sub, Closures(Closure)]
        public static BitVector<T> sub<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.sub(x.State, y.State);

        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> sub<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.sub(x.State, y.State);


        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Srl, Closures(Closure)]
        public static BitVector<T> srl<T>(BitVector<T> x, byte offset)
            where T : unmanaged
                => gmath.srl(x.State,offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> srl<N,T>(BitVector<N,T> x, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.srl(x.State, offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> srl<N,T>(in BitVector128<N,T> x, byte offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vsrlx(x.State, offset);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Not, Closures(Closure)]
        public static BitVector<T> not<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.not(x.State);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> not<N,T>(BitVector<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => gmath.not(x.State);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> not<N,T>(in BitVector128<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => gcpu.vnot(x.State);

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), HiSeg, Closures(Closure)]
        public static BitVector<T> hiseg<T>(BitVector<T> x, byte n)
            where T : unmanaged
                => bitseg(x, (byte)(x.Width - n), (byte)(x.Width - 1));

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit modprod<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var result = 0;
            for(var i=0; i<x.Width; i++)
            {
                var a = x[i] ? 1 : 0;
                var b = y[i] ? 1 : 0;
                result += a*b;
            }
            return gmath.odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var result = 0u;
            for(var i=0; i<x.Width; i++)
                result += ((uint)x[i]*(uint)y[i]);
            return gmath.odd(result);
        }

        /// <summary>
        /// Computes the Hamming distance between two generic bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint hamming<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
            => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint hamming<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => pop(xor(x,y));

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Replicate, Closures(Closure)]
        public static BitVector<T> replicate<T>(BitVector<T> x)
            where T : unmanaged
                => x.State;

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> replicate<N,T>(BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.State;

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Reverse, Closures(Closure)]
        public static BitVector<T> reverse<T>(BitVector<T> x)
            where T : unmanaged
                => gbits.reverse(x.State);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> reverse<N,T>(BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.srl(gbits.reverse(src.State), (byte)(core.width<T>() - src.Width));
    }
}