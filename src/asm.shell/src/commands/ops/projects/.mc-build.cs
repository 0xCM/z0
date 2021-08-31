//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".mc-build")]
        Outcome BuildMc(CmdArgs args)
        {
            var result = Outcome.Success;
            var project = State.Project();
            if(args.Count != 0)
                result = OmniScript.RunProjectScript(project, arg(args,0).Value, McBuild, false, out _);
            else
            {
                result = LoadProjectSources(project);
                if(result.Fail)
                    return result;

                var src = State.Files().View;
                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    ref readonly var path = ref skip(src,i);
                    var srcid = path.FileName.WithoutExtension.Format();
                    OmniScript.RunProjectScript(project, srcid, McBuild, true, out var flows);
                    for(var j=0; j<flows.Length; j++)
                    {
                        ref readonly var flow = ref skip(flows, j);

                        Write(flow.Format());
                    }
                }
            }

            return result;
        }


    }
}