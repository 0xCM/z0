//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;

    using static OpIdentity;

    public static class OpIdentities
    {
        public static IOpIdentityProvider Provider
            => default(DefaultProvider);


        readonly struct DefaultProvider : IOpIdentityProvider
        {
            public OpIdentity DefineIdentity(MethodInfo src, NumericKind k)
                => Identity.identify(src,k);

            public OpIdentity GroupIdentity(MethodInfo src)            
                => Identity.group(src);

            public OpIdentity GenericIdentity(MethodInfo src)            
                => Identity.generic(src);

            OpIdentity IOpIdentityProvider.DefineIdentity(MethodInfo src)
                => Identity.identify(src);
        }
    }
}