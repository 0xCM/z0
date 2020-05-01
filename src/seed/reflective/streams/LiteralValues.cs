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

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Queries literal fields for their values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<object> LiteralValues(this IEnumerable<FieldInfo> src)
            => src.Literal().Select(f => f.GetRawConstantValue());

        /// <summary>
        /// Queries literal fields for their values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static object[] LiteralValues(this FieldInfo[] src)
            => src.Literal().Select(f => f.GetRawConstantValue());

        /// <summary>
        /// Queries literal fields for values of parametric type
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<T> LiteralValues<T>(this IEnumerable<FieldInfo> src)
            where T : unmanaged        
                => src.LiteralValues().Select(v => (T)v);

        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static FieldInfo[] LiteralFields(this Type src)
            => src.DeclaredFields().Literal();
    }
}