//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IComposedApiContext : IComposedContext, IAppContext
    {
        /// <summary>
        /// The composition assigned to the context
        /// </summary>
        IApiComposition Compostion {get;}

        /// <summary>
        /// The assemblies available via the assigned composition
        /// </summary>
        IEnumerable<AssemblyId> IComposedContext.Components
            => from r in Compostion.Resolved
                select r.Id;        

        IEnumerable<ApiHost> Hosts
            => from owner in Compostion.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner)
                from  host in owner
                select host;

        Option<ApiHost> FindHost(ApiHostUri uri)
            => Hosts.Where(h => h.Path == uri).FirstOrDefault();

    }

    /// <summary>
    /// Characterizes a stateless composed context reification
    /// </summary>
    public interface IComposedApiContext<C> : IComposedApiContext
        where C : IComposedApiContext<C>
    {
 
    }

    /// <summary>
    /// Characterizes a stateful composed context reification
    /// </summary>
    public interface IComposedApiContext<C,S> : IComposedApiContext, IAppContext<S>
        where C : IComposedApiContext<C,S>
    {
 

    }
}