//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static z;

    public static class ServiceFactories
    {
        public static ICommandExecStore CommandExecStore(this IAppContext context)
            => throw new  NotImplementedException();
    }
}