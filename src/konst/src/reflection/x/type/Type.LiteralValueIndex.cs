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

    partial class XReflex
    {
        /// <summary>
        /// Selects the literal fields defined by a type and extracts/casts their values
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The target value type</typeparam>
        [Op, Closures(Closure)]
        public static T[] LiteralValues<T>(this Type src)
            where T : unmanaged
                => src.LiteralFields().LiteralValues().Cast<T>().ToArray();

        /// <summary>
        /// Enumerates the literals defined by a type indexed by declaration order and which have names that match a specified filter
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is required to be declared by the type</param>
        [Op, Closures(Closure)]
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