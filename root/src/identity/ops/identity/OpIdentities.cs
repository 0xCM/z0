//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    
    using static Root;
    using static IdentityShare;

    public static class OpIdentities
    {
        public static string name(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;

            var attribVal = attrib.Value;              
            return attribVal.Name.IsNotBlank() ? attribVal.Name : m.Name;                
        }


    }

}