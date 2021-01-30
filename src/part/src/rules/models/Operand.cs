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
        public Name Name {get;}

        public dynamic Value {get;}

        [MethodImpl(Inline)]
        public Operand(Name name, dynamic value)
        {
            Name = name;
            Value = value;
        }
    }

    /// <summary>
    /// Defines an operand value of parametric type
    /// </summary>
    public readonly struct Operand<T>
    {
        public Name Name {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public Operand(Name name, T value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Operand(Operand<T> src)
            => new Operand(src.Name, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Operand<T>(Paired<Name,T> src)
            => new Operand<T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Operand<T>(Paired<string,T> src)
            => new Operand<T>(src.Left, src.Right);
    }
}