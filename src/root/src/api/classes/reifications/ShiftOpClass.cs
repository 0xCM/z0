//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ShiftOpClass : IOperatorClassHost<ShiftOpClass,ApiOperatorKind>
    {
        public static implicit operator OperatorClass(ShiftOpClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.ShiftOp;

        public OperatorClass Classifier
            => new OperatorClass(Kind);
    }

    public readonly struct ShiftOpClass<T> : IOperatorClassHost<ShiftOpClass<T>,ApiOperatorKind,T>
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(ShiftOpClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator ShiftOpClass(ShiftOpClass<T> src)
            => src.NonGeneric;

        public ApiOperatorKind Kind
            => ApiOperatorKind.ShiftOp;

        public OperatorClass<T> Classifier
            => new OperatorClass<T>(Kind);

        public ShiftOpClass NonGeneric
            => default;
    }
}