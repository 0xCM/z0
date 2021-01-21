//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISegmentedKind : ILiteralKind<SegKind>
    {
        TypeWidth BlockWidth => default;
    }

    [Free]
    public interface ISegmentedKind<B> : ISegmentedKind, ILiteralKind<B,SegKind>
        where B : struct, ISegmentedKind<B>
    {

    }

    [Free]
    public interface ISegmentedKind<W,T> : ISegmentedKind, ILiteralType<SegKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        SegKind ITypedLiteral<SegKind>.Class
            => SegmentedKinds.kind<W,T>();

        TypeWidth ISegmentedKind.BlockWidth
            => default(W).TypeWidth;
    }

    [Free]
    public interface ISegmetedKind<B,W,T> : ISegmentedKind<W,T>, ISegmentedKind<B>
        where B : struct, ISegmetedKind<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}