//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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
}