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
        public static WfTableMap<T,Y> map<T,Y>(IWfContext wf, MapTable<T,Y> f)
            where T : struct, ITable
                => new WfTableMap<T,Y>(wf,f);
        
        [MethodImpl(Inline)]
        public static WfTableMap<D,S,T,Y> map<T,D,S,Y>(IWfContext wf, MapTable<T,Y> f, TableSelector<D,S> id, T t = default, Y y = default)
            where D : unmanaged, Enum
            where T : struct, ITable
            where S : unmanaged
                => new WfTableMap<D,S,T,Y>(wf,f,id);
    }
}