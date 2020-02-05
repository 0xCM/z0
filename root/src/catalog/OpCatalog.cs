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

    public abstract class OpCatalog<C> : IOperationCatalog
        where C : OpCatalog<C>
    {

        protected OpCatalog(AssemblyId id)
        {
            AssemblyId = id;
            CatalogName = id.Format();
        }
        
        protected OpCatalog(AssemblyId id, DataResourceIndex resources)
            : this(id)
        {
            Resources = resources;
        }

        public Assembly HostAssembly {get;} 
            = typeof(C).Assembly;

        public AssemblyId AssemblyId {get;}

        public virtual string CatalogName {get;}

        public bool IsEmpty
            => AssemblyId == AssemblyId.Empty || AssemblyId == AssemblyId.None;

        public virtual IEnumerable<GenericOpSpec> GenericOps 
            => new GenericOpSpec[]{};

        public virtual IEnumerable<DirectOpSpec> DirectOps 
            => new DirectOpSpec[]{};

        public virtual IEnumerable<GenericOpSpec> SpanOps 
            => new GenericOpSpec[]{};

        public virtual IEnumerable<Type> ServiceHosts
            => new Type[]{};

        public virtual IEnumerable<Type> GenericApiHosts
            => new Type[]{};

        public virtual IEnumerable<Type> DirectApiHosts
            => new Type[]{};

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