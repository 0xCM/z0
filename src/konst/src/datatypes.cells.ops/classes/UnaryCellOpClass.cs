//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct UnaryCellOpClass : ICellOpClass<UnaryCellOpClass,ApiOperatorKind>
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
        public UnaryCellOpClass(TypeWidth width)
            => Width = width;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(UnaryCellOpClass src)
            => default;
    }
}