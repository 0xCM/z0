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
        ToolId ToolId {get;}
    }

    [Free]
    public interface IToolCmd<T> : IToolCmd, ICmdSpec<T>
        where T : struct, IToolCmd<T>
    {
        ToolId IToolCmd.ToolId
            => Cmd.toolid<T>();

        CmdId ICmdSpec.CmdId
            => Cmd.id<T>();
    }

    [Free]
    public interface IToolCmd<K,C> : IToolCmd<C>, ICmdSpec<K,C>
        where C : struct, IToolCmd<K,C>
        where K : unmanaged
    {

    }
}