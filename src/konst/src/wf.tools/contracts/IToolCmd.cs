//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolCmd<C> : ICmdExecSpec, ICmd<C>
        where C : struct, IToolCmd<C>
    {
        ToolId ICmdExecSpec.ToolId
            => Cmd.toolid<C>();
    }

    [Free]
    public interface IToolCmd<C,T> : IToolCmd<C>, ICmd<C>
        where C : struct, IToolCmd<C>
        where T : struct, ITool<T>
    {
        ToolId ICmdExecSpec.ToolId
            => Cmd.toolid<C>();
    }
}