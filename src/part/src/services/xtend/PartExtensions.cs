//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;

    partial class XTend
    {
        public static string Describe(this PartId[] src)
            => src.Where(p => p != 0).Select(x => $"| {x.Format()} ").Concat();

        /// <summary>
        /// Joins the strings provided by the enumerable with an optional separator
        /// </summary>
        /// <param name="src">The source strings</param>
        /// <param name="sep">The separator, if any</param>
        static string Concat(this IEnumerable<string> src, string sep = null)
            => string.Join(sep ?? string.Empty, src);
            
        [MethodImpl(Inline)]
        public static string Format(this PartId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static string Format(this ExternId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            => Part.id(src);
    }
}