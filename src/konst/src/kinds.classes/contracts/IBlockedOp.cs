//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBlockedOp : ILiteralKind<SegBlockKind>
    {
        TypeWidth BlockWidth => default;
    }

    [Free]
    public interface IBlockedOp<B> : IBlockedOp, ILiteralKind<B,SegBlockKind>
        where B : struct, IBlockedOp<B>
    {

    }

    [Free]
    public interface IBlockedOp<W,T> : IBlockedOp, ILiteralType<SegBlockKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        SegBlockKind ITypedLiteral<SegBlockKind>.Class
            => BlockedKinds.kind<W,T>();

        TypeWidth IBlockedOp.BlockWidth
            => default(W).TypeWidth;
    }

    [Free]
    public interface IBlockedOp<B,W,T> : IBlockedOp<W,T>, IBlockedOp<B>
        where B : struct, IBlockedOp<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}