//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static FieldInfo[] LiteralFields(this Type src)
            => src.DeclaredFields().Literals();

        /// <summary>
        /// Selects the literal fields declared by a type that are of specified type 
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="match">The type to match</param>
        public static FieldInfo[] LiteralFields(this Type src, Type match)
            => src.DeclaredFields().Literals(match);

        /// <summary>
        /// Selects the literal fields declared by a parametric type that are of specified type 
        /// </summary>
        /// <param name="match">The type to match</param>
        public static FieldInfo[] LiteralFields<T>(this Type match)
            => match.DeclaredFields().Literals().Where(f => f.FieldType == typeof(T));

        /// <summary>
        /// Selects the literal values declared by a type that are of specified parametric type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The literal value type</typeparam>
        public static FieldValues<T> LiteralFieldValues<T>(this Type src)
            where T : unmanaged
                => Z0.FieldValues.from<T>(src);

        /// <summary>
        /// Selects the literal values declared by a type that are of specified parametric type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The literal value type</typeparam>
        public static FieldValues<E,T> LiteralFieldValues<E,T>(this Type src)
            where E : unmanaged, Enum
            where T : unmanaged
                => Z0.FieldValues.from<E,T>(src);
    }
}