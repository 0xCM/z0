//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolCmd : ITextual
    {
        CmdId CmdId {get;}

        Name CmdName
            => CmdId;

        ToolCmdArgs Args {get;}

        string ITextual.Format()
            => Cmd.format(this);
    }

    [Free]
    public interface IToolCmd<C> : IToolCmd
        where C : struct, IToolCmd<C>
    {
        CmdId IToolCmd.CmdId
            => CmdId.from<C>();

        ToolCmdArgs IToolCmd.Args
            => ToolArgs.args((C)this);

    }

    [Free]
    public interface IToolCmd<C,T> : IToolCmd<C>
        where C : struct, IToolCmd<C>
        where T : struct, ITool<T>
    {

    }
}