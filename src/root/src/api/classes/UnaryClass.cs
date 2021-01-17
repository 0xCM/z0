//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct UnaryClass : IOperatorClassHost<UnaryClass,ApiOperatorKind>
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(UnaryClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.UnaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct UnaryClass<T> : IOperatorClassHost<UnaryClass<T>, ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.UnaryOp;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public UnaryClass Untyped
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(UnaryClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator UnaryClass(UnaryClass<T> src)
            => src.Untyped;
    }
}