//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static zfunc;

    public interface IOpIdentityProvider
    {
        Moniker DefineIdentity(MethodInfo method);

        Moniker GroupIdentity(MethodInfo method);                    

        Moniker GenericIdentity(MethodInfo method);                    

        Moniker DefineIdentity(MethodInfo method, NumericKind k);
    }
}