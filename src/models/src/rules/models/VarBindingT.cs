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
        /// <summary>
        /// Binds a variable to a value
        /// </summary>
        public readonly struct VarBinding<T> : IBinding<T>
            where T : ITerm<T>
        {
            public readonly Var Var;

            public T Term {get;}

            [MethodImpl(Inline)]
            public VarBinding(Var var, T val)
            {
                Var = var;
                Term = val;
            }

            public Label Name
            {
                [MethodImpl(Inline)]
                get => Var.Name;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator VarBinding<T>((Var var, T val) src)
                => new VarBinding<T>(src.var,src.val);

            [MethodImpl(Inline)]
            public static implicit operator VarBinding<T>((Var<T> var, T val) src)
                => new VarBinding<T>(src.var,src.val);
        }
    }
}