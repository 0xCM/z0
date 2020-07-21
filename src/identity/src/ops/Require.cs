//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
 
    using static Konst;
    
    partial class Identity
    {
        /// <summary>
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        static void RequireNonGeneric(MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        /// <summary>
        /// Raises an error if the source method is not a constructed generic method
        /// </summary>
        /// <param name="src">The method to examine</param>
        static void RequireConstructed(MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw AppErrors.NonGenericMethod(src);
        }        
    }
}