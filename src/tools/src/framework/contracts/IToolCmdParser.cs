//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IToolCmdParser : IAppService
    {
        Outcome Parse(CmdLine src, out ToolExecSpec dst);

        Outcome Parse(ReadOnlySpan<char> src, out ArgPrefix dst);
    }
}