//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    using static VXTypes;

    partial class VX
    {


    }

    partial class VXTypes
    {
        static Type ApiG => typeof(ginx);

        static MethodInfo gApiMethod(HK.Vec128 hk, string name)
            => ApiG.Methods().WithName(name).OfKind(hk).Single();

        static MethodInfo gApiMethod(HK.Vec256 hk, string name)
            => ApiG.Methods().WithName(name).OfKind(hk).Single();
    }
}