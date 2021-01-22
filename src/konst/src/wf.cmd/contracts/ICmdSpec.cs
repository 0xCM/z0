//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmd : ITextual
    {
        ToolId ToolId
            => new ToolId("ztool");

        CmdId CmdId {get;}

        Name CmdName
            => CmdId;

        CmdArgs Args {get;}

        string ITextual.Format()
            => Cmd.format(this);
    }

    [Free]
    public interface ICmd<T> : ICmd
        where T : struct, ICmd<T>
    {
        CmdId ICmd.CmdId
            => Cmd.id<T>();

        CmdArgs ICmd.Args
            => Cmd.args((T)this);

        string ITextual.Format()
            => Cmd.format(this);
    }

    [Free]
    public interface ICmdSpec<C,R> : ICmd<C>
        where C : struct, ICmdSpec<C,R>
    {

    }
}