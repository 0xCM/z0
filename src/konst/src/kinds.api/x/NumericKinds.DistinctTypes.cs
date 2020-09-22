//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Specifies the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static HashSet<Type> DistinctTypes(this NumericKind k)
            => ApiIdentityKinds.typeset(k);
    }
}