//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct OldFlow    
    {
        [Op]
        public static IWfContext context(IAppContext root, WfConfig config, CorrelationToken ct)
            => new WfContext(root, ct, config, Flow.termsink(ct));
    }
}