//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public static class Sequence
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SeqSplitter<T> splitter<T>(T delimiter)
            where T : unmanaged
                => new SeqSplitter<T>(delimiter);

        [Op, Closures(Closure)]
        public static Index<SeqTerm<T>> terms<T>(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            var buffer = alloc<SeqTerm<T>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new SeqTerm<T>(i,skip(src,i));
            return buffer;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Seq<T> empty<T>()
            => Seq<T>.Empty;

        [Op, Closures(Closure)]
        public static Seq<T> create<T>(params T[] src)
            => create<T>(@readonly(src));

        /// <summary>
        /// Renders the term by default as 'a_i = Value' where i denotes the term index
        /// </summary>
        /// <param name="name">The sequence identifier, if specified</param>
        [Op, Closures(Closure)]
        public static string format<T>(in SeqTerm<T> src, char? name = null)
            => src.IsEmpty ? "{}" : $"{name ?? 'a'}_{src.Index} = {src.Value}";

        /// <summary>
        /// Renders the term by default as 'a_i = Value' where i denotes the term index
        /// </summary>
        /// <param name="name">The sequence identifier, if specified</param>
        public static string format<I,T>(in SeqTerm<I,T> src, char? name = null)
            where I : unmanaged
                => src.IsEmpty ? "{}" : $"{name ?? 'a'}_{src.Index} = {src.Value}";

        [Op, Closures(Closure)]
        public static void format<T>(in Seq<T> src, char delimiter, ITextBuffer dst)
        {
            var count = src.Length;
            var terms = src.TermView;
            dst.Append(Chars.LBrace);
            for(var i=0; i<count; i++)
            {
                ref readonly var term = ref skip(terms,i);
                dst.Append(format(term));
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
                var terms = alloc<SeqTerm<T>>(count);
                var dst = span(terms);
                for(var i=0u; i<count; i++)
                    seek(dst,i) = new SeqTerm<T>(i, skip(src,i));
                return create(terms);
            }
            else
                return empty<T>();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Seq<T> create<T>(params SeqTerm<T>[] src)
            => new Seq<T>(src);
    }
}