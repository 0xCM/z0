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
                var name = DeclaringAssembly.GetName().Name;
                var parts = name.Split('.');
                if(parts.Length != 0)
                    return parts.Last();
                else
                    return name;
            }
        }
            
        public virtual IEnumerable<GenericOpInfo> GenericOps 
            => new GenericOpInfo[]{};

        public virtual IEnumerable<DirectOpInfo> DirectOps 
            => new DirectOpInfo[]{};

        public virtual IEnumerable<GenericOpInfo> SpanOps 
            => new GenericOpInfo[]{};

        public virtual IEnumerable<Type> ServiceHosts
            => new Type[]{};

        public virtual IEnumerable<Type> GenericApiHosts
            => new Type[]{};

        public virtual IEnumerable<Type> DirectApiHosts
            => new Type[]{};

        public Assembly DeclaringAssembly 
            => typeof(C).Assembly;

    }

    public sealed class EmptyCatalog : OpCatalog<EmptyCatalog>
    {

    }

}