//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Identifies a where method
    /// </summary>
    public class WhereMethod : StandardMethod
    {
        public WhereMethod()
            : base(nameof(Enumerable.Where))
        { }
    }
}