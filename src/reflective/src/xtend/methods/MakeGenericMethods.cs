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
    
    partial class Reflective
    {
        /// <summary>
        /// Creates generic methods of parametric arity *1*
        /// </summary>
        /// <param name="src"></param>
        /// <param name="args"></param>
        public static IEnumerable<MethodInfo> MakeGenericMethods(this MethodInfo src, params Type[] args)
            => args.Select(arg => src.GetGenericMethodDefinition().MakeGenericMethod(arg));

        public static Option<MethodInfo> GenericMethodDefinition(this Type src, string name)    
            => from m in src.Method(name)                
                where  m.IsGenericMethod
                let d = m.GetGenericMethodDefinition()
                select d;
    }
}