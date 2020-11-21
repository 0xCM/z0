//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BinaryCellOpClass : ICellOpClass<BinaryCellOpClass,ApiOperatorClass>
    {
        public TypeWidth Width {get;}

        public ApiOperatorClass Kind
            => ApiOperatorClass.BinaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }

        [MethodImpl(Inline)]
        public BinaryCellOpClass(TypeWidth width)
            => Width = width;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(BinaryCellOpClass src)
            => src.Classifier;
    }
}