//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using static zfunc;    
    
    partial class ginxx
    {
        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this in Vec128<T> src)
            where T : unmanaged            
                => Vec128<T>.Length;

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector128<T> src)
            where T : unmanaged            
                => Vec128<T>.Length;

        [MethodImpl(Inline)]
        public static ref T StoreTo<T>(this Vector128<T> src, ref T dst)
            where T : unmanaged            
        {
            vstore(src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> StoreTo<T>(this Vector128<T> src, Span<T> dst)
            where T : unmanaged            
        {
            src.StoreTo(ref head(dst));
            return dst;
        }

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this in Vec256<T> src)
            where T : unmanaged            
                => Vec256<T>.Length;    

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector256<T> src)
            where T : unmanaged            
                => Vec256<T>.Length;    

        [MethodImpl(Inline)]
        public static ref T StoreTo<T>(this Vector256<T> src, ref T dst)
            where T : unmanaged            
        {
            vstore(src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> StoreTo<T>(this Vector256<T> src, Span<T> dst)
            where T : unmanaged            
        {
            src.StoreTo(ref head(dst));
            return dst;
        }

        /// <summary>
        /// Loads a 256-bit cpu vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ToCpuVec256<T>(this Span256<T> src, int block = 0)
            where T : unmanaged
                => Vec256.Load(ref src.Block(block));


        /// <summary>
        /// Loads a 256-bit cpu vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> ToCpuVector<T>(this Span256<T> src, int block = 0)
            where T : unmanaged
                => ginx.vloadu(n256, in src.Block(block));



        /// <summary>
        /// Projects a 128-bit source vector into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec128<T> Map128<S,T>(this Vec128<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(Vec128<S>.Length, Vec128<T>.Length);
            var dstLen = Vec128<T>.Length;
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(src[i]);
            return Vec128.Load(ref head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> Map128<S,T>(this Vector128<S> lhs, Vector128<S> rhs, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(Vec128<S>.Length, Vec128<T>.Length);
            var dstLen = Vec128<T>.Length;
            var lhsData = lhs.ToSpan();
            var rhsData = rhs.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return ginx.vloadu128(in head(dst));        
        } 

        /// <summary>
        /// Projects a 128-bit source vector into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> Map128<S,T>(this Vector128<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(Vector128<S>.Count, Vector128<T>.Count);
            var dstLen = Vec128<T>.Length;
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);
            return ginx.vloadu128(in head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 256-bit target vector via alternating application of a mapping function
        /// dst[j] = f(lhs[i])
        /// dst[j+1] = f(rhs[i])
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec256<T> Map256<T>(this Vector128<T> lhs, Vector128<T> rhs, Func<T,T> f)
            where T : unmanaged
        {
            var srcLen = Vec128<T>.Length;
            var dstLen = 2*srcLen;
            var lhsData = lhs.ToSpan();
            var rhsData = rhs.ToSpan();
            Span<T> dst = new T[dstLen];
            var j=0;
            for(var i=0; i< srcLen; i++)
            {
                dst[j++] = f(lhsData[i]);
                dst[j++] = f(rhsData[i]);
            }
            
            return Vec256.Load(ref head(dst));        
        } 

        /// <summary>
        /// Projects a source vector into a target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Map256<S,T>(this Vector256<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(Vector256<S>.Count, Vector256<T>.Count);
            var dstLen = Vector256<T>.Count;
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);            
            return ginx.vloadu256(in head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Map256<S,T>(this Vector256<S> lhs, Vector256<S> rhs, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(Vector256<S>.Count, Vector256<T>.Count);
            var dstLen = Vector256<T>.Count;
            var lhsData = lhs.ToSpan();
            var rhsData = rhs.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return ginx.vloadu256(in head(dst));        
        } 
    }
}
