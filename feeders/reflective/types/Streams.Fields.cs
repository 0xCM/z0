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
    
    partial class Reflective
    {
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
        /// Selects the public and non-public static fields declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredInstanceFields(this Type t)
            => t.GetFields(BF_DeclaredInstance);

        /// <summary>
        /// Attempts to retrieves a static field by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        public static IEnumerable<FieldInfo> DeclaredStaticFields(this Type t) 
            => t.DeclaredFields().Static();

        /// <summary>
        /// Selects all instance/static and public/non-public fields inhertited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> InheritedFields(this Type t)
            => t.Fields().Except(t.DeclaredFields());

        /// <summary>
        /// Retrieves the public instance Fields declared by a supertype
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> InheritedPublicFields(this Type src)
            => src.BaseType?.GetFields(BF_AllPublicInstance) ?? new FieldInfo[] { };

        /// <summary>
        /// Retrieves all public instance Fields declared or inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> PublicFields(this Type t)
            => t.InheritedPublicFields().Union(t.GetFields());

        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<FieldInfo> LiteralFields(this Type src)
            => src.DeclaredFields().Literal();

        /// <summary>
        /// Enumerates the literals defined by a type indexed by declaration order and which have names that match a specified filter
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<(int index, T value)> LiteralValues<T>(this Type src, string filter, int? maxcount = null)  
            where T : unmanaged  
        {
            var literals = src.LiteralFields().WithNameLike(filter).ToArray();
            var count = Math.Min(maxcount ?? literals.Length, literals.Length);
            for(var i=0; i<count; i++)
                yield return (i, (T)Convert.ChangeType(literals[i].GetValue(null), typeof(T)));
        }
    }
}