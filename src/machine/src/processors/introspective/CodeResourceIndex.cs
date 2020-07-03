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

        readonly ResourceDeclarations[] Index;

        public CodeResourceIndex(Assembly component)
        {
            Component = component;            
            Index = ResourceStore.Service.Declarations(component);
        }    
        
        public Type[] Hosts 
            => Index.Select(x => x.DeclaringType);
    }
  
}