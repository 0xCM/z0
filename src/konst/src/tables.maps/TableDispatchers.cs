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

    public readonly struct TableDispatchers
    {
        [MethodImpl(Inline)]
        public static TableProjector<T,Y> projector<T,Y>(Func<T,Y> f)
            where T : struct
                => new TableProjector<T,Y>(f);

        [MethodImpl(Inline)]
        public static TableProjector<D,S,T,Y> projector<T,D,S,Y>(Func<T,Y> f, IndexKey<D,S> index, T t = default, Y y = default)
            where D : unmanaged
            where T : struct
            where S : unmanaged
                => new TableProjector<D,S,T,Y>(f,index);

        [MethodImpl(Inline)]
        public static TableDispatcher<F,T,D,S,Y> create<F,T,D,S,Y>(IWfShell wf, TableProjectors<D,S,T,Y> projectors, IndexKeys<D,S> selectors)
            where F : unmanaged
            where T : struct, IKeyedTable<F,T,D>
            where D : unmanaged
            where S : unmanaged
                => new TableDispatcher<F,T,D,S,Y>(wf, projectors, selectors);
    }
}