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

    public readonly struct BinaryCellClass<W> : ICellOpClass<BinaryCellClass<W>,W,ApiOperatorKind>
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

        public BinaryCellClass Untyped
        {
            [MethodImpl(Inline)]
            get => new BinaryCellClass(Width);
        }

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(BinaryCellClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryClass(BinaryCellClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCellClass(BinaryCellClass<W> src)
            => src.Untyped;
    }
}