//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IOpIdentityProvider : IIdentityProvider<MethodInfo,OpIdentity>
    {
        IdentityTargetKind IIdentityProvider.ProviderKind => IdentityTargetKind.Method;

        OpIdentity DefineIdentity(MethodInfo method);

        OpIdentity GroupIdentity(MethodInfo method);                    

        OpIdentity GenericIdentity(MethodInfo method);                    

        OpIdentity DefineIdentity(MethodInfo method, NumericKind k);
    }
}