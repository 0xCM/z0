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
        public readonly struct UnaryCellClass : ICellClass<UnaryCellClass,ApiOperatorKind>
        {
            public TypeWidth Width {get;}

            public ApiOperatorKind Kind
                => ApiOperatorKind.UnaryOp;

            public OperatorClass Untyped
            {
                [MethodImpl(Inline)]
                get => new OperatorClass(Kind);
            }

            [MethodImpl(Inline)]
            public UnaryCellClass(TypeWidth width)
                => Width = width;

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(UnaryCellClass src)
                => default;
        }
    }
}