//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Blit.Operate;

    partial struct Blit
    {
        public readonly struct PrimalIndicator
        {
            public name64 Name {get;}

            [MethodImpl(Inline)]
            public PrimalIndicator(name64 name)
            {
                Name = name;
            }

            public string Format()
                => api.format(Name);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator PrimalIndicator(name64 name)
                => new PrimalIndicator(name);
        }
    }
}