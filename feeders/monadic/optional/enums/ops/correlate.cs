//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;

    using static Monadic;

    partial class Enums
    {
        /// <summary>
        /// Correlates literal values predicated on identifier equality
        /// </summary>
        /// <typeparam name="E1">The first enum type</typeparam>
        /// <typeparam name="E2">The second enum type</typeparam>
        public static IDictionary<string, LiteralCorrelation<E1,E2>> correlate<E1,E2>()
            where E1: unmanaged, Enum
            where E2: unmanaged, Enum
        {
            var first = Enums.literals<E1>().NamedValues.ToDictionary();
            var second = Enums.literals<E2>().NamedValues.ToDictionary();
            var names = first.Keys.Union(second.Keys).ToHashSet();
            var correlated = new Dictionary<string,LiteralCorrelation<E1,E2>>(names.Count);
            foreach(var name in names)
            {   
                if(first.TryGetValue(name, out var e1) && second.TryGetValue(name, out var e2))
                    correlated[name] = Define(name, e1, e2);
            }
            return correlated;
        }

        /// <summary>
        ///  Defines, but does not verify, a correlation between enum literals
        /// </summary>
        /// <param name="name">The correlation axis</param>
        /// <param name="first">The first literal</param>
        /// <param name="second">THe second literal</param>
        /// <typeparam name="E1">The first enum type</typeparam>
        /// <typeparam name="E2">The second enum type</typeparam>
        [MethodImpl(Inline)]
        static LiteralCorrelation<E1,E2> Define<E1,E2>(string name, E1 first, E2 second)
            where E1: unmanaged, Enum
            where E2: unmanaged, Enum
                => new LiteralCorrelation<E1,E2>(name,first,second);
    }
}