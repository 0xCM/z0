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
        internal static DynamicOpsSvc InnerDynamic(this IContext context)
            => DynamicOpsSvc.Create(context.DivinationContext(context.MultiDiviner()));

        [MethodImpl(Inline)]
        public static IDynamicOps Dynamic(this IContext context)
            => context.InnerDynamic();
    }
}