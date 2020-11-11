//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdSpec : IIdentified<CmdId>
    {
        CmdId CmdId {get;}

        CmdArgs Args {get;}

        CmdId IIdentified<CmdId>.Id
            => CmdId;
    }

    [Free]
    public interface ICmdSpec<T> : ICmdSpec
        where T : struct
    {
        CmdId ICmdSpec.CmdId
            => CmdId.from<T>();

        CmdArgs ICmdSpec.Args
            => CmdArgs.Empty;
    }

    [Free]
    public interface ICmdSpec<K,T> : ICmdSpec<T>
        where K : unmanaged
        where T : struct
    {
        new CmdArgs<K,T> Args {get;}

        CmdArgs ICmdSpec.Args
            => Args;
    }

    [Free]
    public interface ICmdSpec<H,K,T> : ICmdSpec<K,T>
        where H : struct, ICmdSpec<H,K,T>
        where K : unmanaged
        where T : struct
    {

    }
}