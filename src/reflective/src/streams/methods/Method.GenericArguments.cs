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
    
    partial class XTend
    {
        /// <summary>
        /// Returns the arguments supplied to a constructed generic method; if the method is 
        /// nongeneric, a generic type definition or some other variant, an empty result is returned
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static IEnumerable<Type> GenericArguments(this MethodInfo src)
            => src.IsConstructedGenericMethod ? src.GetGenericArguments() : new Type[]{};
    }
}