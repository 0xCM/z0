//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDag : ITextual
    {
        uint StorageSize {get;}
    }

    [Free]
    public interface IDag<H> : IDag
        where H : unmanaged, IDag<H>
    {

    }

    [Free]
    public interface IDag<H,O> : IDag<H>
        where O : unmanaged
        where H : unmanaged,IDag<H,O>
    {

    }
}