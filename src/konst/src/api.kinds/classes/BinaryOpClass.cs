//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a type-level lift for the <see cref='ApiOperatorClass.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryOpClass : IOperatorClassHost<BinaryOpClass,ApiOperatorClass>
    {
        public static implicit operator OperatorClass(BinaryOpClass src)
            => src.Classifier;

        public ApiOperatorClass Kind
            => ApiOperatorClass.BinaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }    }

    /// <summary>
    /// Defines an operand-parametric type-level lift for the <see cref='ApiOperatorClass.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryOpClass<T> : IOperatorClassHost<BinaryOpClass<T>,ApiOperatorClass,T>
    {
        public ApiOperatorClass Kind
            => ApiOperatorClass.BinaryOp;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(BinaryOpClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOpClass(BinaryOpClass<T> src)
            => src.Untyped;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public BinaryOpClass Untyped
            => default;
    }
}