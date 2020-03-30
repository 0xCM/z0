//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Reflective)]

namespace Z0.Parts
{        
    public sealed class Reflective : Part<Reflective>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    public static partial class Reflective
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static IEnumerable<T> seq<T>(params T[] src)
            => src;

        [MethodImpl(Inline)]
        internal static T[] array<T>(params T[] src)
            => src;

    }

    public static partial class XTend
    {

    }

}
