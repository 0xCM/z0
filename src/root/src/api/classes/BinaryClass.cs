//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a type-level lift for the <see cref='ApiOperatorKind.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryClass : IOperatorClassHost<BinaryClass,ApiOperatorKind>
    {
        public static implicit operator OperatorClass(BinaryClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.BinaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    /// <summary>
    /// Defines an operand-parametric type-level lift for the <see cref='ApiOperatorKind.BinaryOp'/> classifier
    /// </summary>
    public readonly struct BinaryClass<T> : IOperatorClassHost<BinaryClass<T>,ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.BinaryOp;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(BinaryClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator BinaryClass(BinaryClass<T> src)
            => src.Untyped;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public BinaryClass Untyped
            => default;
    }
}