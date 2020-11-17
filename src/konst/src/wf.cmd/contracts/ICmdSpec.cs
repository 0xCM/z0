//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using api = Cmd;

    [Free]
    public interface ICmdSpec : IIdentified<CmdId>
    {
        CmdId CmdId {get;}

        CmdArgs Args {get;}

        CmdId IIdentified<CmdId>.Id
            => CmdId;
    }

    [Free]
    public interface ICmdSpec<T> : IEntity<T>, ICmdSpec
        where T : struct, ICmdSpec<T>
    {
        CmdId ICmdSpec.CmdId
            => api.id<T>();

        CmdArgs ICmdSpec.Args
            => api.args((T)this);
    }

    [Free]
    public interface ICmdSpec<K,T> : ICmdSpec<T>
        where K : unmanaged
        where T : struct, ICmdSpec<T>
    {
        new CmdArgs<K,T> Args {get;}

        CmdArgs ICmdSpec.Args
            => Args;
    }

    [Free]
    public interface ICmdSpec<H,K,T> : ICmdSpec<K,T>
        where H : struct, ICmdSpec<H,K,T>
        where K : unmanaged
        where T : struct, ICmdSpec<T>
    {

    }
}