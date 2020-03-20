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
        /// Determines whether a type is a struct
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsStruct(this Type t)
            => t.IsValueType && !t.IsEnum;

        /// <summary>
        /// Determines whether the specified type is a delegate type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsDelegate(this Type t)
            => t.IsSubclassOf(typeof(Delegate));

        /// <summary>
        /// Returns true if the source type is either non-generic or a generic type that has been closed over all parameters
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsConcrete(this Type src)
            => !src.ContainsGenericParameters && !src.IsGenericParameter && !src.IsAbstract;

        /// <summary>
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsStatic(this Type t)
            => t.IsAbstract && t.IsSealed;

        /// <summary>
        /// Determines whether an attribute of parametric type is applied to a source type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static bool IsAttributed<A>(this Type src)
            where A : Attribute
                => System.Attribute.IsDefined(src,typeof(A));

        /// <summary>
        /// Determines whether a type implements a specified interface
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="interfaceType">The interface type</param>
        public static bool Realizes(this Type t, Type interfaceType)
            => interfaceType.IsInterface && t.Interfaces().Contains(interfaceType);

        /// <summary>
        /// Determines whether a type implements a specific interface
        /// </summary>
        /// <typeparam name="T">The interface type</typeparam>
        /// <param name="t">The type to examine</param>
        public static bool Realizes<T>(this Type t)        
            => typeof(T).IsInterface && t.Interfaces().Contains(typeof(T)); 

        /// <summary>
        /// Determines whether a type is nullable
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNullableType(this Type t)
            =>  (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
              | (t.IsGenericRef() && t.GetElementType().GetGenericTypeDefinition() == typeof(Nullable<>));

        /// <summary>
        /// Determine whether a type is a nullable type with a given underlying type
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <param name="t">The type to check</param>
        /// <returns>
        /// Returns true if t is both a nullable type and is of type T
        /// </returns>
        public static bool IsNullable<T>(this Type t)
            => t.IsNullableType() && Nullable.GetUnderlyingType(t) == typeof(T);

        public static bool IsNullable(this Type subject, Type match)
            => subject.IsNullableType() && Nullable.GetUnderlyingType(subject) == match;

        /// <summary>
        /// Determines whether a source type is predicated on a specified match type, including nullable wrappers, references and enums
        /// </summary>
        /// <typeparam name="T">The type to match</typeparam>
        /// <param name="candidate">The source type</param>
        /// <param name="match">The type to match</param>
        public static bool IsTypeOf(this Type candidate, Type match)
            => candidate.EffectiveType() == match
            || candidate.EffectiveType().IsNullable(match)
            || candidate.EffectiveType().IsEnum && candidate.EffectiveType().GetEnumUnderlyingType() == match;

        /// <summary>
        /// Determines whether a source type is predicated on a parametric type, including nullable wrappers, references and enums
        /// </summary>
        /// <param name="match">The source type</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static bool IsTypeOf<T>(this Type match)
            => match.EffectiveType() == typeof(T) 
            || match.EffectiveType().IsNullable<T>()
            || match.EffectiveType().IsEnum && match.EffectiveType().GetEnumUnderlyingType() == typeof(T);

        /// <summary>
        /// Returns true if the source type is non-null and non-void; otherwise, returns false
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this Type src)
            => src != null && src != typeof(void);

        /// <summary>
        /// Determines whether the type is a (memory) reference
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsRef(this Type src)
            => src.UnderlyingSystemType.IsByRef;

        /// <summary>
        /// Determines whether a type is a reference to a generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsGenericRef(this Type t)
            => t.IsRef() && t.GetElementType().IsGenericType;

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool HasDefaultPublicConstructor(this Type t)
            => t.GetConstructor(new Type[] { }) != null;

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <typeparam name="T">The type to examine</typeparam>
        public static bool HasDefaultPublicConstructor<T>()
            where T : class 
                => typeof(T).GetConstructor(new Type[] { }) != null; 
    }
}