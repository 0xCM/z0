//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    /// <summary>
    /// Characterizes a conduit that transmits singletons and sequences from A -> B
    /// </summary>
    public interface IPipe
    {
        object Flow(object src);

        IEnumerable<object> Flow(IEnumerable<object> src)        
        {
            foreach(var item in src)
                yield return Flow(src);
        }
    }
}