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
        /// <summary>
        /// Defines a compile-time literal value
        /// </summary>
        public readonly struct Constant<T> : ITerm
        {
            public T Value {get;}

            [MethodImpl(Inline)]
            public Constant(T value)
            {
                Value = value;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Constant<T>(T src)
                => new Constant<T>(src);
        }
    }
}