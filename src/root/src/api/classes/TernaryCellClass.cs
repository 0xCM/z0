//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct OperationClasses
    {
        public readonly struct TernaryCellClass : ICellClass<TernaryCellClass,ApiOperatorKind>
        {
            public TypeWidth Width {get;}

            public ApiOperatorKind Kind
                => ApiOperatorKind.TernaryOp;

            public OperatorClass Classifier
            {
                [MethodImpl(Inline)]
                get => new OperatorClass(Kind);
            }

            [MethodImpl(Inline)]
            public TernaryCellClass(TypeWidth width)
                => Width = width;

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(TernaryCellClass src)
                => new OperatorClass(src.Kind);
        }
    }
}