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

    public class ApiCatalog : IApiCatalog
    {
        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        public PartId PartId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        public Assembly Part {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        public ApiHost[] ApiHosts {get;}

        public BinaryResources Resources  {get;}

        public Type[] HostTypes {get;}

        public ApiHost[] GenericApiHosts {get;}

        public ApiHost[] DirectApiHosts {get;}

        public ApiCatalog(Assembly source, PartId id)
        {
            PartId = id;
            Part = source;
            ApiHosts = ApiHost.HostTypes(Part).Select(t => ApiHost.Define(PartId, t)).ToArray();
            Resources = BinaryResources.Empty;
            DirectApiHosts = ApiHosts.Where(h => h.HostKind.DefinesDirectOps()).ToArray();
            GenericApiHosts = ApiHosts.Where(h => h.HostKind.DefinesGenericOps()).ToArray();
            HostTypes = ApiServices.ProviderTypes(Part).ToArray();
        }
        
        public ApiCatalog(Assembly source, PartId id, BinaryResources resources)
            : this(source,id)
        {
            Resources = resources ?? BinaryResources.Empty;
        }                            

        public ApiCatalog(Assembly source, PartId id, IBinaryResourceProvider provider)
            : this(source,id)
        {
            Resources = BinaryResources.Create(provider);
        }                            
    }

    /// <summary>
    /// Catalogs resource, operations and services provied by an assembly
    /// </summary>
    /// <typeparam name="C">The reifying type</typeparam>
    public abstract class ApiCatalog<C> : ApiCatalog
        where C : ApiCatalog<C>
    {
        protected ApiCatalog(PartId id)
            : base(typeof(C).Assembly, id)
        {
        }
        
        protected ApiCatalog(PartId id, BinaryResources resources)
            : base(typeof(C).Assembly, id, resources)
        {

        }                    
    }
}