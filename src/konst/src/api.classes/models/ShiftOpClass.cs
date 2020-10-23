//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ShiftOpClass : IOperatorClassHost<ShiftOpClass,ApiOperatorClass>
    {
        public static implicit operator OperatorClass(ShiftOpClass src)
            => src.Classifier;

        public ApiOperatorClass Kind
            => ApiOperatorClass.ShiftOp;

        public OperatorClass Classifier
            => new OperatorClass(Kind);
    }
}