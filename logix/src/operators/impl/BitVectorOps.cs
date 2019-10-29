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
        /// Computes the bitwise TRUE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> @true<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.ones<T>();

        /// <summary>
        /// Computes the bitwise FALSE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> @false<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.zero<T>();

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
        /// Computes the bitwise NOR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~ (x | y);

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
        /// Computes the bitwise Xnor of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~(x ^ y);

        /// <summary>
        /// Defines the bitwise LeftProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> left<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x;

        /// <summary>
        /// Defines the bitwise RightProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> right<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => y;

        /// <summary>
        /// Defines the bitwise LeftNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> lnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~x;

        /// <summary>
        /// Defines the bitwise RightNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> rnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~y;

        /// <summary>
        /// Computes the bitwise implication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> imply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x | ~y;

        /// <summary>
        /// Computes the bitwise nonimplication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> notimply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.notimply(x,y);

        /// <summary>
        /// Computes the bitwise converse implication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> cimply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~x | y;

        /// <summary>
        /// Computes the bitwise converse nonimplication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> cnotimply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.cnotimply(x,y);

        /// <summary>
        /// Computes the bitwise AND of the source vetors via component-wise logical operations to define a refence implementation 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> and_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.And, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise AND of the source vetors via component-wise logical operations to define a refence implementation 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> nand_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Nand, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise OR of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> or_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Or, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise OR of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> nor_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Nor, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise XOR of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> xor_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.XOr, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise XOR of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> xnor_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Xnor, x[i], y[i]);
            return z;
        }


        /// <summary>
        /// Computes the bitwise LeftNot of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> lnot_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(UnaryLogicOpKind.Not, x[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise LeftNot of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> rnot_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(UnaryLogicOpKind.Not, y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise Impliction of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> imply_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Implication, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise NotImpliction of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> notimply_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.Nonimplication, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise ConverseImpliction of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> cimply_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.ConverseImplication, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise ConverseImpliction of the source vetors via component-wise logical operations to define a refence implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> cnotimply_ref<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Length;
            var z = BitVector.generic<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryLogicOpKind.ConverseNonimplication, x[i], y[i]);
            return z;
        }



    }

}