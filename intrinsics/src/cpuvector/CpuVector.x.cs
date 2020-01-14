//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    public static partial class CpuVecX
    {
        /// <summary>
        /// Extracts the value of an index-identified component from the source vector
        /// </summary>
        /// <param name="src">THe source vector</param>
        /// <param name="index">The component index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T Item<T>(this Vector128<T> src, int index)
            where T : unmanaged
                => vcell(src,index);

        /// <summary>
        /// Returns the number of source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector128<T> src)
            where T : unmanaged            
                => vcount<T>(n128);

        /// <summary>
        /// Returns the number of source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector256<T> src)
            where T : unmanaged            
                => vcount<T>(n256);

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> Map<S,T>(this Vector128<S> lhs, Vector128<S> rhs, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(vcount<S>(n128), vcount<T>(n128));
            var dstLen = vcount<T>(n128);
            var lhsData = lhs.ToSpan();
            var rhsData = rhs.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return CpuVector.vload(n128, in head(dst));        
        } 

        /// <summary>
        /// Projects a 128-bit source vector into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> Map<S,T>(this Vector128<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(vcount<S>(n128), vcount<T>(n128));
            var dstLen = vcount<T>(n128);
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);
            return CpuVector.vload(n128, in head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 256-bit target vector via alternating application of a mapping function
        /// dst[j] = f(lhs[i])
        /// dst[j+1] = f(rhs[i])
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Merge<T>(this Vector128<T> x, Vector128<T> y, Func<T,T> f)
            where T : unmanaged
        {
            var srcLen = vcount<T>(n128);
            var dstLen = 2*srcLen;
            var lhsData = x.ToSpan();
            var rhsData = y.ToSpan();
            Span<T> dst = new T[dstLen];
            var j=0;
            for(var i=0; i< srcLen; i++)
            {
                dst[j++] = f(lhsData[i]);
                dst[j++] = f(rhsData[i]);
            }
            
            return CpuVector.vload(n256, in head(dst));        
        } 

        /// <summary>
        /// Projects a source vector into a target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Map<S,T>(this Vector256<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(vcount<S>(n256), vcount<T>(n256));
            var dstLen = vcount<T>(n256);
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);            
            return CpuVector.vload(n256, in head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Map<S,T>(this Vector256<S> x, Vector256<S> y, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var n = n256;
            var xLen = Math.Min(vcount<S>(n), vcount<T>(n));
            var dstLen = vcount<T>(n);
            var lhsData = x.ToSpan();
            var rhsData = y.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return CpuVector.vload(n, in head(dst));        
        } 
    }
}