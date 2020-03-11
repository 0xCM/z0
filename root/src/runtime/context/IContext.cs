//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// A context of everything and yet to everyting nothing
    /// </summary>
    public interface IContext
    {
        AssemblyId Owner
            => Assembly.GetEntryAssembly().Id();
        
        IAppPaths Paths 
            => AppPathProvider.Create(Owner, Env.Current.LogDir);                         
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