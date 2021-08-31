//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using Z0.llvm;

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

        Outcome RunBuildScript(CmdArgs args, ScriptId script)
        {
            var result = Outcome.Success;
            var project = State.Project();
            if(args.Count != 0)
                return OmniScript.RunProjectScript(project, arg(args,0).Value, script, false, out _);

            result = LoadProjectSources(project);
            if(result.Fail)
                return result;

            var src = State.Files().View;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var srcid = path.FileName.WithoutExtension.Format();
                OmniScript.RunProjectScript(project, srcid, script, true, out var flows);
                for(var j=0; j<flows.Length; j++)
                {
                    ref readonly var flow = ref skip(flows, j);
                    Write(flow.Format());
                }
            }

            return result;
        }

        Outcome CollectSyms()
        {
            var result = Outcome.Success;
            var src = ProjectOut().Files(FS.Sym,true);
            var dst = Ws.Projects().TableOut<ObjSymRecord>(State.Project());
            Write(string.Format("Collecting symbols from {0} files", src.Length));
            var symbols = LlvmNm.Collect(src, dst);
            return result;
        }

        Outcome CollectObjAsm()
        {
            var project = State.Project();
            var src = Ws.Projects().OutFiles(project, FileTypes.ObjAsm).View;
            var dst = Ws.Projects().DataOut(project) + Tables.filename<ObjDumpRow>();
            var result = Outcome.Success;
            var tool = Wf.LlvmObjDump();
            var count = src.Length;
            var formatter = Tables.formatter<ObjDumpRow>(ObjDumpRow.RenderWidths);
            var flow = EmittingTable<ObjDumpRow>(dst);
            var counter = 0u;
            using var writer = dst.AsciWriter();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                result = tool.ParseDump(path, out var rows);
                if(result.Fail)
                {
                    Error(result.Message);
                    continue;
                }

                for(var j=0; j<rows.Length; j++)
                {
                    ref readonly var row = ref skip(rows,j);
                    if(row.IsBlockStart)
                        continue;

                    writer.WriteLine(formatter.Format(row));
                    counter++;
                }
            }
            EmittedTable(flow,counter);
            return result;
        }
    }
}