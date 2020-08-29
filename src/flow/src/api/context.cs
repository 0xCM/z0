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
        [Op]
        public static IWfContext context(IAppContext root, WfConfig config, IWfEventLog log, CorrelationToken ct)
            => new WfContext(root, ct, config, AB.termsink(log, ct));
    }
}