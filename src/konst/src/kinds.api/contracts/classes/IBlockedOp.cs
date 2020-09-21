//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBlockedOp : ILiteralKind<BlockedKind>
    {
        TypeWidth BlockWidth => default;
    }

    public interface IBlockedOp<B> : IBlockedOp, ILiteralKind<B,BlockedKind>
        where B : struct, IBlockedOp<B>
    {

    }

    public interface IBlockedOp<W,T> : IBlockedOp, ILiteralType<BlockedKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        BlockedKind ITypedLiteral<BlockedKind>.Class
            => BlockedKinds.kind<W,T>();

        TypeWidth IBlockedOp.BlockWidth
            => default(W).TypeWidth;
    }

    public interface IBlockedOp<B,W,T> : IBlockedOp<W,T>, IBlockedOp<B>
        where B : struct, IBlockedOp<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}