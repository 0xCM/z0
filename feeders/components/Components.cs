//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Components)]

namespace Z0.Parts
{        
    public sealed class Components : Part<Components>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class Components
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        internal static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;

        internal static IEnumerable<T> items<T>(params T[] src)
            => src;

        /// <summary>
        /// Selects the method parameters that satisfy a predicate
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="predicate">The predicate to match</param>
        internal static IEnumerable<ParameterInfo> Parameters(this MethodInfo src, Func<ParameterInfo,bool> predicate)
            => src.GetParameters().Where(predicate);

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        internal static IEnumerable<Type> ParameterTypes(this MethodInfo m)
            => m.GetParameters().Select(p => p.ParameterType);

        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="m">The method to examine</param>
        internal static bool IsOpenGeneric(this MethodInfo m)
            => m.ContainsGenericParameters;

        /// <summary>
        /// Selects the open generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        internal static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.IsOpenGeneric());

        /// <summary>
        /// Determines whether a type is a constructed generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        internal static bool IsClosedGeneric(this Type t, bool effective = true)
            => effective ? t.EffectiveType().IsConstructedGenericType : t.IsConstructedGenericType;


        /// <summary>
        /// If a type is non-generic, returns an emtpy list.
        /// If a type is open generic, returns a list of generic arguments
        /// If a type is closed generic, returns a list of the types that were supplied as arguments to construct the type
        /// </summary>
        /// <param name="m">The method to examine</param>
        internal static Type[] GenericParameters(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return !(t.IsGenericType && !t.IsGenericTypeDefinition) ? new Type[]{} 
               : t.IsConstructedGenericType
               ? t.GetGenericArguments()
               : t.GetGenericTypeDefinition().GetGenericArguments();
        }

        /// <summary>
        /// Determines whether a type is an unconstructed generic type, also called an open generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        internal static bool IsOpenGeneric(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return (t.IsGenericType || t.IsGenericTypeDefinition) && !t.IsConstructedGenericType;
        }
 
        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        internal static IEnumerable<Type> EffectiveParameterTypes(this MethodInfo m)
            => m.ParameterTypes().Select(t => t.EffectiveType());

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        internal static IEnumerable<Type> ParameterTypes(this MethodInfo m, bool effective)
            => effective ? m.EffectiveParameterTypes() : m.ParameterTypes();

        /// <summary>
        /// Determines whether a parameter has a parametrically-identified attribute
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <typeparam name="A">The attribute type to check</typeparam>
        internal static bool Tagged<A>(this ParameterInfo p)
            where A : Attribute
                => System.Attribute.IsDefined(p, typeof(A));

        /// <summary>
        /// Selects the non-generic methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        internal static IEnumerable<MethodInfo> NonGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.ContainsGenericParameters && !t.IsConstructedGenericMethod);        

        /// <summary>
        /// Selects the methods from a stream where at least one parameter satisfies a specified predicate
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="predicate">The predicate to match</param>
        internal static IEnumerable<MethodInfo> WithParameter(this IEnumerable<MethodInfo> src, Func<ParameterInfo,bool> predicate)
            => from m in src
                where m.Parameters(predicate).Count() != 0
                select m;

        /// <summary>
        /// Selects the members with a particular name
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        internal static IEnumerable<T> WithName<T>(this IEnumerable<T> src, string name)
            where T : MemberInfo     
                => src.Where(x => x.Name == name); 


        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition;
        /// otherwise, returns the void type
        /// </summary>
        /// <param name="t">The type to examine</param>
        internal static Type GenericDefinition2(this Type t)
        {
            var effective = t.EffectiveType();
            if(effective.IsConstructedGenericType)
                return effective.GetGenericTypeDefinition();
            else if(effective.IsGenericTypeDefinition)
                return effective;
            else
                return typeof(void);            
        }

        internal static IEnumerable<Type> SuppliedTypeArgs(this Type t)
        {
            var x = t.EffectiveType();
            if(x.IsConstructedGenericType)
                return x.GetGenericArguments();
            else
                return  new Type[]{};
        }

    }
}