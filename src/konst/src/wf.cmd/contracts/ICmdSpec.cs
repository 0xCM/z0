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
        ToolId ToolId
            => new ToolId("ztool");

        CmdId CmdId {get;}

        CmdName CmdName
            => CmdId;

        CmdArgIndex Args {get;}
    }

    [Free]
    public interface ICmdSpec<T> : IEntity<T>, ICmdSpec
        where T : struct, ICmdSpec<T>
    {
        CmdId ICmdSpec.CmdId
            => Cmd.id<T>();

        CmdArgIndex ICmdSpec.Args
            => Cmd.index((T)this);
    }

    [Free]
    public interface ICmdSpec<C,R> : ICmdSpec<C>
        where C : struct, ICmdSpec<C,R>
    {

    }
}