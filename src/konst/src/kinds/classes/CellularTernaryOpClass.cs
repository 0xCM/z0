//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using C = OperatorClassKind;
    using K = Kinds;

    public readonly struct CellularTernaryOpClass : ICellularOpClass<CellularTernaryOpClass,C>
    {
        public TypeWidth Width {get;}

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(CellularTernaryOpClass src)
            => new OperatorClass(src.Kind);

        public C Kind
            => C.TernaryOp;

        public OperatorClass Generalized
            => default;

        [MethodImpl(Inline)]
        public CellularTernaryOpClass(TypeWidth width)
            => Width = width;
    }

    public readonly struct CellularTernaryOpClass<W> : ICellularOpClass<CellularTernaryOpClass<W>,W,C>
        where W : unmanaged, ITypeWidth
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(CellularTernaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator K.TernaryOpClass(CellularTernaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator CellularTernaryOpClass(CellularTernaryOpClass<W> src)
            => src.NonGeneric;

        public C Kind
            => C.TernaryOp;

        public TypeWidth Width
            => Widths.type<W>();

        public OperatorClass<W> Generalized
            => default;

        public CellularTernaryOpClass NonGeneric
            => new CellularTernaryOpClass(Width);
    }
}