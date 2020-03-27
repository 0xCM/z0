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
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredFields(this Type src)
            => src.GetFields(BF_Declared);

        /// <summary>
        /// Selects the literal fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Literal(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsLiteral);

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