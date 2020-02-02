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

    partial class FastOpX
    {
        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        public static TypeParameter[] TypeParameters(this MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => TypeParameter.Define(t.DisplayName(), i, t.IsGenericType));

        /// <summary>
        /// Retrives the primal kind of the first type parameter, if any
        /// </summary>
        /// <param name="method">The method to test</param>
        /// <param name="n">The generic parameter selector</param>
        [MethodImpl(Inline)]
        public static NumericKind TypeParameterKind(this MethodInfo method, N1 n)
            => (method.IsGenericMethod ? method.GetGenericArguments() : array<Type>()).FirstOrDefault()?.NumericKind() ?? Z0.NumericKind.None;
    }
}