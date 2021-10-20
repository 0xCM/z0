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

    partial struct lang
    {
        /// <summary>
        /// Defines an aplphabet predicated on an existing symbol set
        /// </summary>
        /// <param name="name"></param>
        /// <param name="src"></param>
        /// <typeparam name="K"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Alphabet<K> alphabet<K>(Label name, Symbol<K>[] src)
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
            var dst = alloc<Symbol<K>>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                seek(dst,i) = symbol(s.Key.Value, s.Kind);
            }
            return new Alphabet<K>(typeof(K).Name, dst);
        }

        public static Alphabet<A> alphabet<A>(Label name)
            where A : unmanaged, Enum
        {
            var syms = Symbols.index<A>();
            var view = syms.View;
            var count = syms.Count;
            var dst = alloc<Symbol<A>>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(view,i);
                seek(dst,i) = symbol(s.Key.Value, s.Kind);
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
            var dst = alloc<Symbol<K>>(count);
            for(var i=0u; i<count; i++)
                seek(dst,i) = symbol(i, skip(src,i));
            return new Alphabet<K>(name, dst);
        }
    }
}