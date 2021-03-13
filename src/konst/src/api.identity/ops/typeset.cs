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

    partial struct ApiIdentity
    {
        [Op]
        public static HashSet<Type> typeset(NumericKind k)
            => ApiIdentity.distinct(k).Select(NumericKinds.type).ToHashSet();
    }
}