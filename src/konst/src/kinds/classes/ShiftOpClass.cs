//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = ApiOperatorClass;

    public readonly struct ShiftOpClass : IOperatorClass<ShiftOpClass,K>
    {
        public static implicit operator OperatorClass(ShiftOpClass src)
            => src.Generalized;

        public K Kind
            => K.ShiftOp;

        public OperatorClass Generalized
            => new OperatorClass(Kind);
    }
}