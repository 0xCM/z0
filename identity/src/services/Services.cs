//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class Services
    {
        [MethodImpl(Inline)]
        public static IMemberLocator MemberLocator(this IContext context, IMultiDiviner diviner = null)
            => Z0.MemberLocator.New(context, diviner ?? context.MultiDiviner());

        [MethodImpl(Inline)]
        public static IApiCollector OpCollector(this IContext context, IMultiDiviner diviner = null)
            => ApiCollector.Create(context, diviner ?? context.MultiDiviner());

        [MethodImpl(Inline)]
        public static IMultiDiviner MultiDiviner(this IContext context)
            => default(MultiDiviner);
    }
}
