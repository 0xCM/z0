//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static partial class Identity
    {

        readonly struct OpIdentityProvider : IOpIdentityProvider
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