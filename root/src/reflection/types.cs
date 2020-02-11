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
    using System.ComponentModel;
    using System.Collections.Concurrent;

    using static ReflectionFlags;

    partial class RootReflections
    {
        /// <summary>
        /// Returns true if the source type is either non-generic or a generic type that has been closed over all parameters
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool Concrete(this Type src)
            => !src.ContainsGenericParameters && !src.IsGenericParameter && !src.IsAbstract;

        /// <summary>
        /// Selects the concrete types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Concrete(this IEnumerable<Type> src)
            => src.Where(Concrete);

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
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;

        /// <summary>
        /// Returns the underlying system type if enclosed by a source type, otherwise returns the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static Type Unwrap(this Type src)
            => src.GetElementType() ?? src;

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> Fields(this Type src)
            => src.GetFields(BF_All);

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredFields(this Type src)
            => src.GetFields(BF_Declared);

        /// <summary>
        /// Selects the fields accessible via a type but which the type itself does nto declare
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> UndeclaredFields(this Type src)
            => src.Fields().Except(src.DeclaredFields());

        /// <summary>
        /// Retrieves the type's fields together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        public static IDictionary<FieldInfo, A> FieldAttributions<A>(this Type t) 
            where A : Attribute
        {
            var selection = from f in t.DeclaredFields()
                            where f.Attributed<A>()
                            let a = f.GetCustomAttribute<A>()
                            select (f,a);
            return selection.ToDictionary();
        }

        /// <summary>
        /// Selects any source types that have a parametrically-identified attribution
        /// </summary>
        /// <param name="src">The source stypes</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IEnumerable<Type> Attributed<A>(this IEnumerable<Type> src)
            where A : Attribute
                => src.Where(t => Attribute.IsDefined(t, typeof(A)));

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
        /// Returns all interfaces realized by the type, including those inherited from
        /// supertypes
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<Type> Interfaces(this Type t)
            => t.GetInterfaces() ?? new Type[]{};

        /// <summary>
        /// Returns all source types which ar interfaces
        /// </summary>
        /// <param name="src">The source types</param>
        public static IEnumerable<Type> Interfaces(this IEnumerable<Type> src)
            => src.Where(t => t.IsInterface);

        /// <summary>
        /// Returns all source types which are classes
        /// </summary>
        /// <param name="src">The source types</param>
        public static IEnumerable<Type> Classes(this IEnumerable<Type> src)
            => src.Where(t => t.IsClass);

        /// <summary>
        /// Returns all source types which are structs
        /// </summary>
        /// <param name="src">The source types</param>
        public static IEnumerable<Type> Structs(this IEnumerable<Type> src)
            => src.Where(t => t.IsStruct());

        /// <summary>
        /// Returns all source types which are delegates
        /// </summary>
        /// <param name="src">The source types</param>
        public static IEnumerable<Type> Delegates(this IEnumerable<Type> src)
            => src.Where(t => t.IsDelegate());

        /// <summary>
        /// Returns all source types which are enums
        /// </summary>
        /// <param name="src">The source types</param>
        public static IEnumerable<Type> Enums(this IEnumerable<Type> src)
            => src.Where(t => t.IsEnum);

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
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => m.ReturnType != typeof(void);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsEmitter(this MethodInfo m)
            => m.IsFunction() && m.HasArity(0);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src)
            => src.GetMethods(BF_Declared);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type that have a specific name
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src, string name)
            => src.GetMethods(BF_Declared).Where(m => m.Name == name);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared or exposed by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> Methods(this Type src, bool declared = true)
            => declared ? src.GetMethods(BF_Declared) : src.GetMethods(BF_All);
 
        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a stream of types
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this IEnumerable<Type> src)
            => src.Select(x => x.DeclaredMethods()).SelectMany(x => x);

        public static IEnumerable<MethodInfo> Methods(this IEnumerable<Type> src, bool declared)
            => src.Select(x => x.Methods(declared)).SelectMany(x => x);
    }
}