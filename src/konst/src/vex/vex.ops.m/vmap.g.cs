//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static z;

    partial struct gcpu
    {
        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="a">The left source vector</param>
        /// <param name="b">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> vmap<S,T>(Vector128<S> a, Vector128<S> b, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = min(cpu.vcount<S>(w128), cpu.vcount<T>(w128));
            var dstLen = cpu.vcount<T>(w128);
            var lhsData = a.ToSpan();
            var rhsData = b.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return vload(w128, first(dst));
        }

        /// <summary>
        /// Projects a 128-bit source vector into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> vmap<S,T>(Vector128<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = min(cpu.vcount<S>(w128), cpu.vcount<T>(w128));
            var dstLen = cpu.vcount<T>(w128);
            var data = src.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);
            return vload(w128, first(dst));
        }

        /// <summary>
        /// Projects a source vector into a target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> vmap<S,T>(Vector256<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = min(cpu.vcount<S>(w256), cpu.vcount<T>(w256));
            var dstLen = cpu.vcount<T>(w256);
            var data = src.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);
            return vload(w256, first(dst));
        }

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="a">The left source vector</param>
        /// <param name="b">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> vmap<S,T>(Vector256<S> a, Vector256<S> b, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var w = w256;
            var xLen = min(cpu.vcount<S>(w), cpu.vcount<T>(w));
            var dstLen = cpu.vcount<T>(w);
            var lhsData = a.ToSpan();
            var rhsData = b.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return vload(w, first(dst));
        }
    }
}