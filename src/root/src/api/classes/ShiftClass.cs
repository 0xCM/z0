//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ShiftClass : IOperatorClassHost<ShiftClass,ApiOperatorKind>
    {
        public static implicit operator OperatorClass(ShiftClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.ShiftOp;

        public OperatorClass Classifier
            => new OperatorClass(Kind);
    }

    public readonly struct ShiftClass<T> : IOperatorClassHost<ShiftClass<T>,ApiOperatorKind,T>
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(ShiftClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator ShiftClass(ShiftClass<T> src)
            => src.NonGeneric;

        public ApiOperatorKind Kind
            => ApiOperatorKind.ShiftOp;

        public OperatorClass<T> Classifier
            => new OperatorClass<T>(Kind);

        public ShiftClass NonGeneric
            => default;
    }
}