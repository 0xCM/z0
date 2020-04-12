//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IBlockedKind : ILiteralKind<BlockedKind>, ITypeKind
    {

    }

    public interface IBlockedKind<B> : IBlockedKind, ILiteralKind<B,BlockedKind>
        where B : struct, IBlockedKind<B>
    {

    }

    public interface IBlockedKind<W,T> : IBlockedKind, ILiteralType<BlockedKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        BlockedKind ITypedLiteral<BlockedKind>.Class => BlockedTypeKinds.kind<W,T>();

        TypeWidth BlockWidth => default(W).TypeWidth;        
    }

    public interface IBlockedKind<B,W,T> : IBlockedKind<W,T>, IBlockedKind<B>
        where B : struct, IBlockedKind<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}