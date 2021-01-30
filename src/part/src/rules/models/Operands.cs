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
    /// Defines an operand sequence
    /// </summary>
    public readonly struct Operands
    {
        public Index<Operand> Values {get;}

        [MethodImpl(Inline)]
        public Operands(params Operand[] values)
            => Values = values;

        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)Values.Count;
        }
    }

    /// <summary>
    /// Defines a sequence of 2 operands of parametric type
    /// </summary>
    public readonly struct Operands<A,B>
    {
        public Operand<A> A0 {get;}

        public Operand<B> A1 {get;}

        [MethodImpl(Inline)]
        public Operands(Operand<A> a0, Operand<B> a1)
        {
            A0 = a0;
            A1 = a1;
        }

        public byte Count => 2;

        [MethodImpl(Inline)]
        public static implicit operator Operands(Operands<A,B> src)
            => new Operands(src.A0, src.A1);
    }

    /// <summary>
    /// Defines a sequence of 3 operands of parametric type
    /// </summary>
    public readonly struct Operands<A,B,C>
    {
        public Operand<A> A0 {get;}

        public Operand<B> A1 {get;}

        public Operand<C> A2 {get;}

        [MethodImpl(Inline)]
        public Operands(Operand<A> a0, Operand<B> a1, Operand<C> a2)
        {
            A0 = a0;
            A1 = a1;
            A2 = a2;
        }

        public byte Count => 3;

        [MethodImpl(Inline)]
        public static implicit operator Operands(Operands<A,B,C> src)
            => new Operands(src.A0, src.A1, src.A2);
    }

        /// <summary>
    /// Defines a sequence of 3 operands of parametric type
    /// </summary>
    public readonly struct Operands<A,B,C,D>
    {
         public Operand<A> A0 {get;}

        public Operand<B> A1 {get;}

        public Operand<C> A2 {get;}

        public Operand<D> A3 {get;}

        public byte Count => 4;

        [MethodImpl(Inline)]
        public Operands(Operand<A> a0, Operand<B> a1, Operand<C> a2, Operand<D> a3)
        {
            A0 = a0;
            A1 = a1;
            A2 = a2;
            A3 = a3;
        }

        [MethodImpl(Inline)]
        public static implicit operator Operands(Operands<A,B,C,D> src)
            => new Operands(src.A0, src.A1, src.A2, src.A3);
    }
}