//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class mkl
    {            
		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref RowVector256<float> add(RowVector256<float> lhs, RowVector256<float> rhs, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> add(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref RowVector256<N,float> add<N>(RowVector256<N,float> lhs, RowVector256<N,float> rhs, ref RowVector256<N,float> dst)
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
        public static ref RowVector256<N,double> add<N>(RowVector256<N,double> lhs, RowVector256<N,double> rhs, ref RowVector256<N,double> dst)
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
        public static ref RowVector256<float> sub(RowVector256<float> lhs, RowVector256<float> rhs, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> sub(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref RowVector256<N,float> sub<N>(RowVector256<N,float> lhs, RowVector256<N,float> rhs, ref RowVector256<N,float> dst)
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
        public static ref RowVector256<N,double> sub<N>(RowVector256<N,double> lhs, RowVector256<N,double> rhs, ref RowVector256<N,double> dst)
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
        public static ref RowVector256<float> mul(RowVector256<float> lhs, RowVector256<float> rhs, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> mul(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref RowVector256<N,float> mul<N>(RowVector256<N,float> lhs, RowVector256<N,float> rhs, ref RowVector256<N,float> dst)
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
        public static ref RowVector256<N,double> mul<N>(RowVector256<N,double> lhs, RowVector256<N,double> rhs, ref RowVector256<N,double> dst)
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
        public static ref RowVector256<float> div(RowVector256<float> lhs, RowVector256<float> rhs, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> div(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> mod(RowVector256<float> lhs, RowVector256<float> rhs, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> mod(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref Matrix256<M,N,float> mod<M,N>(Matrix256<M,N,float> A, Matrix256<M,N,float> B, ref Matrix256<M,N,float> X)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat

        {
            VmlImport.vsFmod(Matrix256<M,N,float>.Cells, ref head(A), ref head(B), ref head(X));
            return ref X;
        }

		/// <summary>
		/// Computes X[i,j] = A[i,j] % B[i,j] for each row/col index i/j
		/// </summary>
		/// <param name="A">The left vector</param>
  		/// <param name="B">The right vector</param>
		/// <param name="X">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Matrix256<M,N,double> mod<M,N>(Matrix256<M,N,double> lhs, Matrix256<M,N,double> rhs, ref Matrix256<M,N,double> dst)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat

        {
            VmlImport.vdFmod(Matrix256<M,N,float>.Cells, ref head(lhs), ref head(rhs), ref head(dst));
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
        public static ref RowVector256<float> truncRem(RowVector256<float> src, RowVector256<float> trunc, ref RowVector256<float> rem)
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
        public static ref RowVector256<double> truncRem(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> rem(RowVector256<float> lhs, RowVector256<float> rhs, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> rem(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> frac(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> frac(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> square(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> square(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> sqrt(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> sqrt(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> abs(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> abs(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> min(RowVector256<float> a, RowVector256<float> b, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> min(RowVector256<double> a, RowVector256<double> b, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> max(RowVector256<float> a, RowVector256<float> b, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> max(RowVector256<double> a, RowVector256<double> b, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> maxAbs(RowVector256<float> a, RowVector256<float> b, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> maxAbs(RowVector256<double> a, RowVector256<double> b, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> minAbs(RowVector256<float> a, RowVector256<float> b, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> minAbs(RowVector256<double> a, RowVector256<double> b, ref RowVector256<double> dst)
        {
            VmlImport.vdMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref RowVector256<float> copySign(RowVector256<float> a, RowVector256<float> b, ref RowVector256<float> dst)        
        {
            VmlImport.vsCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref RowVector256<double> copySign(RowVector256<double> a, RowVector256<double> b, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> next(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> next(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> round(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> round(RowVector256<double> src, ref RowVector256<double> dst)        
        {
            VmlImport.vdRound(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix256<M,N,float> round<M,N>(ref Matrix256<M,N,float> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            VmlImport.vsRound(Matrix256<M,N,float>.Cells, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix256<M,N,double> round<M,N>(ref Matrix256<M,N,double> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {

            VmlImport.vdRound(Matrix256<M,N,double>.Cells, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =truncate(src[i]) for i=0..n-1 where "truncate" rounds the input value towards 0
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref RowVector256<float> trunc(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> trunc(RowVector256<double> src, ref RowVector256<double> dst)        
        {
            VmlImport.vdTrunc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix256<M,N,double> trunc<M,N>(ref Matrix256<M,N,double> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            VmlImport.vdTrunc(Matrix256<M,N,double>.Cells, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix256<M,N,float> trunc<M,N>(ref Matrix256<M,N,float> A)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            VmlImport.vsTrunc(Matrix256<M,N,float>.Cells, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref RowVector256<float> floor(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> floor(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> ceil(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> ceil(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> recip(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> recip(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> pow(RowVector256<float> lhs, RowVector256<float> rhs, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> pow(RowVector256<double> lhs, RowVector256<double> rhs, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> pow(RowVector256<float> src, float exp, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> pow(RowVector256<double> src, double exp, ref RowVector256<double> dst)
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
        public static ref RowVector256<float> exp(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> exp(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> exp2(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> exp2(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> exp10(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> exp10(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> ln(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> ln(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> log2(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> log2(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> log10(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> log10(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> erf(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> erf(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> erfInv(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> erfInv(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> erfc(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> erfc(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> erfcInv(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> erfcInv(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> expInt(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> expInt(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> cdfNorm(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> cdfNorm(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> cdfNormInv(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> cdfNormInv(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> gamma(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> gamma(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> lgamma(RowVector256<float> src, ref RowVector256<float> dst)        
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
        public static ref RowVector256<double> lgamma(RowVector256<double> src, ref RowVector256<double> dst)        
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
        public static ref RowVector256<float> hypot(RowVector256<float> a, RowVector256<float> b, ref RowVector256<float> dst)
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
        public static ref RowVector256<double> hypot(RowVector256<double> a, RowVector256<double> b, ref RowVector256<double> dst)
        {
            VmlImport.vdHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }
    }
}