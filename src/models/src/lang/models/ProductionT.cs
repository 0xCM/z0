//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    using api = Grammars;

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