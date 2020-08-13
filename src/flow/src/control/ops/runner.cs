//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static WfRunner<A> runner<A>(IWfContext wf, Action<A> handler, A? args = null)
            where A : struct
                => new WfRunner<A>(wf, handler, args);

        [MethodImpl(Inline)]
        public static WfTableRunner<F,T,D,S,Y> runner<F,T,D,S,Y>(IWfContext wf, WfTableMaps<D,S,T,Y> processors, Selectors<D,S> selectors)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T,D>
            where D : unmanaged, Enum
            where S : unmanaged        
                => new WfTableRunner<F,T,D,S,Y>(wf, processors, selectors);
    }
}