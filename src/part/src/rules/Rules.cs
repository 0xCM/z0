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
    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bijection<T> bijection<T>(T[] src, T[] dst)
            => new Bijection<T>(src, dst);

        [MethodImpl(Inline)]
        public static Bijection<S,T> bijection<S,T>(S[] src, T[] dst)
            => new Bijection<S,T>(src, dst);

        [MethodImpl(Inline)]
        public static Implication<I,A,C> implies<I,A,C>(I index, A @if, C then)
            where I : unmanaged, IEquatable<I>
            where A : IEquatable<A>
            where C : IEquatable<C>
                => new Implication<I,A,C>(index, @if, then);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Antecedant<A> antecedant<A>(TermId id, Index<A> terms)
            where A : IEquatable<A>
                => new Antecedant<A>(id, terms);

        [Op, Closures(Closure)]
        public static string format<A>(Antecedant<A> src)
            where A : IEquatable<A>
                => string.Format("({0}):{1}", src.Terms.Delimit(Chars.Amp),  typeof(A).Name);

        public static string format<C>(Consequent<C> src)
            where C : IEquatable<C>
                => string.Format("{0}:{1}", src.Term,  typeof(C).Name);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Consequent<C> consequence<C>(TermId id, C term)
            where C : IEquatable<C>
                => new Consequent<C>(id, term);

        [MethodImpl(Inline)]
        public static Proposition<A,C> proposition<A,C>(TermId id,Antecedant<A> @if, Consequent<C> then)
            where A : IEquatable<A>
            where C : IEquatable<C>
                => new Proposition<A,C>(id, @if,then);

        [MethodImpl(Inline)]
        public static Rule<A,C> rule<A,C>(TermId id, Proposition<A,C>[] terms)
            where A : IEquatable<A>
            where C : IEquatable<C>
                => new Rule<A,C>(id,terms);

        [MethodImpl(Inline)]
        public static bool equals<A>(Antecedant<A> src, Antecedant<A> dst)
            where A : IEquatable<A>
                => Index.equals(src.Terms.View, dst.Terms.View);

        [MethodImpl(Inline)]
        public static bool equals<C>(Consequent<C> src, Consequent<C> dst)
            where C : IEquatable<C>
                => src.Term.Equals(dst.Term);

        [MethodImpl(Inline)]
        public static bool equals<A,C>(Proposition<A,C> src, Proposition<A,C> dst)
            where A : IEquatable<A>
            where C : IEquatable<C>
                => equals(src.Antecedant, dst.Antecedant)
                && equals(src.Consequence, dst.Consequence);

        /// <summary>
        /// Defines a scalar range expression
        /// </summary>
        /// <param name="min">The minimum scalar in the range</param>
        /// <param name="max">The maximum scalar in the range</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RangeSpec<T> range<T>(T min, T max, T step)
            where T : unmanaged, IEquatable<T>
                => new RangeSpec<T>(min, max, step);

        [MethodImpl(Inline)]
        public static Replacement<T> replace<T>(T src, T dst)
            where T : IEquatable<T>
            => new Replacement<T>(src,dst);

        public static Replacements<T> replace<T>(T[] src, T dst)
            where T : IEquatable<T>
        {
            var count = src.Length;
            var buffer = sys.alloc<Replacement<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), dst);
            return buffer;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void apply<T>(Replacement<T> rule, ReadOnlySpan<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged, IEquatable<T>
        {
            var count = src.Length;
            var input = span(src);
            fixed(T* c = src)
                for(var i=offset; i<count; i++)
                    seek(dst,i) = (*c).Equals(rule.Match) ? rule.Replace : skip(input,i);
        }

        [Op, Closures(Closure)]
        public static Replacements<T> replace<T>(Bijection<T> spec)
            where T : IEquatable<T>
        {
            var src = spec.Source.View;
            var dst = spec.Target.View;
            root.require(src.Length == dst.Length, () => "Same lengths there must me");
            var count = src.Length;
            var buffer = sys.alloc<Replacement<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            ref readonly var output = ref first(dst);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), skip(output,i));
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Replacements<T> replace<T>(T[] src, T[] dst)
            where T : IEquatable<T>
                => replace(Rules.bijection<T>(src,dst));
    }
}