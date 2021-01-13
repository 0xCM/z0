//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    using S = System;

    partial class Surrogates
    {
        public readonly struct Action<A0> : IAction<A0>
        {
            readonly S.Action<A0> F;

            public string Name {get;}

            [MethodImpl(Inline)]
            internal Action(string name, S.Action<A0> f)
            {
                Name = name;
                F = f;
            }

            [MethodImpl(Inline)]
            public void Invoke(A0 a)
                => F(a);

            public S.Action<A0> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Name;

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator System.Action<A0>(Action<A0> src)
                => src.F;
        }
    }
}