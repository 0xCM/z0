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
        public static DispatcherProxy<F,T,D,S,Y> dispatcher<F,T,D,S,Y>(IWfContext wf, TableProcessors<D,S,T,Y> processors, Selectors<D,S> selectors)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T,D>
            where D : unmanaged, Enum
            where S : unmanaged        
                => new DispatcherProxy<F,T,D,S,Y>(wf, processors, selectors);
    }
}