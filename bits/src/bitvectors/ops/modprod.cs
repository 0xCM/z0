//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the Euclidean scalar product between two generic bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitCells.modprod(x.ToCells(), y.ToCells());
        
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
            return odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod(BitVector4 x, BitVector4 y)
        {
            var result = 0;
            for(var i=0; i<x.Width; i++)
            {
                var a = x[i] ? 1 : 0;
                var b = y[i] ? 1 : 0;
                result += a*b;
            }
            return odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod(BitVector8 x, BitVector8 y)
        {
            var result = 0;
            for(var i=0; i<x.Width; i++)
            {
                var a = x[i] ? 1 : 0;
                var b = y[i] ? 1 : 0;
                result += a*b;
            }
            return odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod(BitVector16 x, BitVector16 y)
        {
            var result = 0;
            for(var i=0; i<x.Width; i++)
            {
                var a = x[i] ? 1 : 0;
                var b = y[i] ? 1 : 0;
                result += a*b;
            }
            return odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        public static bit modprod(BitVector32 x, BitVector32 y)
        {
            var result = 0;
            for(var i=0; i<x.Width; i++)
            {
                var a = x[i] ? 1 : 0;
                var b = y[i] ? 1 : 0;
                result += a*b;
            }
            return odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        public static bit modprod(BitVector64 x, BitVector64 y)
        {
            var result = 0;
            for(var i=0; i<x.Width; i++)
            {
                var a = x[i] ? 1 : 0;
                var b = y[i] ? 1 : 0;
                result += a*b;
            }
            return odd(result);
        }
    }
}