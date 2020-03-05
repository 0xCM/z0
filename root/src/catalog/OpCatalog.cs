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

    public abstract class OpCatalog<C> : IOpCatalog
        where C : OpCatalog<C>
    {
        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        public AssemblyId OwnerId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        public Assembly Owner {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        public virtual ApiHost[] ApiHosts {get;}

        public DataResourceIndex Resources  {get;}

        public virtual IEnumerable<Type> ServiceHostTypes {get;}

        public virtual IEnumerable<ApiHost> GenericApiHosts {get;}

        public virtual IEnumerable<ApiHost> DirectApiHosts {get;}

        protected OpCatalog(AssemblyId id)
        {
            OwnerId = id;
            Owner = typeof(C).Assembly;
            ApiHosts = ApiHost.HostTypes(Owner).Select(t => ApiHost.Define(OwnerId, t)).ToArray();
            Resources = DataResourceIndex.Empty;
            DirectApiHosts = ApiHosts.Where(h => h.HostKind.DefinesDirectOps());
            GenericApiHosts = ApiHosts.Where(h => h.HostKind.DefinesGenericOps());
            ServiceHostTypes = OpServiceProviders.Discover(Owner);
        }
        
        protected OpCatalog(AssemblyId id, DataResourceIndex resources)
            : this(id)
        {
            Resources = resources ?? DataResourceIndex.Empty;
        }                    
    }

    public sealed class EmptyCatalog : OpCatalog<EmptyCatalog>
    {
        public EmptyCatalog()
            : base(AssemblyId.None)
        {

        }               
    }    
}