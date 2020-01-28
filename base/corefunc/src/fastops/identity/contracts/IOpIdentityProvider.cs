//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static zfunc;


    public interface IOpIdentityProvider
    {
        Moniker DefineIdentity(MethodInfo method);

        Option<Moniker> GenericIdentity(MethodInfo method);                    

        Moniker DefineIdentity(MethodInfo method, NumericKind k);

    }
}