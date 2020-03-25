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
        internal static IContext Default => default(Context);        
        
        PartId Owner
            => Assembly.GetEntryAssembly().Id();        
    }

    public readonly struct Context : IContext
    {
        public static IContext Default => default(Context);
    }

    /// <summary>
    /// Characterizes a context that subsumes/extends/covers another context or state
    /// </summary>
    /// <typeparam name="R">The root context type</typeparam>
    public interface IContext<R> : IContext
    {
        R Content {get;}
    }   

    public interface IComposedContext : IContext
    {
        /// <summary>
        /// The assemblies available via the assigned composition
        /// </summary>
        IEnumerable<PartId> Components {get;}        
    }
    
    /// <summary>
    /// Characterizes a rooted composition
    /// </summary>
    /// <typeparam name="R">The root context type</typeparam>
    public interface IComposedContext<R> : IComposedContext, IContext<R>
        where R : IContext
    {

    }
}