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
    /// Defines a type-level lift for the <see cref='ApiOperatorKind.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryOpClass : IOperatorClassHost<BinaryOpClass,ApiOperatorKind>
    {
        public static implicit operator OperatorClass(BinaryOpClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.BinaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }    }

    /// <summary>
    /// Defines an operand-parametric type-level lift for the <see cref='ApiOperatorKind.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryOpClass<T> : IOperatorClassHost<BinaryOpClass<T>,ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.BinaryOp;

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