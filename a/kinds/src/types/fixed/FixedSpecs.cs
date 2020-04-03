//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IFixedType : ILiteralKind<FixedKind>, ITypeKind
    {

    }

    public interface IFixedType<W> : IFixedType, ILiteralKind<FixedKind>
        where W : unmanaged, ITypeWidth
    {
        FixedKind ITypedLiteral<FixedKind>.Class => FixedType.kind<W>();

        TypeWidth Width => Widths.literal<W>();
    }

    public interface IFixedType<F,W> : IFixedType<W>, ILiteralKind<F,FixedKind>
        where F : struct, IFixedType<F,W>
        where W : unmanaged, ITypeWidth
    {

    }
}