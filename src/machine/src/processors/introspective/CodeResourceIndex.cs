//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public readonly struct CodeResourceIndex
    {
        readonly Assembly Component;

        readonly ResourceAccessors[] Index;

        public CodeResourceIndex(Assembly component)
        {
            Component = component;            
            Index = ResourceStore.Service.AccesorIndex(Component);
        }    

        public ReadOnlySpan<ResourceAccessors> Accessors
            => Index;
        
        public IEnumerable<Type> Hosts 
            => Index.Select(i => i.DeclaringType);
    }
  
}