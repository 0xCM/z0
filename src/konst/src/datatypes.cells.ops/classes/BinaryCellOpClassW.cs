//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BinaryCellOpClass<W> : ICellOpClass<BinaryCellOpClass<W>,W,ApiOperatorKind>
        where W : unmanaged, ITypeWidth
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.BinaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<W>(Kind);
        }

        public BinaryCellOpClass Untyped
        {
            [MethodImpl(Inline)]
            get => new BinaryCellOpClass(Width);
        }

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(BinaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOpClass(BinaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCellOpClass(BinaryCellOpClass<W> src)
            => src.Untyped;
    }
}