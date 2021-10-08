//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Var
    {
        public readonly Label Name;

        [MethodImpl(Inline)]
        public Var(Label name)
        {
            Name = name;
        }

        public VarBinding<T> Bind<T>(T val)
            where T : ITerm<T>
                =>(this,val);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}