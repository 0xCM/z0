//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TableFunctions;
    using static Konst;
    using static z;

    public readonly struct TableMap<T,Y> : ITableMap<TableMap<T,Y>,T,Y>
        where T : struct, ITable
    {
        readonly MapTable<T,Y> Fx;

        public TableMap(MapTable<T,Y> f)
        {
            Fx = f;
        }

        [MethodImpl(Inline)]
        public Y Map(in T x)
            => Fx(x);
    }
}