//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IKeyedTable<F,T,K>
        where F : unmanaged
        where T : struct
        where K : unmanaged
    {
        K Key {get;}
    }
}