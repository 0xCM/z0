//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates a 128-bit hash code predicated on four type parameters
        /// </summary>
        /// <typeparam name="A">The first type</typeparam>
        /// <typeparam name="B">The second type</typeparam>
        /// <typeparam name="C">The third type</typeparam>
        /// <typeparam name="D">The fourth type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<uint> vhash<A,B,C,D>()
            => vparts(w128, hash<A>(), hash<B>(), hash<C>(), hash<D>());
    }
}