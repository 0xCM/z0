//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Vectors;
    using static Typed;

    public abstract class t_permute<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_permute<U>,new()
    {

    }

}