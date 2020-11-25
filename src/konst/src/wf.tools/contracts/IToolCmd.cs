//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolCmd : ICmdSpec
    {
        CmdHostId ToolId {get;}
    }

    [Free]
    public interface IToolCmd<T> : IToolCmd, ICmdSpec<T>
        where T : struct, IToolCmd<T>
    {
        CmdHostId IToolCmd.ToolId
            => Tooling.toolid<T>();

        CmdId IIdentified<CmdId>.Id
            => Cmd.id<T>();
    }
}