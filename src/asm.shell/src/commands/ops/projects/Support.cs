//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        Outcome LoadProjectSources(ProjectId id)
        {
            var outcome = Outcome.Success;
            var dir = Ws.Project(id).Home();
            outcome = dir.Exists;
            if(outcome)
                Files(ProjectWs.SrcFiles(id));
            else
                outcome = (false, UndefinedProject.Format(id));
            return outcome;
        }

        Outcome LoadProjectSources(ProjectId id, Subject? scope)
        {
            Files(ProjectFiles(id,scope));
            return true;
        }

        FS.Files ProjectFiles(ProjectId id, Subject? scope)
        {
            if(scope != null)
                return Ws.Project(id).SrcFiles(scope.Value.Format());
            else
                return Ws.Project(id).SrcFiles();
        }

        Outcome HexDecode(string srcid)
            => OmniScript.RunProjectScript(AsmRoot, srcid, McDisasm, false, out var flows);

        Outcome HexDecode()
        {
            var result = Outcome.Success;
            result = LoadProjectSources("asm", "hex");
            if(result.Fail)
                return result;

            var src = State.Files(FS.Hex).View;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                result = OmniScript.RunProjectScript(AsmRoot, skip(src,i).FileName.WithoutExtension.Format(), McDisasm, false, out var flows);
                if(result.Fail)
                return result;
            }

            return result;
        }

        Outcome RunProjectScript(CmdArgs args, ScriptId script, Subject? scope = null)
            => RunProjectScript(State.Project(), args, script, scope);

        Outcome RunProjectScript(ProjectId project, CmdArgs args, ScriptId script, Subject? scope = null)
        {
            var result = Outcome.Success;
            if(args.Count != 0)
            {
                result = OmniScript.RunProjectScript(project, arg(args,0).Value, script, false, out _);
                return result;
            }

            result = LoadProjectSources(project, scope);
            if(result.Fail)
                return result;

            var src = State.Files().View;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                RunProjectScript(project,path,script);
            }

            return result;
        }

        Outcome RunProjectScript(ProjectId project, FS.FilePath path, ScriptId script)
        {
            var srcid = path.FileName.WithoutExtension.Format();
            OmniScript.RunProjectScript(project, srcid, script, true, out var flows);
            for(var j=0; j<flows.Length; j++)
            {
                ref readonly var flow = ref skip(flows, j);
                Write(flow.Format());
            }
            return true;
        }

        Outcome RunProjectScript(ProjectId project, ScriptId script)
        {
            OmniScript.RunProjectScript(project, script, true, out var flows);
            for(var j=0; j<flows.Length; j++)
            {
                ref readonly var flow = ref skip(flows, j);
                Write(flow.Format());
            }
            return true;
        }
   }
}