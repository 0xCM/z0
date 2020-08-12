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
        public static DataBroker<K,C,T> broker<K,C,T>(IWfContext wf, int capacity, IndexFunction<K> xf)
            where K : unmanaged, Enum
                => new DataBroker<K,C,T>(wf, capacity, xf);
    }
}