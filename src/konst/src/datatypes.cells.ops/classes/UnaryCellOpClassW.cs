//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UnaryCellOpClass<W> : ICellOpClass<UnaryCellOpClass<W>,W,ApiOperatorKind>
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

        public UnaryCellOpClass Untyped
        {
            [MethodImpl(Inline)]
            get => new UnaryCellOpClass(Width);
        }

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(UnaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator UnaryOpClass(UnaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator UnaryCellOpClass(UnaryCellOpClass<W> src)
            => src.Untyped;
    }
}