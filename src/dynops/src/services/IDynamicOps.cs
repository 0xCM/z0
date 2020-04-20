//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Seed;

    using K = Kinds;

    public interface IDynamicOps : IDynamicVImm, IDynamicFactories, IFixedDynamic
    {
        
    }
}