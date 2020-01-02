//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Linear
    {
        /// <summary>
        /// Computes lhs[i] := lhs[i] & rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector256<N,T> and<N,T>(RowVector256<N,T> lhs, RowVector256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = RowVector.blockalloc<N,T>();
            and<T>(lhs.Data, rhs.Data, dst);
            return dst;
        }

        public static Block256<T> and<T>(ConstBlock256<T> lhs, ConstBlock256<T> rhs, Block256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(ginx.vand<T>(lhs.LoadVector(i), rhs.LoadVector(i)), ref dst.BlockRef(i));                             
            return dst;        
        } 

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref RowVector256<N,T> add<N,T>(ref RowVector256<N,T> x, in RowVector256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            ginx.vadd<T>(x,y,x);
            return ref x;
        }

        /// <summary>
        /// Computes z[i] := x[i] - y[i] for i = 0...N-1
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref RowVector256<N,T> sub<N,T>(RowVector256<N,T> x, RowVector256<N,T> y, ref RowVector256<N,T> z)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            ginx.vsub(x.Data,y.Data,z.Data);
            return ref z;
        }


    }
}