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
        public readonly struct Production<T> : IProduction<T>
            where T : ITerm
        {
            public Label Name {get;}

            public OneOf<T> Expansion {get;}

            [MethodImpl(Inline)]
            public Production(Label name, T[] exp)
            {
                Name = name;
                Expansion = exp;
            }

             public string Format()
                => api.format(this);

             public override string ToString()
                => Format();
        }
    }
}