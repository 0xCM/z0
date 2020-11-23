//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TernaryCellOpClass<W> : ICellOpClass<TernaryCellOpClass<W>,W,ApiOperatorKind>
        where W : unmanaged, ITypeWidth
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.TernaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<W>(Kind);
        }

        public TernaryCellOpClass Untyped
        {
            [MethodImpl(Inline)]
            get => new TernaryCellOpClass(Width);
        }

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(TernaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator TernaryOpClass(TernaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator TernaryCellOpClass(TernaryCellOpClass<W> src)
            => src.Untyped;
    }
}