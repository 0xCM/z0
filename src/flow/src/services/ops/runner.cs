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
        [MethodImpl(Inline), Op]
        public static WfRunner runner(Action<string[]> handler)
            => new WfRunner(handler);

        [MethodImpl(Inline)]
        public static WfRunner<T,K> runner<T,K>(Action<string[]> handler)
            where T : struct, IWfStep<T,K>
            where K : unmanaged, Enum
                => new WfRunner<T,K>(handler);
    }
}