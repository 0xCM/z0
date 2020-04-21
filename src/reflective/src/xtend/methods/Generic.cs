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
        /// Returns the arguments supplied to a constructed generic method; if the method is 
        /// nongeneric, a generic type definition or some other variant, an empty result is returned
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static IEnumerable<Type> GenericArguments(this MethodInfo src)
            => src.IsConstructedGenericMethod ? src.GetGenericArguments() : new Type[]{};

        /// <summary>
        /// Selects generic methods from a stream that have a specified generic type definition parameter
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="typedef">The type definition to match</param>
        public static IEnumerable<MethodInfo> WithGenericParameterType(this IEnumerable<MethodInfo> src, Type typedef)
            => src.Where(m => m.GetParameters().Any(
                    p => p.ParameterType.IsGenericTypeDefinition && p.ParameterType == typedef));

        /// <summary>
        /// For a non-constructed generic method or a generic method definition, returns an array of the method's type parameters; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] OpenTypeParameters(this MethodInfo m, bool effective)
            => (m.ContainsGenericParameters ? m.GetGenericMethodDefinition().GetGenericArguments()
             : m.IsGenericMethodDefinition ? m.GetGenericArguments()
             : new Type[]{}).Select(arg => effective ? arg.EffectiveType() : arg).ToArray();

        /// <summary>
        /// For a closed generic method, returns the supplied arguments; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="effective">Whether to yield effective types or types as reported by the framework reflection api</param>
        public static Type[] SuppliedTypeArgs(this MethodInfo m, bool effective = true)
            => m.IsConstructedGenericMethod ? m.GenericParameters(effective) : new Type[]{};
    }
}