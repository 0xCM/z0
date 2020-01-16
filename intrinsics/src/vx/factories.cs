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


        static MethodInfo gApiMethod(N128 w, string name)
            => ApiG.Methods().WithName(name).Vectorized(128).Single();
            
        static MethodInfo gApiMethod(N256 w, string name)
            => ApiG.Methods().WithName(name).Vectorized(256).Single();

    }
}