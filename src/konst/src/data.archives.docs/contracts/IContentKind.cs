//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public interface IContentKind<H,K>
        where H : struct, IContentKind<H,K>
        where K : unmanaged
    {
        K Kind {get;}
    }

    public interface IContentKind<H,K,I> : IContentKind<H,K>, IIdentified<I>, ITextual
        where H : struct, IContentKind<H,K,I>
        where K : unmanaged
    {

    }

}