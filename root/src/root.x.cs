//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public static partial class RootX
    {
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public static bool Designator(this Assembly a, out IAssemblyDesignator designator)
        {
            designator = null;
            var t = a.GetTypes().Where(x => !x.IsAbstract && x.GetInterfaces().Contains(typeof(IAssemblyDesignator))).FirstOrDefault();
            if(t != null)
            {
                designator = (IAssemblyDesignator)Activator.CreateInstance(t);
                return true;
            }
            return false;            
        }

        public static IOperationCatalog OperationCatalog(this Assembly a)
        {
            if(a.Designator(out var d))
                return d.Catalog;
            else 
                return new EmptyCatalog();
        }
    }
}