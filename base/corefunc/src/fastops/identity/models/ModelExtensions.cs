//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class FastOpX
    {
        public static ParamVariance Variance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamVariance.In  : src.IsOut 
            ? Z0.ParamVariance.Out : src.ParameterType.IsByRef 
            ? Z0.ParamVariance.Ref : Z0.ParamVariance.None;

        public static bool IsSome(this ParamVariance src)        
            => src != ParamVariance.None;

        public static string Keyword(this ParamVariance src)        
            => src switch{
                ParamVariance.In => "in",
                ParamVariance.Out => "out",
                ParamVariance.Ref => "ref",    
                _ => string.Empty
            };

        public static GenericKind GetGenericKind(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? GenericKind.Open 
               : src.IsClosedGeneric(false) ? GenericKind.Closed 
               : src.IsGenericTypeDefinition ? GenericKind.Definition 
               : GenericKind.None;

        public static GenericKind GetGenericKind(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? GenericKind.Open 
               : src.IsClosedGeneric() ? GenericKind.Closed 
               : src.IsGenericMethodDefinition ? GenericKind.Definition 
               : GenericKind.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this GenericKind kind)
            => kind != GenericKind.None;


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