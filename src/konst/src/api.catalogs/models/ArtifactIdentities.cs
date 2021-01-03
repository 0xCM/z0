//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiIdentify
    {
        readonly struct ArtifactIdentities : IMultiDiviner
        {
            [MethodImpl(Inline)]
            public TypeIdentity DivineIdentity(Type src)
                => identify(src);

            [MethodImpl(Inline)]
            public OpIdentity DivineIdentity(MethodInfo src)
                => identify(src);

            [MethodImpl(Inline)]
            public OpIdentity DivineIdentity(Delegate src)
                => identify(src);

            [MethodImpl(Inline)]
            public ApiGenericOpIdentity GenericIdentity(MethodInfo src)
                => generic(src);
        }
    }
}