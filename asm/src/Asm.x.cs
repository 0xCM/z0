//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Root;

    public static partial class AsmExtend
    {
        // public static IEnumerable<ApiHost> KnownHosts(this IComposedContext src)
        //     => from owner in src.Compostion.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner)
        //         from  host in owner
        //         select host;
    }
}