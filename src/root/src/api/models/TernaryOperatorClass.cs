//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TernaryOperatorClass : IOperatorClassHost<TernaryOperatorClass,OperatorArity>
    {
        public static implicit operator OperatorClass(TernaryOperatorClass src)
            => src.Classifier;

        public OperatorArity Kind
            => OperatorArity.TernaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct TernaryOperatorClass<T> : IOperatorClassHost<TernaryOperatorClass<T>,OperatorArity,T>
    {
        public OperatorArity Kind
            => OperatorArity.TernaryOp;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public TernaryOperatorClass Untyped
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(TernaryOperatorClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator TernaryOperatorClass(TernaryOperatorClass<T> src)
            => src.Untyped;
    }
}