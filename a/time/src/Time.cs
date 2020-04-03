//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class Time 
    {        
        [MethodImpl(Inline)]
        internal static T[] array<T>(params T[] src)
            => src;
    }
}