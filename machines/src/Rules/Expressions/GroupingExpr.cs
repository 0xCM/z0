//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;

    /// <summary>
    /// Groups an ordered expression sequence
    /// </summary>
    public readonly struct GroupingExpr<T> : IRuleExpr<List<T>>
        where T : IRuleExpr
    {
        public GroupingExpr(List<T> grouped)
        {
            this.Value = grouped;
        }
        

        public List<T> Value {get;}

    }
    
}