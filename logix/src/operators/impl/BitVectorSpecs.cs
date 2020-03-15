//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static LogicOpApi;

    /// <summary>
    /// Implements reference bitvector operations
    /// </summary>
    public static class BitVectorOpSpecs
    {
        /// <summary>
        /// Computes the bitwise AND of the source vetors via component-wise logical operations to define a reference implementation 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> and<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.And, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise AND of the source vetors via component-wise logical operations to define a reference implementation 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.Nand, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise OR of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.Or, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise OR of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.Nor, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise XOR of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.Xor, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise XOR of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.Xnor, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise LeftNot of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> lnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(UnaryBitLogicOpKind.Not, x[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise LeftNot of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> rnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(UnaryBitLogicOpKind.Not, y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise Impliction of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> impl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.Impl, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise NotImpliction of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> nonimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.NonImpl, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise ConverseImpliction of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> cimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.CImpl, x[i], y[i]);
            return z;
        }

        /// <summary>
        /// Computes the bitwise ConverseImpliction of the source vetors via component-wise logical operations to define a reference implementation
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        public static BitVector<T> cnonimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            var len = x.Width;
            var z = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                z[i] = eval(BinaryBitLogicOpKind.CNonImpl, x[i], y[i]);
            return z;
        }

        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
        {
            var len = x.Width;
            var dst = BitVector.alloc<T>();
            for(var i=0; i< len; i++)
                dst[i] = LogicOps.select(x[i], y[i], z[i]);
            return z;
        }
    }
}