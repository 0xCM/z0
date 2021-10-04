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
        public readonly struct Var<T>
        {
            public readonly Label Name;

            [MethodImpl(Inline)]
            public Var(Label name)
            {
                Name = name;
            }

            [MethodImpl(Inline)]
            public Binding<T> Bind(T val)
                =>(this,val);

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Var(Var<T> src)
                => new Var(src.Name);
        }
    }
}