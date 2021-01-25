//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct UnaryOperatorClass : IOperatorClassHost<UnaryOperatorClass,OperatorArity>
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(UnaryOperatorClass src)
            => src.Classifier;

        public OperatorArity Kind
            => OperatorArity.UnaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct UnaryOperatorClass<T> : IOperatorClassHost<UnaryOperatorClass<T>, OperatorArity,T>
    {
        public OperatorArity Kind
            => OperatorArity.UnaryOp;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public UnaryOperatorClass Untyped
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(UnaryOperatorClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator UnaryOperatorClass(UnaryOperatorClass<T> src)
            => src.Untyped;
    }
}