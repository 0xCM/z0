//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Var<T>
        where T : ITerm<T>
    {
        public readonly Label Name;

        [MethodImpl(Inline)]
        public Var(Label name)
        {
            Name = name;
        }

        [MethodImpl(Inline)]
        public VarBinding<T> Bind(T val)
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