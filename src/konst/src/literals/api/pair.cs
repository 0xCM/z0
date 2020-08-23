//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial struct Literals
    {
        /// <summary>
        /// Defines an homogenous pair of key-correlated literals
        /// </summary>
        /// <param name="key">The correlation key</param>
        /// <param name="first">The fist member</param>
        /// <param name="second">The second member</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="P">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralPair<K,P> pair<K,P>(K key, P first, P second)
            => new LiteralPair<K,P>(key, first, second);

        /// <summary>
        /// Defines a heterogenous pair of key-correlated literals
        /// </summary>
        /// <param name="key">The correlation key</param>
        /// <param name="first">The fist literal</param>
        /// <param name="second">The second literal</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="P">The first literal type</typeparam>
        /// <typeparam name="Q">The second literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralPair<K,P,Q> pair<K,P,Q>(K key, P first, Q second)
            => new LiteralPair<K,P,Q>(key, first, second);

        /// <summary>
        ///  Defines, but does not verify, a correlation between enum literals
        /// </summary>
        /// <param name="name">The correlation axis</param>
        /// <param name="first">The first literal</param>
        /// <param name="second">THe second literal</param>
        /// <typeparam name="E1">The first enum type</typeparam>
        /// <typeparam name="E2">The second enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumPair<E1,E2> pair<E1,E2>(string name, E1 first, E2 second)
            where E1: unmanaged, Enum
            where E2: unmanaged, Enum
                => new EnumPair<E1,E2>(name, first, second);        

        /// <summary>
        /// Correlates literal values predicated on identifier equality
        /// </summary>
        /// <typeparam name="E1">The first enum type</typeparam>
        /// <typeparam name="E2">The second enum type</typeparam>
        public static IDictionary<string, EnumPair<E1,E2>> pairs<E1,E2>()
            where E1: unmanaged, Enum
            where E2: unmanaged, Enum
        {
            var first = Enums.index<E1>().NamedValues.ToDictionary();
            var second = Enums.index<E2>().NamedValues.ToDictionary();
            var names = first.Keys.Union(second.Keys).ToHashSet();
            var correlated = new Dictionary<string,EnumPair<E1,E2>>(names.Count);
            foreach(var name in names)
            {   
                if(first.TryGetValue(name, out var e1) && second.TryGetValue(name, out var e2))
                    correlated[name] = Literals.pair(name, e1, e2);
            }
            return correlated;
        }
    }
}