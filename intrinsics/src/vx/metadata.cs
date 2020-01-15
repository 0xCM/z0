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
        public static IEnumerable<Type> Reifications
            => from t in typeof(VXTypes).GetNestedTypes().Realize<IFunc>() select t;

    }


}