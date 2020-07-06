//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {                
        /// <summary>
        /// Advances to a T-cell predicated on the numeric value of an E-literal, which does not necessarily refine a T-primal
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="field">The enumeration literal</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static ref T eSeek<E,T>(Span<T> src, E field)
            where E : unmanaged, Enum
                => ref seek(src, scalar<E,ushort>(field));
    }
}