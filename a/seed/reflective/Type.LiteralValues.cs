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
        /// Queries literal fields for values of parametric type
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<T> LiteralValues<T>(this IEnumerable<FieldInfo> src)
            where T : unmanaged        
            => from value in src.LiteralValues()
                select (T)value;

        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<FieldInfo> LiteralFields(this Type src)
            => src.DeclaredFields().Literal();

        /// <summary>
        /// Selects the literal fields defined by a type and extracts/casts their values
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The target value type</typeparam>
        public static IEnumerable<T> LiteralValues<T>(this Type src)
            where T : unmanaged        
                => src.LiteralFields().LiteralValues().Cast<T>();

        /// <summary>
        /// Enumerates the literals defined by a type indexed by declaration order and which have names that match a specified filter
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<(int index, T value)> LiteralValueIndex<T>(this Type src, string filter, int? maxcount = null)  
            where T : unmanaged  
        {
            var literals = src.LiteralFields().WithNameLike(filter).ToArray();
            var count = Math.Min(maxcount ?? literals.Length, literals.Length);
            for(var i=0; i<count; i++)
                yield return (i, (T)Convert.ChangeType(literals[i].GetValue(null), typeof(T)));
        }

    }
}