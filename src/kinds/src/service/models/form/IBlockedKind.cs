//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBlockedKind : ILiteralKind<BlockedKind>
    {

    }

    public interface IBlockedKind<B> : IBlockedKind, ILiteralKind<B,BlockedKind>
        where B : struct, IBlockedKind<B>
    {

    }
}