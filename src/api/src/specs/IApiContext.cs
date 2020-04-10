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

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IApiContext : IContext
    {
        /// <summary>
        /// The composition assigned to the context
        /// </summary>
        IApiComposition Composition {get;}

        /// <summary>
        /// The assemblies available via the assigned composition
        /// </summary>
        IEnumerable<PartId> Components
            => from r in Composition.Resolved
                select r.Id;        

        IEnumerable<ApiHost> Hosts
            => from owner in Composition.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner)
                from  host in owner
                select host;

        Option<ApiHost> FindHost(ApiHostUri uri)
            => Hosts.Where(h => h.UriPath == uri).FirstOrDefault();
    }
}