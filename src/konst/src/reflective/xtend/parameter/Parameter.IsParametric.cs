//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a parameter's type is of some generic kind
        /// </summary>
        /// <param name="src">The source parameter</param>
        [MethodImpl(Inline)]
        public static bool IsTypeParametric(this ParameterInfo src)
            => src.ParameterType.IsGenericParameter 
            || src.ParameterType.IsGenericMethodParameter 
            || src.ParameterType.IsGenericTypeParameter;
    }
}