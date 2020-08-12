//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolContext : IToolContext
    {        
        public IAppPaths Paths {get;}

        public CorrelationToken Ct {get;}
        
        [MethodImpl(Inline)]
        public ToolContext(IAppPaths paths, CorrelationToken ct)
        {
            Paths = paths;
            Ct = ct;
        }
    }
}