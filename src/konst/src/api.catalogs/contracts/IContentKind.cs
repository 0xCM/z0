//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IContentKind<H,K>
        where H : struct, IContentKind<H,K>
        where K : unmanaged
    {
        K Kind {get;}

        string KindId {get;}
    }

    [Free]
    public interface IKindedContent<H,K,T> : IContentKind<H,K>, ITextual, IContented<T>
        where H : struct, IKindedContent<H,K,T>
        where K : unmanaged
    {

    }
}