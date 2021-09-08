//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using Z0.llvm;

    using static core;
    using static WsAtoms;
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
            {
                result = OmniScript.RunProjectScript(project, arg(args,0).Value, script, false, out _);
                return result;
            }

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

        Outcome AsmCollect()
        {
            var result = Outcome.Success;
            result = CollectObjAsm();
            if(result.Fail)
                return result;

            result = CollectSyms();
            if(result.Fail)
                return result;

            result = CollectObjHex();
            if(result.Fail)
                return result;

            return result;
        }

        Outcome CollectObjHex()
        {
            var result = Outcome.Success;
            var paths = OutFiles(FileKind.Obj, FileKind.O).View;
            var count = paths.Length;
            var hex = HexLines.Service();
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(paths,i);
                var id = src.FileName.WithoutExtension.Format();
                var dst = OutPath(objhex, id, FileKind.HexDat);
                using var writer = dst.AsciWriter();
                var data = src.ReadBytes();
                var size = hex.Emit(data, writer);
                Write(string.Format("({0:D5} bytes)[{1} -> {2}]", size, src.ToUri(), dst.ToUri()));
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

        FS.FilePath OutPath(Scope scope, string id, FileKind kind)
            =>  Ws.Projects().Out(State.Project(), scope) + FS.file(id,FileTypes.ext(kind));

        FS.Files OutFiles()
            => Ws.Projects().OutFiles(State.Project());

        FS.Files OutFiles(FileKind kind)
            => Ws.Projects().OutFiles(State.Project(), kind);

        FS.Files OutFiles(params FileKind[] kinds)
            => Ws.Projects().OutFiles(State.Project(), kinds);

        Outcome CollectObjAsm()
        {
            var project = State.Project();
            var src = OutFiles(FileKind.ObjAsm).View;
            var dst = Ws.Projects().TableOut<ObjDumpRow>(project);
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