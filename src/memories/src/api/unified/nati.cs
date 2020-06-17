//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        /// <summary>
        /// Retrieves the value of a type natural represented as a signed integer
        /// </summary>
        /// <typeparam name="N">The nat type</typeparam>
        [MethodImpl(Inline)]   
        public static int nati<N>(N n = default) 
            where N : unmanaged, ITypeNat
                => (int)value<N>();
    }
}