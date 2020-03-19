//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Catalogs resource, operations and services provied by an assembly
    /// </summary>
    /// <typeparam name="C">The reifying type</typeparam>
    public abstract class ApiCatalog<C> : IApiCatalog
        where C : ApiCatalog<C>
    {
        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        public AssemblyId AssemblyId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        public Assembly CatalogedAssembly {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        public ApiHost[] ApiHosts {get;}

        public DataResourceIndex Resources  {get;}

        public Type[] HostTypes {get;}

        public ApiHost[] GenericApiHosts {get;}

        public ApiHost[] DirectApiHosts {get;}

        protected ApiCatalog(AssemblyId id)
        {
            AssemblyId = id;
            CatalogedAssembly = typeof(C).Assembly;
            ApiHosts = ApiHost.HostTypes(CatalogedAssembly).Select(t => ApiHost.Define(AssemblyId, t)).ToArray();
            Resources = DataResourceIndex.Empty;
            DirectApiHosts = ApiHosts.Where(h => h.HostKind.DefinesDirectOps()).ToArray();
            GenericApiHosts = ApiHosts.Where(h => h.HostKind.DefinesGenericOps()).ToArray();
            HostTypes = ApiServices.ProviderTypes(CatalogedAssembly).ToArray();
        }
        
        protected ApiCatalog(AssemblyId id, DataResourceIndex resources)
            : this(id)
        {
            Resources = resources ?? DataResourceIndex.Empty;
        }                    
    }

    public sealed class EmptyCatalog : ApiCatalog<EmptyCatalog>
    {
        public EmptyCatalog()
            : base(AssemblyId.None)
        {

        }               
    }    
}