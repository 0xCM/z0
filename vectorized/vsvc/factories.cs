//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    partial class VSvcFactories
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