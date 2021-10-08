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
        public class Switch<K,T>
            where K : unmanaged
            where T : ITerm<T>
        {
            readonly Index<Constant<K>> _Choices;

            readonly Index<T> _Terms;

            public Label Name {get;}

            public Switch(Label name, Constant<K>[] src, T[] terms)
            {
                Name = name;
                _Choices = src;
                _Terms = terms;
                Require.equal(src.Length, terms.Length);
            }

            public ReadOnlySpan<Constant<K>> Choices
            {
                [MethodImpl(Inline)]
                get => _Choices.Edit;
            }

            public ReadOnlySpan<T> Terms
            {
                [MethodImpl(Inline)]
                get => _Terms.View;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}