//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Seq)]
    public static class Seq
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Seq<T> empty<T>()
            => Seq<T>.Empty;

        [Op, Closures(Closure)]
        public static Seq<T> create<T>(params T[] src)
            => create<T>(@readonly(src));

        [Op, Closures(Closure)]
        public static void format<T>(in Seq<T> src, char delimiter, ITextBuffer dst)
        {
            var count = src.Length;
            var terms = src.TermView;
            dst.Append(Chars.LBrace);
            for(var i=0; i<count; i++)
            {
                ref readonly var term = ref skip(terms,i);
                dst.Append(term.Format());
                if(i != count - 1)
                {
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }
            }
            dst.Append(Chars.RBrace);
        }

        [Op, Closures(Closure)]
        public static Seq<T> create<T>(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            if(count != 0)
            {
                var terms = new SeqTerm<T>[count];
                var dst = span(terms);
                for(var i=0u; i<count; i++)
                    seek(dst,i) = new SeqTerm<T>(i, skip(src,i));
                return create(terms);
            }
            else
                return empty<T>();
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Seq<T> create<T>(params SeqTerm<T>[] src)
            => new Seq<T>(src);
    }
}