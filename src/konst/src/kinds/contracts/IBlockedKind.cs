//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBlockedKind : ILiteralKind<BlockedKind>
    {
        TypeWidth BlockWidth => default;
    }

    public interface IBlockedKind<B> : IBlockedKind, ILiteralKind<B,BlockedKind>
        where B : struct, IBlockedKind<B>
    {

    }

    public interface IBlockedKind<W,T> : IBlockedKind, ILiteralType<BlockedKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        BlockedKind ITypedLiteral<BlockedKind>.Class
            => BlockedKinds.kind<W,T>();

        TypeWidth IBlockedKind.BlockWidth
            => default(W).TypeWidth;
    }

    public interface IBlockedKind<B,W,T> : IBlockedKind<W,T>, IBlockedKind<B>
        where B : struct, IBlockedKind<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}