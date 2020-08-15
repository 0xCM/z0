//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfCore    
    {
        [Op]
        public static IWfContext context(IAppContext root, WfConfig config, CorrelationToken ct)
            => new WfContext(root, ct, config, WfCore.termsink(ct));
    }
}