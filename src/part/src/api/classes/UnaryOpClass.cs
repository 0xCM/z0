//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct UnaryOpClass : IOperatorClassHost<UnaryOpClass,ApiOperatorKind>
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(UnaryOpClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.UnaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct UnaryOpClass<T> : IOperatorClassHost<UnaryOpClass<T>, ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.UnaryOp;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public UnaryOpClass Untyped
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(UnaryOpClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator UnaryOpClass(UnaryOpClass<T> src)
            => src.Untyped;
    }
}