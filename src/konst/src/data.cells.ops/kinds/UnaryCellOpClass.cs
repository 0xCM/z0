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

    public readonly struct UnaryCellOpClass : ICellOp<UnaryCellOpClass,C>
    {
        public TypeWidth Width {get;}

        public C Kind
            => C.UnaryOp;

        public OperatorClass Generalized
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(UnaryCellOpClass src)
            => default;

        [MethodImpl(Inline)]
        public UnaryCellOpClass(TypeWidth width)
            => Width = width;
    }

    public readonly struct UnaryCellOpClass<W> : ICellOp<UnaryCellOpClass<W>,W,C>
        where W : unmanaged, ITypeWidth
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(UnaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator K.UnaryOpClass(UnaryCellOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator UnaryCellOpClass(UnaryCellOpClass<W> src)
            => src.NonGeneric;

        public C Kind
            => C.UnaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Generalized
            => default;

        public UnaryCellOpClass NonGeneric
            => new UnaryCellOpClass(Width);
    }
}