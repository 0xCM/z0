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
        public Index<dynamic> Values {get;}

        [MethodImpl(Inline)]
        public Operands(params dynamic[] values)
            => Values = values;

        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)Values.Count;
        }
    }

    /// <summary>
    /// Defines an homogenous operand sequence of parametric type
    /// </summary>
    public readonly struct Operands<T>
    {
        public Index<T> Values {get;}

        [MethodImpl(Inline)]
        public Operands(Index<T> values)
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
        public A A0 {get;}

        public B A1 {get;}

        [MethodImpl(Inline)]
        public Operands(A a0, B a1)
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
        public A A0 {get;}

        public B A1 {get;}

        public C A2 {get;}

        [MethodImpl(Inline)]
        public Operands(A a0, B a1, C a2)
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
        public A A0 {get;}

        public B A1 {get;}

        public C A2 {get;}

        public D A3 {get;}

        public byte Count => 4;

        [MethodImpl(Inline)]
        public Operands(A a0, B a1, C a2, D a3)
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