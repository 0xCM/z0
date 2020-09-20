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

    public readonly struct CellularBinaryOpClass : ICellularOpClass<CellularBinaryOpClass,C>
    {
        public TypeWidth Width {get;}

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(CellularBinaryOpClass src)
            => src.Generalized;

        public C Kind
            => C.BinaryOp;

        public OperatorClass Generalized
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }


        [MethodImpl(Inline)]
        public CellularBinaryOpClass(TypeWidth width)
        {
            Width = width;
        }
    }

    public readonly struct CellularBinaryOpClass<W> : ICellularOpClass<CellularBinaryOpClass<W>,W,C>
        where W : unmanaged, ITypeWidth
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(CellularBinaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOpClass(CellularBinaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator CellularBinaryOpClass(CellularBinaryOpClass<W> src)
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

        public CellularBinaryOpClass NonGeneric
        {
            [MethodImpl(Inline)]
            get => new CellularBinaryOpClass(Width);
        }
    }
}