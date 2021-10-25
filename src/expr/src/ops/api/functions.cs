//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct scalars
    {
        /// <summary>
        /// Defines a bijective correspondence between members of source/target sequences of common length over a common domain
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="dst">The target sequence</param>
        /// <typeparam name="T">The domain type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BijectivePoints<T> bijection<T>(Index<T> src, Index<T> dst)
        {
            if(src.Length != dst.Length)
                Errors.ThrowWithOrigin(string.Format("{0} != {1}", src.Length, dst.Length));
            return new BijectivePoints<T>(src, dst);
        }

        /// <summary>
        /// Defines a bijective correspondence between members of source/target sequences of common length
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="dst">The target sequence</param>
        /// <typeparam name="S">The source domain type</typeparam>
        /// <typeparam name="T">The target domain type</typeparam>
        [MethodImpl(Inline)]
        public static BijectivePoints<S,T> bijection<S,T>(Index<S> src, Index<T> dst)
        {
            if(src.Length != dst.Length)
                Errors.ThrowWithOrigin(string.Format("{0} != {1}", src.Length, dst.Length));
            return new BijectivePoints<S,T>(src, dst);
        }
 
        [MethodImpl(Inline)]
        public static PointMap<A,B> points<A,B>(A[] a, B[] b)
            => new PointMap<A,B>(a,b);

        public static PointMap<A,B> points<A,B>(Paired<A,B>[] src)
        {
            var count = src.Length;
            var a = alloc<A>(count);
            var b = alloc<B>(count);
            for(var i=0; i<count; i++)
            {
                seek(a,i) = skip(src,i).Left;
                seek(b,i) = skip(src,i).Right;
            }
            return new PointMap<A,B>(a,b);
        }
    }
}