//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        /// <summary>
        /// Defines a <see cref='Consequent{T}'/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="term"></param>
        /// <typeparam name="C"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Consequent<C> consequence<C>(TermId id, C term)
            => new Consequent<C>(id, term);
    }
}