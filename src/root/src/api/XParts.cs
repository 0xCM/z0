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

    using static Root;

    partial class XTend
    {
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> src)
            where T : IComparable<T>
                => src.OrderBy(x => x);

        public static T[] Sort<T>(this T[] src)
            where T : IComparable<T>
        {
            Array.Sort(src);
            return src;
        }


        [MethodImpl(Inline), Op]
        public static PartId Id(this Assembly src)
            => Root.id(src);

        [MethodImpl(Inline), Op]
        public static PartName PartName(this PartId id)
            => id;

        [MethodImpl(Inline), Op]
        public static PartName PartName(this Assembly src)
            => Root.id(src);

        [Op]
        public static string SimpleName(this AssemblyName src)
            => src.FullName.LeftOfFirst(Chars.Comma);

        [Op]
        public static bool IsPart(this AssemblyName src)
            => src.SimpleName().StartsWith("z0.");

        [MethodImpl(Inline), Op]
        public static string Format(this PartId id)
            => Root.format(id);

        [MethodImpl(Inline), Op]
        public static string[] Componentize(this PartId id)
            => Root.componentize(id);
    }
}