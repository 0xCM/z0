//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        /// <summary>
        /// A rule is, by definition, a named term
        /// </summary>
        public readonly struct Rule<T>
            where T : ITerm<T>
        {
            public readonly Label Name;

            public readonly T Term;

            [MethodImpl(Inline)]
            public Rule(Label name, T term)
            {
                Name = name;
                Term = term;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Rule<T>((Label name, T term) src)
                => new Rule<T>(src.name, src.term);

        }
    }
}