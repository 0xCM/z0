//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Time)]

namespace Z0.Parts
{        
    public sealed class Time : Part<Time>
    {

    }    
}

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