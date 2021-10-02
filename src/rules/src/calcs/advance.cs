//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static RuleModels;

    partial struct RuleCalcs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AdvanceTo<T> advance<T>(Marker<T> marker)
            => new AdvanceTo<T>(marker);
    }
}