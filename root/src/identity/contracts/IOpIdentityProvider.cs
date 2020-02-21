//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public interface IOpIdentityProvider : IIdentityProvider<MethodInfo,OpIdentity>
    {
        IdentityKind IIdentityProvider.ProviderKind => IdentityKind.Operation;

        OpIdentity DefineIdentity(MethodInfo method);

        OpIdentity GroupIdentity(MethodInfo method);                    

        OpIdentity GenericIdentity(MethodInfo method);                    

        OpIdentity DefineIdentity(MethodInfo method, NumericKind k);
    }
}