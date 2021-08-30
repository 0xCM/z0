//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static ProjectScriptNames;

    partial class AsmCmdService
    {
        Outcome LoadProjectSources(ProjectId id)
        {
            var outcome = Outcome.Success;
            var dir = ProjectHome(id);
            outcome = dir.Exists;
            if(outcome)
                Files(ProjectWs.SrcFiles(id));
            else
                outcome = (false, UndefinedProject.Format(id));
            return outcome;
        }

        Outcome LoadProjectSources(ProjectId id, Scope scope)
        {
            Files(Ws.Projects().SrcFiles(id,scope));
            return true;
        }

        FS.FilePath Script(ProjectId project, ScriptId script)
            => Ws.Projects().Script(project, script, FS.Cmd);

        FS.FolderPath ProjectOut()
            => Ws.Projects().Out(State.Project());

        FS.FolderPath OutData()
            => ProjectOut() + FS.folder("data");

        FS.FilePath OutData<T>()
            where T : struct
                => OutData() + Tables.filename<T>();

        FS.FilePath OutData(FS.FileName file)
            => OutData() + file;

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
    }
}