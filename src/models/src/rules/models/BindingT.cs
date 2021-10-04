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
        public readonly struct Binding<T> : ITerm<T>
        {
            public readonly Var Var;

            public T Value {get;}

            [MethodImpl(Inline)]
            public Binding(Var var, T val)
            {
                Var = var;
                Value = val;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Binding<T>((Var var, T val) src)
                => new Binding<T>(src.var,src.val);

            [MethodImpl(Inline)]
            public static implicit operator Binding<T>((Var<T> var, T val) src)
                => new Binding<T>(src.var,src.val);
        }
    }
}