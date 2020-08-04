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
        public static WfContext context(IAppContext root, in CorrelationToken ct, in WfSettings config, in WfTermEventSink sink)
            => new WfContext(root, ct, config, sink);       
    }
}