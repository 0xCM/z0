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
        public static WfContext wfctx(IAppContext root, in CorrelationToken ct, in WfConfig config, in WfTermEventSink sink)
            => new WfContext(root, ct, config, sink);       
    }
}