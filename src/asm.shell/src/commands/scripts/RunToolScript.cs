//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        Outcome RunToolScript(FS.FilePath src, CmdVars vars, bool quiet, out ReadOnlySpan<ToolFlow> flows)
        {
            flows = default;

            var result = Outcome.Success;
            if(!src.Exists)
                return (false, FS.missing(src));
            result = Run(src, vars, quiet, out var response);
            if(result.Fail)
                return result;

            flows = Tooling.flow(response);
            var count = flows.Length;
            for(var i=0; i<count; i++)
                Write(skip(flows,i));

            return result;
        }
    }
}