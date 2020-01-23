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
        public virtual string CatalogName
        {
            get 
            {
                if(DeclaringAssembly.Designator(out var designator) && designator.Id != AssemblyId.None)
                {
                    return designator.Id.ToString().ToLower();
                }
                else
                {
                    var name = DeclaringAssembly.GetName().Name;
                    var parts = name.Split('.');
                    if(parts.Length != 0)
                        return parts.Last();
                    else
                        return name;
                }
            }
        }
            
        public virtual bool IsEmpty
            => false;            
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

        public Assembly DeclaringAssembly 
            => typeof(C).Assembly;

        public virtual IEnumerable<DataResource> Resources 
            => new DataResource[]{};
    }

    public sealed class EmptyCatalog : OpCatalog<EmptyCatalog>
    {
        public override bool IsEmpty => true;

        public override string CatalogName => "empty";
    }

}