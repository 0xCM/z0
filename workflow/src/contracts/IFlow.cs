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

    using static Root;

    /// <summary>
    /// Characterizes an orchestrator that coordinates data transmission
    /// </summary>
    public interface IFlow
    {
        [MethodImpl(Inline)]
        object Flow(object src, IPipe dst)
            => dst.Flow(src);

        [MethodImpl(Inline)]
        IEnumerable<object> Flow(IEnumerable<object> src, IPipe pipe)
            => pipe.Flow(src);
    }

}