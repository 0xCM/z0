//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Text;
    using Z0.Mkl;        

    using static zfunc;
    using static nfunc;

    public static class MatrixOps
    {
        /// <summary>
        /// Allocates and computes a matrix X = AB of natural dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static MBlock256<M,N,float> Mul<M,K,N>(this MBlock256<M,K,float> A, MBlock256<K,N,float> B)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Matrix.blockload<M,N,float>(mkl.gemm<M,K,N>(A.Unsized, B.Unsized));

        /// <summary>
        /// Allocates and computes a matrix X = AB of natural dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static MBlock256<M,N,double> Mul<M,K,N>(this MBlock256<M,K,double> A, MBlock256<K,N,double> B)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Matrix.blockload<M,N,double>(mkl.gemm<M,K,N>(A.Unsized, B.Unsized));

        /// <summary>
        /// Computes the matrix product X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,float> Mul<M,K,N>(this MBlock256<M,K,float> A, MBlock256<K,N,float> B, ref MBlock256<M,N, float> X)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            mkl.gemm<M,K,N>(A, B, ref X);
            return ref X;
        }

        /// <summary>
        /// Computes the matrix product X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,double> Mul<M,K,N>(this MBlock256<M,K,double> A, MBlock256<K,N,double> B, ref MBlock256<M,N,double> X)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
        {
            mkl.gemm(A, B, ref X);   
            return ref X;
        }

        /// <summary>
        /// Computes the product of square matrices of natural dimension
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="N">The common order of all matrices</typeparam>
        [MethodImpl(Inline)]
        public static ref MBlock256<N,float> Mul<N>(this MBlock256<N,float> A, MBlock256<N,float> B, ref MBlock256<N, float> X)
            where N : unmanaged, ITypeNat
        {
            mkl.gemm(A, B, ref X);
            return ref X;
        }


        /// <summary>
        /// Computes the product of square matrices of natural dimension
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="N">The common order of all matrices</typeparam>
        [MethodImpl(Inline)]
        public static ref MBlock256<N,double> Mul<N>(this MBlock256<N,double> A, MBlock256<N,double> B, ref MBlock256<N, double> X)
            where N : unmanaged, ITypeNat
        {
            mkl.gemm(A, B, ref X);
            return ref X;
        }
        
        [MethodImpl(Inline)]
        public static MBlock256<N,T> Map<N,S,T>(this MBlock256<N,S> A, Func<S,T> f)
            where N : unmanaged, ITypeNat
            where T : unmanaged
            where S : unmanaged
        {
            var src = A.Unblocked;
            var dstM = Matrix.blockalloc<N,T>();
            var dst = dstM.Unblocked;
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(src[i]);
            return dstM;
        }

        public static MBlock256<N,double> Pow<N>(this MBlock256<N,double> A, int exp)
            where N : unmanaged, ITypeNat
        {
            if(exp == 1)
                return A;

            var B = A.Replicate();
            var X = Matrix.blockalloc<N,double>();
            mkl.gemm(A,B,ref X);
            if(exp == 2)
                return X;

            var i = exp;
            while(--i > 2)
                mkl.gemm(X,X,ref X);    
            
            return X;                        
        }

    }


}