//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ToolCmd<T> : IToolCmd<T>
        where T : struct, IToolCmd<T>
    {
        public ToolId ToolId
            => ToolCmd.toolid<T>();

        public CmdId CmdId
            => ToolCmd.cmdid<T>();
    }
}