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
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        
        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ParameterTypes(this MethodInfo m)
        {
            var parameters = m.GetParameters().Select(p => p.ParameterType);
            // if(returntype && !m.ReturnType.IsVoid()) 
            //     return array(m.ReturnType).Union(parameters);
            // else
                return parameters;
        }                    
    }
}