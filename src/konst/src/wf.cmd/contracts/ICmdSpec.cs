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

        CmdArgIndex Args {get;}

        CmdId IIdentified<CmdId>.Id
            => CmdId;
    }

    [Free]
    public interface ICmdSpec<T> : IEntity<T>, ICmdSpec
        where T : struct, ICmdSpec<T>
    {
        CmdId ICmdSpec.CmdId
            => Cmd.id<T>();

        CmdArgIndex ICmdSpec.Args
            => CmdArgs.index((T)this);
    }

    [Free]
    public interface ICmdSpec<C,R> : ICmdSpec<C>
        where C : struct, ICmdSpec<C,R>
    {

    }
}