//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    using static LogicOpApi;

    public static class BitVectorOps
    {

        /// <summary>
        /// Computes the bitwise AND of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> and<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x & y;

        /// <summary>
        /// Computes the bitwise AND of the source vetors via component-wise logical operations to define a refence implementation 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> and_cw<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Or, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise NAND of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.nand(x,y);

        /// <summary>
        /// Computes the bitwise AND of the source vetors via component-wise logical operations to define a refence implementation 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> nand_cw<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Nand, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise OR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x | y;

        /// <summary>
        /// Computes the bitwise OR of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> or_cw<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Or, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise XOR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x ^ y;

        /// <summary>
        /// Computes the bitwise XOR of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> xor_cw<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.XOr, x[i], y[i]);
            return z;
        }


    }

}