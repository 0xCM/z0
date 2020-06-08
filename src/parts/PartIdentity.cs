//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    public class PartIdentity
    {

        [MethodImpl(Inline)]
        public static IEnumerable<T> seq<T>(params T[] src)
            => src;

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        
    }
}