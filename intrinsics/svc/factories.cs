//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    partial class VF
    {


    }

    partial class VFTypes
    {
        static Type ApiG => typeof(ginx);

        static MethodInfo gApiMethod(VKT.Vec128 hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();

        static MethodInfo gApiMethod(VKT.Vec256 hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();
    }
}