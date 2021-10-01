//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Automata
    {
        public readonly struct State<S>
            where S : unmanaged
        {
            public S Value {get;}

            [MethodImpl(Inline)]
            public State(S src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator State<S>(S src)
                => new State<S>(src);
        }
    }
}