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

    }
}