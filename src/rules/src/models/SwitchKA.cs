//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public class Switch<K,A>
        {
            readonly Index<K> _Choices;

            public Identifier Name {get;}

            public Func<K,A> Actor {get;}

            public Switch(Identifier name, K[] src, Func<K,A> actor)
            {
                Name = name;
                _Choices = src;
                Actor = actor;
            }

            public ReadOnlySpan<K> Choices
            {
                [MethodImpl(Inline)]
                get => _Choices.Edit;
            }
        }
    }
}