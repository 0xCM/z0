//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

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