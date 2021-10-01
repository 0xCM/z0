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
        public readonly struct States<S>
            where S : unmanaged
        {
            readonly Index<State<S>> Data;

            [MethodImpl(Inline)]
            public States(State<S>[] src)
            {
                Data = src;
            }

            public static implicit operator States<S>(State<S>[] src)
                => new States<S>(src);
        }
    }
}