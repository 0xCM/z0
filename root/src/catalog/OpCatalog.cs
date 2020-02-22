//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class OpCatalog<C> : IOperationCatalog
        where C : OpCatalog<C>
    {
        public AssemblyId AssemblyId {get;}

        public DataResourceIndex Resources  {get;}

        public virtual ApiHost[] ApiHosts {get;}

        public virtual IEnumerable<Type> ServiceHostTypes {get;}

        public virtual IEnumerable<ApiHost> GenericApiHosts {get;}

        public virtual IEnumerable<ApiHost> DirectApiHosts {get;}

        protected OpCatalog(AssemblyId id)
        {
            AssemblyId = id;
            ApiHosts = ApiHost.HostTypes(typeof(C).Assembly).Select(t => ApiHost.Define(AssemblyId, t)).ToArray();
            Resources = DataResourceIndex.Empty;
            DirectApiHosts = ApiHosts.Where(h => h.HostKind.DefinesDirectOps());
            GenericApiHosts = ApiHosts.Where(h => h.HostKind.DefinesGenericOps());
            ServiceHostTypes =new Type[]{};
        }
        
        protected OpCatalog(AssemblyId id, DataResourceIndex resources)
            : this(id)
        {
            Resources = resources ?? DataResourceIndex.Empty;
        }                    
    }
}