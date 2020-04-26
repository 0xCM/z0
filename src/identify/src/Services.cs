//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    using Api = Z0;

    public static class ServiceFactory
    {    
        [MethodImpl(Inline)]
        public static IDivinationContext DivinationContext(this IContext src, IMultiDiviner diviner)
            => Z0.DivinationContext.Create(src,diviner);

        [MethodImpl(Inline)]
        public static IDivinationContext DivinationContext(this IServiceFactory factory, IMultiDiviner diviner)
            => Z0.DivinationContext.Create(factory.Context, diviner);
        
    }

}