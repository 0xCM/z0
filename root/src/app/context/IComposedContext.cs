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

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IComposedContext : IContext
    {
        /// <summary>
        /// The composition assigned to the context
        /// </summary>
        IAssemblyComposition Compostion {get;}

        /// <summary>
        /// The assemblies available via the assigned composition
        /// </summary>
        IEnumerable<AssemblyId> Assemblies
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
    public interface IComposedContext<C> : IComposedContext
        where C : IComposedContext<C>
    {
 
    }

    /// <summary>
    /// Characterizes a stateful composed context reification
    /// </summary>
    public interface IComposedContext<C,S> : IComposedContext, IContext<S>
        where C : IComposedContext<C,S>
    {
 

    }
}