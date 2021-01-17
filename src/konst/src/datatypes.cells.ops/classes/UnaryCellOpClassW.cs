//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static OperationClasses;

    public readonly struct UnaryCellClass<W> : ICellOpClass<UnaryCellClass<W>,W,ApiOperatorKind>
        where W : unmanaged, ITypeWidth
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.UnaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<W>(Kind);
        }

        public UnaryCellClass Untyped
        {
            [MethodImpl(Inline)]
            get => new UnaryCellClass(Width);
        }

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(UnaryCellClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator UnaryClass(UnaryCellClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator UnaryCellClass(UnaryCellClass<W> src)
            => src.Untyped;
    }
}