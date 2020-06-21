//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class FiniteSet
    {
        /// <summary>
        /// Constructs a finite set from supplied members
        /// </summary>
        /// <param name="members">The defining members</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySet<T> define<T>(params T[] members)
            where T : ISemigroup<T>, new()
                => new ReadOnlySet<T>(members);

        /// <summary>
        /// Constructs a finite set from supplied sequence
        /// </summary>
        /// <param name="members">The defining members</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySet<T> define<T>(IEnumerable<T> members)
            where T : ISemigroup<T>, new()
                => new ReadOnlySet<T>(members);
    }    

}