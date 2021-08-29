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
        Outcome RunExe(ReadOnlySpan<ToolFlow> flows)
        {
            if(ToolFlows.target(flows,FS.Exe, out var flow))
            {
                ref readonly var target = ref flow.Target;
                Write(string.Format("Executing {0}", flow.Target.ToUri()));
                var result = OmniScript.Run(target, CmdVars.Empty, true, out var response);
                if(result.Fail)
                    return result;

                for(var j=0; j<response.Length; j++)
                    Write(skip(response, j).Content);
                return true;
            }
            else
                return false;
        }
    }
}