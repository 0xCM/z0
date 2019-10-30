//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitRef
    {
        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static int modprod(BitVector4 lhs, BitVector4 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static int modprod(BitVector8 lhs, BitVector8 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static int modprod(BitVector16 lhs, BitVector16 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static int modprod(BitVector32 lhs, BitVector32 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return result % 2;
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static bit modprod(BitVector64 lhs, BitVector64 rhs)
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var x = lhs[i] ? 1 : 0;
                var y = rhs[i] ? 1 : 0;
                result += x*y;
            }
            return odd(result);
        }

        /// <summary>
        /// Compultes the scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        public static bit modprod<T>(BitCells<T> lhs, BitCells<T> rhs)
            where T : unmanaged
        {
            var result = 0;
            for(var i=0; i<lhs.Length; i++)
            {
                var a = lhs[i] ? 1 : 0;
                var b = rhs[i] ? 1 : 0;
                result += a*b;
            }
            return odd(result);
        }

        /// <summary>
        /// Compultes the scalar product between two generic bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit modprod<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => modprod(x.ToBitCells(), y.ToBitCells());

        /// <summary>
        /// Compultes the scalar product between two natural bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit modprod<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => modprod(x.ToBitCells(),y.ToBitCells());


    }

}