//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = ApiOperatorClass;

    /// <summary>
    /// Defines a type-level lift for the <see cref='K.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryOpClass : IOperatorClass<BinaryOpClass,K>
    {
        public static implicit operator OperatorClass(BinaryOpClass src)
            => src.Generalized;

        public K Kind
            => K.BinaryOp;

        public OperatorClass Generalized
            => new OperatorClass(Kind);
    }

    /// <summary>
    /// Defines an operand-parametric type-level lift for the <see cref='K.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryOpClass<T> : IOperatorClass<BinaryOpClass<T>,K,T>
    {
        public K Kind
            => K.BinaryOp;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(BinaryOpClass<T> src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOpClass(BinaryOpClass<T> src)
            => src.NonGeneric;

        public OperatorClass<T> Generalized
            => new OperatorClass<T>(Kind);

        public BinaryOpClass NonGeneric
            => default;
    }
}