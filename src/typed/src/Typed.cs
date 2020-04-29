//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;    

    public static partial class Typed
    {
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representativev</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static ulong value<N>(N n = default)
            where N : unmanaged, ITypeNat
                => TypeNats.value(n);

    }

    public static partial class XTend
    {

    }

}
