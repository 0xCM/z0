//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
     using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class mkl
    {            
		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> add(VBlock256<float> lhs, VBlock256<float> rhs, ref VBlock256<float> dst)
        {
            VmlImport.vsAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> add(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,float> add<N>(VBlock256<N,float> lhs, VBlock256<N,float> rhs, ref VBlock256<N,float> dst)
            where N : unmanaged, ITypeNat
        {
            VmlImport.vsAdd(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,double> add<N>(VBlock256<N,double> lhs, VBlock256<N,double> rhs, ref VBlock256<N,double> dst)
            where N : unmanaged, ITypeNat
        {
            VmlImport.vdAdd(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> sub(VBlock256<float> lhs, VBlock256<float> rhs, ref VBlock256<float> dst)
        {
            VmlImport.vsSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> sub(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,float> sub<N>(VBlock256<N,float> lhs, VBlock256<N,float> rhs, ref VBlock256<N,float> dst)
            where N : unmanaged, ITypeNat
        {
            VmlImport.vsSub(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,double> sub<N>(VBlock256<N,double> lhs, VBlock256<N,double> rhs, ref VBlock256<N,double> dst)
            where N : unmanaged, ITypeNat
        {
            VmlImport.vdSub(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> mul(VBlock256<float> lhs, VBlock256<float> rhs, ref VBlock256<float> dst)
        {
            VmlImport.vsMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> mul(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,float> mul<N>(VBlock256<N,float> lhs, VBlock256<N,float> rhs, ref VBlock256<N,float> dst)
            where N : unmanaged, ITypeNat
        {
            VmlImport.vsMul(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,double> mul<N>(VBlock256<N,double> lhs, VBlock256<N,double> rhs, ref VBlock256<N,double> dst)
            where N : unmanaged, ITypeNat
        {
            VmlImport.vdMul(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] / rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> div(VBlock256<float> lhs, VBlock256<float> rhs, ref VBlock256<float> dst)
        {
            VmlImport.vsDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] / rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> div(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> mod(VBlock256<float> lhs, VBlock256<float> rhs, ref VBlock256<float> dst)
        {
            VmlImport.vsFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }
        
		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> mod(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes X[i,j] = A[i,j] % B[i,j] for each row/col index i/j
		/// </summary>
		/// <param name="A">The left vector</param>
  		/// <param name="B">The right vector</param>
		/// <param name="X">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,float> mod<M,N>(MBlock256<M,N,float> A, MBlock256<M,N,float> B, ref MBlock256<M,N,float> X)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat

        {
            VmlImport.vsFmod(MBlock256<M,N,float>.CellCount, ref head(A), ref head(B), ref head(X));
            return ref X;
        }

		/// <summary>
		/// Computes X[i,j] = A[i,j] % B[i,j] for each row/col index i/j
		/// </summary>
		/// <param name="A">The left vector</param>
  		/// <param name="B">The right vector</param>
		/// <param name="X">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,double> mod<M,N>(MBlock256<M,N,double> lhs, MBlock256<M,N,double> rhs, ref MBlock256<M,N,double> dst)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat

        {
            VmlImport.vdFmod(MBlock256<M,N,float>.CellCount, ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Truncates the source vector and deposits the result in trunc and the fractional part 
        /// that was removed when producing the truncation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="trunc">The vector that receives the truncated components</param>
        /// <param name="rem">The vector that receives the fractional remainders</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> truncRem(VBlock256<float> src, VBlock256<float> trunc, ref VBlock256<float> rem)
        {
            VmlImport.vsModf(length(src, trunc), ref head(src), ref head(trunc), ref head(rem));
            return ref rem;
        }

        /// <summary>
        /// Truncates the source vector and deposits the result in trunc and the fractional part 
        /// that was removed when producing the truncation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="trunc">The vector that receives the truncated components</param>
        /// <param name="rem">The vector that receives the fractional remainders</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> truncRem(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdModf(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }
        

		/// <summary>
		/// Computes dst[i] = remainder(lhs[i] / rhs[i]) for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> rem(VBlock256<float> lhs, VBlock256<float> rhs, ref VBlock256<float> dst)
        {
            VmlImport.vsRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = remainder(lhs[i] / rhs[i]) for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> rem(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the fractional part of each component
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> frac(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsFrac(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the fractional part of each component
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> frac(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdFrac(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = (src[i])^2 for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> square(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsSqr(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = (src[i])^2 for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> square(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdSqr(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = (src[i])^(1/2) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> sqrt(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsSqrt(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = (src[i])^(1/2) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> sqrt(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdSqrt(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = |src[i]| for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> abs(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsAbs(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = |src[i]| for i = 0...n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> abs(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdAbs(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> min(VBlock256<float> a, VBlock256<float> b, ref VBlock256<float> dst)
        {
            VmlImport.vsFmin(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> min(VBlock256<double> a, VBlock256<double> b, ref VBlock256<double> dst)
        {
            VmlImport.vdFmin(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = max(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> max(VBlock256<float> a, VBlock256<float> b, ref VBlock256<float> dst)
        {
            VmlImport.vsFmax(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = max(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> max(VBlock256<double> a, VBlock256<double> b, ref VBlock256<double> dst)
        {
            VmlImport.vdFmax(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }


        /// <summary>
        /// Computes dst[i] = max(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> maxAbs(VBlock256<float> a, VBlock256<float> b, ref VBlock256<float> dst)
        {
            VmlImport.vsMaxMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = max(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> maxAbs(VBlock256<double> a, VBlock256<double> b, ref VBlock256<double> dst)
        {
            VmlImport.vdMaxMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> minAbs(VBlock256<float> a, VBlock256<float> b, ref VBlock256<float> dst)
        {
            VmlImport.vsMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> minAbs(VBlock256<double> a, VBlock256<double> b, ref VBlock256<double> dst)
        {
            VmlImport.vdMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref VBlock256<float> copySign(VBlock256<float> a, VBlock256<float> b, ref VBlock256<float> dst)        
        {
            VmlImport.vsCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref VBlock256<double> copySign(VBlock256<double> a, VBlock256<double> b, ref VBlock256<double> dst)        
        {
            VmlImport.vdCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = src[i] + epsilon
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> next(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsNextAfter(dst.Length, ref head(src), ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = src[i] + epsilon
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> next(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdNextAfter(dst.Length, ref head(src), ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =round(src[i]) for i=0..n-1 where "round" maps the input to the nearest integral value
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> round(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsRound(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =round(src[i]) for i=0..n-1 where "round" maps the input to the nearest integral value
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> round(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdRound(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,float> round<M,N>(ref MBlock256<M,N,float> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            VmlImport.vsRound(MBlock256<M,N,float>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,double> round<M,N>(ref MBlock256<M,N,double> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {

            VmlImport.vdRound(MBlock256<M,N,double>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =truncate(src[i]) for i=0..n-1 where "truncate" rounds the input value towards 0
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> trunc(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsTrunc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =truncate(src[i]) for i=0..n-1 where "truncate" rounds the input value towards 0
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> trunc(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdTrunc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,double> trunc<M,N>(ref MBlock256<M,N,double> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            VmlImport.vdTrunc(MBlock256<M,N,double>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,float> trunc<M,N>(ref MBlock256<M,N,float> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            VmlImport.vsTrunc(MBlock256<M,N,float>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> floor(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsFloor(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> floor(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdFloor(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = ceil(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> ceil(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsCeil(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = ceil(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> ceil(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdCeil(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = 1/src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> recip(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 1/src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> recip(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> pow(VBlock256<float> lhs, VBlock256<float> rhs, ref VBlock256<float> dst)
        {
            VmlImport.vsPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> pow(VBlock256<double> lhs, VBlock256<double> rhs, ref VBlock256<double> dst)
        {
            VmlImport.vdPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = src[i]^exp for i = 0...n-1 
		/// </summary>
		/// <param name="src">The left vector</param>
  		/// <param name="exp">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> pow(VBlock256<float> src, float exp, ref VBlock256<float> dst)
        {
            VmlImport.vsPowx(length(src,dst), ref head(src), exp, ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = src[i]^exp for i = 0...n-1 
		/// </summary>
		/// <param name="src">The left vector</param>
  		/// <param name="exp">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> pow(VBlock256<double> src, double exp, ref VBlock256<double> dst)
        {
            VmlImport.vdPowx(length(src,dst), ref head(src), exp, ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] = e^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> exp(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsExp(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = e^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> exp(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdExp(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
       
 		/// <summary>
		/// Computes dst[i] = 2^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> exp2(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsExp2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 2^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> exp2(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdExp2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] = 10^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> exp10(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsExp10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 10^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> exp10(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdExp10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] =ln(src[i]) for i=0..n-1 where ln denotes the natural log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> ln(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsLn(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] =ln(src[i]) for i=0..n-1 where ln denotes the natural log
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> ln(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdLn(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] =log2(src[i]) for i=0..n-1 where log2 denotes the base 2 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> log2(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsLog2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] =log2(src[i]) for i=0..n-1 where log2 denotes the base 2 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> log2(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdLog2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] =log10(src[i]) for i=0..n-1 where log10 denotes the base 10 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> log10(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsLog10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] =log10(src[i]) for i=0..n-1 where log10 denotes the base 10 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> log10(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdLog10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes the error function dst[i] =erf(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> erf(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsErf(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes the error function dst[i] =erf(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> erf(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdErf(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes the inverse error function dst[i] =erfInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> erfInv(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsErfInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes the inverse error function dst[i] =erfInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> erfInv(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdErfInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the complementary error function dst[i] =erfc(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> erfc(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsErfc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
 
		/// <summary>
		/// Computes the complementary error function dst[i] =erfc(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> erfc(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdErfc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
 
		/// <summary>
		/// Computes the inverse complementary error function dst[i] =erfcInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> erfcInv(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsErfcInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the inverse complementary error function dst[i] =erfcInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> erfcInv(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdErfcInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes the exponential integral function dst[i] = E(src[i]) for i=0..n-1 where
        /// E(x) = ∫[x, ∞](e^(-t)/t)dt = ∫[1, ∞](e^(-xt)/t)dt
        /// </summary>
        /// <param name="src">The source vector containing the lower integration bounds</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> expInt(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsExpInt1(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes the exponential integral function dst[i] = E(src[i]) for i=0..n-1 where
        /// E(x) = ∫[x, ∞](e^(-t)/t)dt = ∫[1, ∞](e^(-xt)/t)dt
        /// </summary>
        /// <param name="src">The source vector containing the lower integration bounds</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> expInt(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdExpInt1(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = cdfnorm(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> cdfNorm(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsCdfNorm(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = cdfnorm(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> cdfNorm(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdCdfNorm(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = cdfnormInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> cdfNormInv(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsCdfNormInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = cdfnormInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> cdfNormInv(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdCdfNormInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the gamma function: dst[i] = gamma(src[i])
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> gamma(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsTGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes the gamma function: dst[i] = gamma(src[i])
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> gamma(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdTGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes of natural logarithm of the absolute value of gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> lgamma(VBlock256<float> src, ref VBlock256<float> dst)        
        {
            VmlImport.vsLGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes of natural logarithm of the absolute value of gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> lgamma(VBlock256<double> src, ref VBlock256<double> dst)        
        {
            VmlImport.vdLGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = sqrt(a[i]^2 + b[i]^2)
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<float> hypot(VBlock256<float> a, VBlock256<float> b, ref VBlock256<float> dst)
        {
            VmlImport.vsHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// Computes dst[i] = sqrt(a[i]^2 + b[i]^2)
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref VBlock256<double> hypot(VBlock256<double> a, VBlock256<double> b, ref VBlock256<double> dst)
        {
            VmlImport.vdHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }
    }

}