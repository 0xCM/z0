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
    using K = Kinds;

    public readonly struct TernaryCellOpClass : ICellOp<TernaryCellOpClass,C>
    {
        public TypeWidth Width {get;}

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(TernaryCellOpClass src)
            => new OperatorClass(src.Kind);

        public C Kind
            => C.TernaryOp;

        public OperatorClass Generalized
            => default;

        [MethodImpl(Inline)]
        public TernaryCellOpClass(TypeWidth width)
            => Width = width;
    }

    public readonly struct TernaryCellOpClass<W> : ICellOp<TernaryCellOpClass<W>,W,C>
        where W : unmanaged, ITypeWidth
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(TernaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator K.TernaryOpClass(TernaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator TernaryCellOpClass(TernaryCellOpClass<W> src)
            => src.NonGeneric;

        public C Kind
            => C.TernaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Generalized
            => default;

        public TernaryCellOpClass NonGeneric
            => new TernaryCellOpClass(Width);
    }
}