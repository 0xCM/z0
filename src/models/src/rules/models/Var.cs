//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        public readonly struct Var
        {
            public readonly Label Name;

            [MethodImpl(Inline)]
            public Var(Label name)
            {
                Name = name;
            }

            public Binding<T> Bind<T>(T val)
                =>(this,val);

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}