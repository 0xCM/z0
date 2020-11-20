//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableProjector<T,Y> : ITableProjector<TableProjector<T,Y>,T,Y>
        where T : struct
    {
        readonly Func<T,Y> Fx;

        [MethodImpl(Inline)]
        public TableProjector(Func<T,Y> f)
            => Fx = f;

        [MethodImpl(Inline)]
        public Y Project(in T x)
            => Fx(x);
    }
}