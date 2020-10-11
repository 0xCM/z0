//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using C = ApiOperatorClass;

    public readonly struct BinaryCellOpClass : ICellOp<BinaryCellOpClass,C>
    {
        public TypeWidth Width {get;}

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(BinaryCellOpClass src)
            => src.Generalized;

        public C Kind
            => C.BinaryOp;

        public OperatorClass Generalized
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }


        [MethodImpl(Inline)]
        public BinaryCellOpClass(TypeWidth width)
        {
            Width = width;
        }
    }

    public readonly struct BinaryCellOpClass<W> : ICellOp<BinaryCellOpClass<W>,W,C>
        where W : unmanaged, ITypeWidth
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(BinaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOpClass(BinaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCellOpClass(BinaryCellOpClass<W> src)
            => src.NonGeneric;

        public C Kind
            => C.BinaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Generalized
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<W>(Kind);
        }

        public BinaryCellOpClass NonGeneric
        {
            [MethodImpl(Inline)]
            get => new BinaryCellOpClass(Width);
        }
    }
}