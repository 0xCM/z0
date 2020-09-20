//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates a K-indexed bijection
        /// </summary>
        /// <param name="src">The source points</param>
        /// <param name="dst">The target points</param>
        /// <typeparam name="S">The domain type</typeparam>
        /// <typeparam name="T">The range type</typeparam>
        /// <typeparam name="K">The index type</typeparam>
        public Bijection<S,T,K> bijection<S,T,K>(S[] src, T[] dst)
            where K : unmanaged
                => new Bijection<S,T,K>(src,dst);
    }
}