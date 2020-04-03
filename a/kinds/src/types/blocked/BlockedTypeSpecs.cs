//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IBlockedType : ILiteralKind<BlockedKind>, ITypeKind
    {

    }

    public interface IBlockedType<B> : IBlockedType, ILiteralKind<B,BlockedKind>
        where B : struct, IBlockedType<B>
    {

    }

    public interface IBlockedType<W,T> : IBlockedType, ILiteralType<BlockedKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        BlockedKind ITypedLiteral<BlockedKind>.Class => BlockedType.kind<W,T>();

        TypeWidth BlockWidth => default(W).TypeWidth;        
    }

    public interface IBlockedType<B,W,T> : IBlockedType<W,T>, IBlockedType<B>
        where B : struct, IBlockedType<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}