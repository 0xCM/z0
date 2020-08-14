//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ProcessFx;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static WfDataHandler<S,T> processor<S,T>(IWfContext wf, Map<S,T> f, S[] src, T[] dst)
            => new WfDataHandler<S,T>(wf, f,src,dst);

        [MethodImpl(Inline)]
        public static WfTableMap<T,Y> processor<T,Y>(IWfContext wf, MapTable<T,Y> f)
            where T : struct, ITable
                => new WfTableMap<T,Y>(wf,f);
        
        [MethodImpl(Inline)]
        public static WfTableMap<D,S,T,Y> processor<T,D,S,Y>(IWfContext wf, MapTable<T,Y> f, Selector<D,S> id, T t = default, Y y = default)
            where D : unmanaged, Enum
            where T : struct, ITable
            where S : unmanaged
                => new WfTableMap<D,S,T,Y>(wf,f,id);
    }
}