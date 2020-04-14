//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Svc = Z0;

    public static class ServiceFactory
    {
        [MethodImpl(Inline)]
        public static IMemberLocator MemberLocator(this IContext context, IMultiDiviner diviner = null)
            => Svc.MemberLocator.New(context, diviner ?? context.MultiDiviner());

        [MethodImpl(Inline)]
        public static IApiCollector ApiCollector(this IContext context, IMultiDiviner diviner = null)
            => Svc.ApiCollector.Create(context, diviner ?? context.MultiDiviner());

        [MethodImpl(Inline)]
        public static IMultiDiviner MultiDiviner(this IContext context)
            => default(MultiDiviner);
    }
}
