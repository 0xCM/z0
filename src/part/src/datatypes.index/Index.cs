//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    public readonly struct Index
    {
        const NumericKind Closure = UInt64k;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T first<T>(T[] src)
            => ref first(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T last<T>(T[] src)
             => ref seek(src, src.Length - 1);

        public static Index<Y> map<T,Y>(T[] src, Func<T,Y> selector)
                => new Index<Y>(from x in src select selector(x));

        public static Index<Z> map<T,Y,Z>(T[] src, Func<T,Index<Y>> lift, Func<T,Y,Z> project)
            => new Index<Z>(array(from x in src
                            from y in lift(x).Storage
                            select project(x, y)));

        public static Index<Y> map<T,Y>(T[] src, Func<T,Index<Y>> lift)
            => new Index<Y>(array(from x in src
                            from y in lift(x).Storage
                            select y));

        public static Index<T> filter<T>(T[] src, Func<T,bool> predicate)
            => new Index<T>(from x in src where predicate(x) select x);

        [Op, Closures(Closure)]
        public static Index<T> reverse<T>(T[] src)
        {
            Array.Reverse(src);
            return src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit search<T>(T[] src, Func<T,bool> predicate, out T found)
        {
            var view = @readonly(src);
            var count = view.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(view,i);
                if(predicate(candidate))
                {
                    found = candidate;
                    return true;
                }
            }
            found = default;
            return false;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(T[] src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(src, delimiter);
    }

    partial class XTend
    {
        public static DelimitedIndex<T> Delimited<T>(this T[] src, char delimiter = FieldDelimiter)
            where T : unmanaged
                => Index.delimit(src, delimiter);

        public static DelimitedIndex<T> Delimited<T>(this IIndex<T> src, char delimiter = Chars.Comma)
            => Index.delimit(src.Storage, delimiter);
    }
}