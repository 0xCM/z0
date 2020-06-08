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
    
    partial class XTend
    {
        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static FieldInfo[] LiteralFields(this Type src)
            => src.DeclaredFields().Literal();

        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static FieldInfo[] LiteralFields<T>(this Type src)
            => src.DeclaredFields().Literal().Where(f => f.FieldType == typeof(T));

        public static T[] LiteralFieldValues<T>(this Type src)
            => src.LiteralFields<T>().Select(f => (T)f.GetRawConstantValue());

    }
}