//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public partial interface TIdentityReflector
    {
        [MethodImpl(Inline)]
        bool IsHomogenous(MethodInfo m)
            => IdentityReflector.Service.IsHomogenous(m);    
    }
}