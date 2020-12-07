//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Linq;

    /// <summary>
    /// Identifies a select method
    /// </summary>
    public class SelectMethod : StandardMethod
    {
        public SelectMethod()
            : base(nameof(Enumerable.Select))
        { }
    }
}