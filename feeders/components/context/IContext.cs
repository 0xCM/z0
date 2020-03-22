//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    public interface IContext
    {
        PartId Owner
            => Assembly.GetEntryAssembly().Id();        
    }

    public interface IComposedContext : IContext
    {
        /// <summary>
        /// The assemblies available via the assigned composition
        /// </summary>
        IEnumerable<PartId> Components {get;}        
    }

    /// <summary>
    /// A context with parameteric state
    /// </summary>
    public interface IContext<S> : IContext
    {
        /// <summary>
        /// State shared with members of the context
        /// </summary>
        S State {get;}
    }
}