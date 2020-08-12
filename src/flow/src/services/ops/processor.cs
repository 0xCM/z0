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
        public static DataProcessor<S,T> processor<S,T>(IWfContext wf, Process<S,T> f, S[] src, T[] dst)
            => new DataProcessor<S,T>(wf, f,src,dst);

        [MethodImpl(Inline)]
        public static TableProcessor<T,Y> processor<T,Y>(IWfContext wf, ProcessTable<T,Y> f)
            where T : struct, ITable
                => new TableProcessor<T,Y>(wf,f);
        
        [MethodImpl(Inline)]
        public static TableProcessor<D,S,T,Y> processor<T,D,S,Y>(IWfContext wf, ProcessTable<T,Y> f, Selector<D,S> id, T t = default, Y y = default)
            where D : unmanaged, Enum
            where T : struct, ITable
            where S : unmanaged
                => new TableProcessor<D,S,T,Y>(wf,f,id);
    }
}