//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    
    [ServiceFactory]
    public static class ServiceFactory
    {
        internal static DynamicOps InnerDynamic(this IServiceFactory factory)
            => DynamicOps.Create(factory.DivinationContext(factory.MultiDiviner()));

        [MethodImpl(Inline)]
        public static IDynamicOps Dynamic(this IContext context)
            => context.Services.InnerDynamic();

        [MethodImpl(Inline)]
        public static IDynamicOps Dynamic(this IServiceFactory factory)
            => factory.InnerDynamic();
    }
}