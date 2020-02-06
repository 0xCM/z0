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

    using static zfunc;

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

    /// <summary>
    /// Characterizes a data emission facility
    /// </summary>
    public interface IDataSource
    {
        IEnumerable<object> Data {get;}
    }
}