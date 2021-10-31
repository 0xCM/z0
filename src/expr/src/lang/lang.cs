//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly partial struct lang
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Atom<K> atom<K>(uint key, K value)
            where K : unmanaged
                => new Atom<K>(key, value);

        [Op, Closures(Closure)]
        public static AtomicSeq<K> concat<K>(AtomicSeq<K> a, AtomicSeq<K> b)
            where K : unmanaged
        {
            var ka = a.Count;
            var kb = b.Count;
            var k=0u;
            var length = a.Count + b.Count;
            var dst = alloc<K>(length);
            for(var i=0; i<ka; i++)
                seek(dst,k++) = a[i];
            for(var i=0; i<kb; i++)
                seek(dst,k++) = b[i];
            return default;
        }

        [MethodImpl(Inline), Op]
        public static Atom atom(char value)
            => new Atom(value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Token<S> token<S>(uint key, params Atom<S>[] src)
            where S : unmanaged
                => new Token<S>(key, src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Token token(uint key, params Atom[] src)
            => new Token(key, src);

        /// <summary>
        /// Defines an aplphabet predicated on an existing symbol set
        /// </summary>
        /// <param name="name"></param>
        /// <param name="src"></param>
        /// <typeparam name="K"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Alphabet<K> alphabet<K>(Label name, Atom<K>[] src)
            where K : unmanaged
                => new Alphabet<K>(name, src);

        /// <summary>
        /// Derives an alphabet from a parametrically-specified enum type
        /// </summary>
        /// <typeparam name="K">A concrete enum type</typeparam>
        public static Alphabet<K> alphabet<K>()
            where K : unmanaged, Enum
        {
            var src = Symbols.index<K>().View;
            var count = src.Length;
            var dst = alloc<Atom<K>>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                seek(dst,i) = atom(s.Key.Value, s.Kind);
            }
            return new Alphabet<K>(typeof(K).Name, dst);
        }

        public static Alphabet<A> alphabet<A>(Label name)
            where A : unmanaged, Enum
        {
            var syms = Symbols.index<A>();
            var view = syms.View;
            var count = syms.Count;
            var dst = alloc<Atom<A>>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(view,i);
                seek(dst,i) = atom(s.Key.Value, s.Kind);
            }
            return new Alphabet<A>(name, dst);
        }

        /// <summary>
        /// Defines an alphabet predicated on a specified sequence of values
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="K">The item type</typeparam>
        public static Alphabet<K> alphabet<K>(Label name, ReadOnlySpan<K> src)
            where K : unmanaged
        {
            var count = src.Length;
            var dst = alloc<Atom<K>>(count);
            for(var i=0u; i<count; i++)
                seek(dst,i) = atom(i, skip(src,i));
            return new Alphabet<K>(name, dst);
        }

        [MethodImpl(Inline), Op]
        public static Production<T> production<T>(Label name, T term)
            where T : IExpr
                => new Production<T>(name, term);

    }
}