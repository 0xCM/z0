//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Collective)]

namespace Z0.Parts
{        
    public sealed class Collective : Part<Collective>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    public static class Collective
    {
        
        [MethodImpl(Inline)]
        internal static IEnumerable<T> seq<T>(params T[] src)
            => src;
    }

    public static partial class XCollective    
    {

    }

    public static partial class XTend
    {

        
    }
}
