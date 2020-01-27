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
        // {
        //     get 
        //     {
        //         if(AssemblyId != AssemblyId.None)
        //             return AssemblyId.ToString().ToLower();
        //         else
        //         {
        //             var name = DeclaringAssembly.GetName().Name;
        //             var parts = name.Split('.');
        //             if(parts.Length != 0)
        //                 return parts.Last();
        //             else
        //                 return name;
        //         }
        //     }
        // }

        protected OpCatalog()
        {
            if(DeclaringAssembly.Designator(out var designator))
                AssemblyId = designator.Id;
            else
                AssemblyId = AssemblyId.None;
            this.CatalogName = AssemblyId.ToString().ToLower();
            
        }

        protected OpCatalog(AssemblyId id)
        {
            AssemblyId = id;
            CatalogName = id.ToString().ToLower();

        }
        
        protected OpCatalog(AssemblyId id, DataResourceIndex resources)
            : this(id)
        {
            Resources = resources;
        }

        public Assembly DeclaringAssembly {get;} 
            = typeof(C).Assembly;

        public virtual AssemblyId AssemblyId {get;}

        public virtual string CatalogName {get;}

        public virtual bool IsEmpty {get;}
            = false;

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

    public sealed class EmptyCatalog : OpCatalog<EmptyCatalog>
    {
        public override bool IsEmpty => true;

        public override string CatalogName => "empty";

        public override AssemblyId AssemblyId => AssemblyId.None;

        
    }

}