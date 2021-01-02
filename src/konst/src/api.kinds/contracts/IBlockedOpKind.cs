//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBlockedOpKind : ILiteralKind<SegBlockKind>
    {
        TypeWidth BlockWidth => default;
    }

    [Free]
    public interface IBlockedOpKind<B> : IBlockedOpKind, ILiteralKind<B,SegBlockKind>
        where B : struct, IBlockedOpKind<B>
    {

    }

    [Free]
    public interface IBlockedOpKind<W,T> : IBlockedOpKind, ILiteralType<SegBlockKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        SegBlockKind ITypedLiteral<SegBlockKind>.Class
            => BlockedKinds.kind<W,T>();

        TypeWidth IBlockedOpKind.BlockWidth
            => default(W).TypeWidth;
    }

    [Free]
    public interface IBlockedOpKind<B,W,T> : IBlockedOpKind<W,T>, IBlockedOpKind<B>
        where B : struct, IBlockedOpKind<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}