//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    partial struct ApiIdentify
    {
        [Op]
        public static HashSet<Type> typeset(NumericKind k)
            => distinct(k).Select(NumericKinds.type).ToHashSet();
    }
}