//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an operand value of dynamic type
    /// </summary>
    public readonly struct Operand
    {
        public dynamic Value {get;}

        [MethodImpl(Inline)]
        public Operand(dynamic value)
            => Value = value;
    }

    /// <summary>
    /// Defines an operand value of parametric type
    /// </summary>
    public readonly struct Operand<A>
    {
        public A Value {get;}

        [MethodImpl(Inline)]
        public Operand(A value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator Operand(Operand<A> src)
            => new Operand(src.Value);
    }
}