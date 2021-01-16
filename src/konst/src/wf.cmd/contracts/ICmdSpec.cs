//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdSpec : ITextual //: IDataType
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
    public interface ICmdSpec<T> : ICmdSpec//, IDataType<T>
        where T : struct, ICmdSpec<T>
    {
        CmdId ICmdSpec.CmdId
            => Cmd.id<T>();

        CmdArgs ICmdSpec.Args
            => Cmd.args((T)this);

        string ITextual.Format()
            => Cmd.format(this);
    }

    [Free]
    public interface ICmdSpec<C,R> : ICmdSpec<C>
        where C : struct, ICmdSpec<C,R>
    {

    }
}