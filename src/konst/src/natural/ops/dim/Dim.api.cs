//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class Dim
    {
        /// <summary>
        /// Constructs an natural dimension of order 2
        /// </summary>
        /// <typeparam name="M">The type of the first axis</typeparam>
        /// <typeparam name="N">The type of the second axis</typeparam>
        [MethodImpl(Inline)]
        public static Dim<M,N> define<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => default;
    }
}