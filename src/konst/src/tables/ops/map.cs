//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static TableFunctions;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableMap<T,Y> map<T,Y>(MapTable<T,Y> f)
            where T : struct, ITable
                => new TableMap<T,Y>(f);

        [MethodImpl(Inline)]
        public static TableMap<D,S,T,Y> map<T,D,S,Y>(MapTable<T,Y> f, TableSelector<D,S> id, T t = default, Y y = default)
            where D : unmanaged, Enum
            where T : struct, ITable
            where S : unmanaged
                => new TableMap<D,S,T,Y>(f,id);

    }
}