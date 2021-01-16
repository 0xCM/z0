//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TernaryOpClass : IOperatorClassHost<TernaryOpClass,ApiOperatorKind>
    {
        public static implicit operator OperatorClass(TernaryOpClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.TernaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct TernaryOpClass<T> : IOperatorClassHost<TernaryOpClass<T>,ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.TernaryOp;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public TernaryOpClass Untyped
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(TernaryOpClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator TernaryOpClass(TernaryOpClass<T> src)
            => src.Untyped;
    }
}