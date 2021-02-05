//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BinaryCellOpClass<W> : ICellOpClass<BinaryCellOpClass<W>,W,OperatorArity>
        where W : unmanaged, ITypeWidth
    {
        public OperatorArity Kind
            => OperatorArity.BinaryOp;

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
        public static implicit operator OperatorClass<W>(BinaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOperatorClass(BinaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCellFunctionClass(BinaryCellOpClass<W> src)
            => src.Untyped;
    }
}