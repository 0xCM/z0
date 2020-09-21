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

    public readonly struct CellularUnaryOpClass : ICellularOpClass<CellularUnaryOpClass,C>
    {
        public TypeWidth Width {get;}

        public C Kind
            => C.UnaryOp;

        public OperatorClass Generalized
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(CellularUnaryOpClass src)
            => default;

        [MethodImpl(Inline)]
        public CellularUnaryOpClass(TypeWidth width)
            => Width = width;
    }

    public readonly struct CellularUnaryOpClass<W> : ICellularOpClass<CellularUnaryOpClass<W>,W,C>
        where W : unmanaged, ITypeWidth
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(CellularUnaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator K.UnaryOpClass(CellularUnaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator CellularUnaryOpClass(CellularUnaryOpClass<W> src)
            => src.NonGeneric;

        public C Kind
            => C.UnaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Generalized
            => default;

        public CellularUnaryOpClass NonGeneric
            => new CellularUnaryOpClass(Width);
    }
}