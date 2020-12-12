//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdSpec : ITextual
    {
        ToolId ToolId
            => new ToolId("ztool");

        CmdId CmdId {get;}

        CmdName CmdName
            => CmdId;

        CmdArgs Args {get;}

        string ITextual.Format()
            => Cmd.format(this);
    }

    [Free]
    public interface ICmdSpec<T> : IEntity<T>, ICmdSpec
        where T : struct, ICmdSpec<T>
    {
        CmdId ICmdSpec.CmdId
            => Cmd.id<T>();

        CmdArgs ICmdSpec.Args
            => Cmd.args((T)this);
    }

    [Free]
    public interface ICmdSpec<C,R> : ICmdSpec<C>
        where C : struct, ICmdSpec<C,R>
    {

    }
}