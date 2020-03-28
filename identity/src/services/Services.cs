//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public static class Services
    {
        [MethodImpl(Inline)]
        public static IMemberLocator MemberLocator(this IContext context)
            => Z0.MemberLocator.New(context);

        [MethodImpl(Inline)]
        public static IApiCollector OpCollector(this IContext context)
            => default(ApiOpCollector);

        [MethodImpl(Inline)]
        public static ITypeIdentityDiviner TypeIdDiviner(this IContext context)
            => default(TypeIdentityDiviner);

        [MethodImpl(Inline)]
        public static IMethodIdentityDiviner MethodIdDiviner(this IContext context)
            => default(MethodIdentityDiviner);
    }
}
