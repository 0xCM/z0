
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VSvc)]

namespace Z0.Parts
{
    public sealed class VSvc : Part<VSvc>
    {        
        
    }
}


namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    partial class VSvc
    {


    }

    partial class VSvcHosts
    {
        static Type ApiG => typeof(gvec);

        static MethodInfo gApiMethod(Vec128Kind hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();

        static MethodInfo gApiMethod(Vec256Kind hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();
    }
}