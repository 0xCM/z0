//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface TBlockedKind<W,T> : IBlockedKind, ILiteralType<BlockedKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        BlockedKind ITypedLiteral<BlockedKind>.Class 
            => BlockedKinds.kind<W,T>();

        TypeWidth BlockWidth 
            => default(W).TypeWidth;        
    }

    public interface TBlockedKind<B,W,T> : TBlockedKind<W,T>, IBlockedKind<B>
        where B : struct, TBlockedKind<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}