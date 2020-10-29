//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdSpec
    {
        CmdId Id {get;}

        utf8 Content {get;}
    }

    [Free]
    public interface ICmdSpec<T> : ICmdSpec
        where T : struct
    {
        CmdId ICmdSpec.Id
            => CmdId.from<T>();

        utf8 ICmdSpec.Content
            => utf8.Empty;
    }

    [Free]
    public interface ICmdSpec<K,T> : ICmdSpec<T>
        where K : unmanaged
        where T : struct

    {

    }

    [Free]
    public interface ICmdSpec<H,K,T> : ICmdSpec<K,T>
        where K : unmanaged
        where H : struct, ICmdSpec<H,K,T>
        where T : struct
    {

    }
}