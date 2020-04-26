//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    partial class Reflective
    {
        public static IEnumerable<Type> SuppliedTypeArgs(this Type t)
        {
            var x = t.EffectiveType();
            if(x.IsConstructedGenericType)
                return x.GetGenericArguments();
            else
                return  new Type[]{};
        }

    }
}