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

        public BinaryCellFunctionClass Untyped
        {
            [MethodImpl(Inline)]
            get => new BinaryCellFunctionClass(Width);
        }

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(BinaryCellClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOperatorClass(BinaryCellClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCellFunctionClass(BinaryCellClass<W> src)
            => src.Untyped;
    }
}