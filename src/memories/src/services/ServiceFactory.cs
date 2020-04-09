//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public static class ServiceFactory
    {
        [MethodImpl(Inline)]
        public static IMemoryReader MemoryReader(this IContext context)
            => Z0.MemoryReader.Create(context);
    }
}