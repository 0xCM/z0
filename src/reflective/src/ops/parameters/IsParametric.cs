//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    partial class Reflective
    {
        [MethodImpl(Inline), Op]
        public static bool IsParametric(this ParameterInfo src)
            => src.ParameterType.IsGenericParameter 
            || src.ParameterType.IsGenericMethodParameter 
            || src.ParameterType.IsGenericTypeParameter;
    }
}