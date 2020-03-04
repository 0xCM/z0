//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// A context of everything and yet to everyting nothing
    /// </summary>
    public interface IContext
    {
        AssemblyId Owner
            => Assembly.GetEntryAssembly().AssemblyId();
        
        IAppPaths Paths 
            => AppPathProvider.Create(Owner, Env.Current.RunDir);   
                         
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