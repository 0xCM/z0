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
        protected OpCatalog(AssemblyId id)
        {
            AssemblyId = id;
        }
        
        protected OpCatalog(AssemblyId id, DataResourceIndex resources)
            : this(id)
        {
            Resources = resources;
        }

        public AssemblyId AssemblyId {get;}
    
        public virtual IEnumerable<Type> ServiceHosts
            => new Type[]{};

        public virtual IEnumerable<ApiHost> GenericApiHosts
            => new ApiHost[]{};

        public virtual IEnumerable<ApiHost> DirectApiHosts
            => new ApiHost[]{};

        public DataResourceIndex Resources  {get; private set;}
            = DataResourceIndex.Empty;

        public void Share(DataResourceIndex resources)
        {
            if(Resources.IsEmpty)
                Resources = resources;
            else
                Merge(resources);
        }
        
        void Merge(DataResourceIndex src)        
            => Resources.Merge(src);
    }
}