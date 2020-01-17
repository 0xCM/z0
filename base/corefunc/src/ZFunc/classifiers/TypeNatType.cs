//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public static class TypeNatType
    {
        /// <summary>
        /// Determines whether a type is a natural number type
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool test(Type t)
            => t.Realizes<ITypeNat>();

        /// <summary>
        /// Determines whether a method accepts natural number type values as arguments
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool accepts(MethodInfo m)            
            => m.ParameterTypes().Any(t => test(t));

        /// <summary>
        /// Determines whether a (constructed) generic method has been supplied with type-natural arguments
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool closes(MethodInfo m)
            => m.IsConstructedGenericMethod && m.GetGenericArguments().Any(test);
        
        /// <summary>
        /// Selects the generic method parameters, if any, that have been closed with natural number types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> closures(MethodInfo m)
            => m.IsConstructedGenericMethod ? m.GetGenericArguments().Where(test) : items<Type>();

        /// <summary>
        /// For a type that encodes a natural number, returns the corresponding value; otherwise, returns null
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static ulong? value(Type t)
            => test(t) ? ((ITypeNat)Activator.CreateInstance(t)).NatValue : (ulong?)null;
    }
}
