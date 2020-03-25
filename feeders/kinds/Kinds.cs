//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Kinds)]

namespace Z0.Parts
{        
    public sealed class Kinds : Part<Kinds>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class Kinds
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        internal static IEnumerable<T> items<T>(params T[] src)
            => src;
    }
}