//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    public readonly struct NumericComparer<T> : IComparer<T>
        where T : unmanaged
    {
        readonly Func<T,T,int> comparer;

        [MethodImpl(Inline)]
        internal NumericComparer(Func<T,T,int> comparer)
            => this.comparer = comparer;

        [MethodImpl(Inline)]
        public int Compare(T x, T y)
            => comparer(x,y);
    }
}