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
        public static WfContext context(IAppContext root, CorrelationToken ct, in WfSettings config)
            => new WfContext(root, ct, config, termsink(ct));   
    }
}