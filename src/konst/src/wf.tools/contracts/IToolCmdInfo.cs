//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolCmdInfo<I,T>
        where I : struct, IToolCmdInfo<I,T>
        where T : struct, IToolCmd<T>
    {
        ToolId ToolId {get;}

        CmdName CmdName
            => Cmd.name<T>();
    }
}