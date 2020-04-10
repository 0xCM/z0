//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IApiContext : IContext
    {
        /// <summary>
        /// The composition assigned to the context
        /// </summary>
        IApiComposition Composition {get;}

        Option<IApiHost> FindHost(ApiHostUri uri);
    }
}