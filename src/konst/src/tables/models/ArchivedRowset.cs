//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ArchivedRowset<T> : IDataFlow<Rowset<T>, ArchivedTable<T>>
        where T : struct
    {
        public Rowset<T> Source {get;}

        public ArchivedTable<T> Target {get;}

        [MethodImpl(Inline)]
        public ArchivedRowset(Rowset<T> src, ArchivedTable<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator ArchivedRowset<T>((Rowset<T> src, ArchivedTable<T> dst) x)
            => new ArchivedRowset<T>(x.src, x.dst);
    }
}