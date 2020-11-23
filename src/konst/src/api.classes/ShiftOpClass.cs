//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct ShiftOpClass : IOperatorClassHost<ShiftOpClass,ApiOperatorKind>
    {
        public static implicit operator OperatorClass(ShiftOpClass src)
            => src.Classifier;

        public ApiOperatorKind Kind
            => ApiOperatorKind.ShiftOp;

        public OperatorClass Classifier
            => new OperatorClass(Kind);
    }
}