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
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflections
    {
        /// <summary>
        /// Determines whether a type is an open generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsOpenGeneric(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return (t.IsGenericType || t.IsGenericTypeDefinition) && !t.IsConstructedGenericType;
        }

        /// <summary>
        /// If a type is non-generic, returns an emtpy list.
        /// If a type is open generic, returns a list of generic arguments
        /// If a type is closed generic, returns a list of the types that were supplied as arguments to construct the type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] GenericParameters(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return !(t.IsGenericType && !t.IsGenericTypeDefinition) ? new Type[]{} 
               : t.IsConstructedGenericType
               ? t.GetGenericArguments()
               : t.GetGenericTypeDefinition().GetGenericArguments();
        }

        /// <summary>
        /// For a non-constructed generic type or a generic type definition, returns an
        /// array of the method's type parameters; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] OpenTypeParameters(this Type t)
        {
            var effective = t.EffectiveType();
            return effective.ContainsGenericParameters ? effective.GetGenericTypeDefinition().GetGenericArguments()
             : effective.IsGenericTypeDefinition ? effective.GetGenericArguments()
             : new Type[]{};
        }

        public static int OpenTypeParameterCount(this Type t)
            => t.OpenTypeParameters().Length;

        public static int TypeParamerCount(this Type t)
            => t.GenericParameters().Length;

        public static IEnumerable<Type> SuppliedTypeArgs(this Type t)
        {
            var x = t.EffectiveType();
            if(x.IsConstructedGenericType)
                return x.GetGenericArguments();
            else
                return  new Type[]{};
        }

        public static bool IsClosedGeneric(this Type t, bool effective = true)
            => effective ? t.EffectiveType().IsConstructedGenericType : t.IsConstructedGenericType;

        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition;
        /// otherwise, returns the void type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GenericDefinition2(this Type t)
        {
            var effective = t.EffectiveType();
            if(effective.IsConstructedGenericType)
                return effective.GetGenericTypeDefinition();
            else if(effective.IsGenericTypeDefinition)
                return effective;
            else
                return typeof(void);            
        }


    }
}