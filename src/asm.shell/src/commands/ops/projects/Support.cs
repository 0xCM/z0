//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    using Z0.llvm;
    using llvm.records;

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

        Outcome LoadProjectSources(ProjectId id, Subject? scope)
        {
            if(scope != null)
                Files(Ws.Projects().SrcFiles(id, scope.Value));
            else
                Files(Ws.Projects().SrcFiles(id));
            return true;
        }

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

        Outcome RunProjectScript(CmdArgs args, ScriptId script, Subject? scope = null)
        {
            var result = Outcome.Success;
            var project = State.Project();
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

        Outcome AsmCollect()
        {
            return AsmCollect(Ws.Project(State.Project()));
        }

        Outcome AsmCollect(IProjectWs ws)
        {
            var result = Outcome.Success;
            result = Wf.LlvmObjDump().Consolidate(ws.Project);
            if(result.Fail)
                return result;

            result = CollectSyms(ws);
            if(result.Fail)
                return result;

            result = CollectObjHex(ws);
            if(result.Fail)
                return result;

            result = CollectAsmSyntax(ws);

            return result;
        }

        Outcome CollectObjHex(IProjectWs ws)
        {
            var result = Outcome.Success;
            var paths = ws.OutFiles(FileKind.Obj, FileKind.O).View;
            var count = paths.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(paths,i);
                var id = src.FileName.WithoutExtension.Format();
                var dst = ws.OutDir(objhex) + FS.file(id,FileTypes.ext(FileKind.HexDat));
                using var writer = dst.AsciWriter();
                var data = src.ReadBytes();
                var size = HexFormatter.emit(data, writer);
                Write(string.Format("({0:D5} bytes)[{1} -> {2}]", size, src.ToUri(), dst.ToUri()));
            }

            return result;
        }

        Outcome CollectSyms(IProjectWs ws)
        {
            var result = Outcome.Success;
            var src = ws.OutFiles(FS.Sym).View;
            var dst = ws.Table<ObjSymRow>(ws.Project.Format());
            Write(string.Format("Collecting symbols from {0} files", src.Length));
            var symbols = LlvmNm.Collect(src, dst);
            return result;
        }

        Outcome CollectAsmSyntax(IProjectWs ws)
        {
            var result = CollectAsmParseLogs(ws);
            result = CollectAsmSyntaxTrees(ws);
            return result;
        }

        Outcome CollectAsmParseLogs(IProjectWs ws)
        {
            var logs = ws.OutFiles(FileTypes.ext(FileKind.AsmSyntaxLog)).View;
            var dst = ws.Table<AsmSyntaxRow>(ws.Project.Format());
            var count = logs.Length;
            var buffer = list<AsmSyntaxRow>();
            for(var i=0; i<count; i++)
                ParseSyntaxLogRows(skip(logs,i), buffer);
            TableEmit(buffer.ViewDeposited(), AsmSyntaxRow.RenderWidths, dst);
            return true;
        }

        Outcome CollectAsmSyntaxTrees(IProjectWs ws)
        {
            var result = Outcome.Success;
            var src = ws.OutFiles(FileKind.AsmSyntax).View;
            var count = src.Length;
            var dst = ws.OutDir() + FS.file(ws.Name.Format() + ".syntax-trees", FS.Asm);
            using var writer = dst.AsciWriter();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                result = AsmParser.document(path, out var doc);
                if(result.Fail)
                    break;

                var lines = doc.SourceLines;
                writer.WriteLine(string.Format("# Source: {0}", path.ToUri()));
                for(var j=0; j<lines.Length; j++)
                {
                    ref readonly var line = ref skip(lines,j);
                    writer.WriteLine(line);
                }
            }

            return result;
        }

        uint ParseSyntaxLogRows(FS.FilePath src, List<AsmSyntaxRow> dst)
        {
            const string EntryMarker = "note: parsed instruction:";
            var lines = src.ReadNumberedLines();
            var count = lines.Length;
            var counter = 0u;
            for(var i=0; i<count-1; i++)
            {
                ref readonly var a = ref skip(lines, i).Content;
                ref readonly var b = ref skip(lines, i+1).Content;

                var m = text.index(a,EntryMarker);
                if(!a.Contains(EntryMarker))
                    continue;

                Fence<char> Brackets = (Chars.LBracket, Chars.RBracket);
                var locator = text.left(a,m).Trim();
                locator = text.slice(locator,0, locator.Length - 1);

                var syntax = text.right(a, m + EntryMarker.Length);
                var semfound = text.unfence(syntax, Brackets, out var semantic);
                syntax = semfound ? RP.parenthetical(semantic) : syntax;
                var body = b.Replace(Chars.Tab, Chars.Space);
                var record = new AsmSyntaxRow();
                counter++;
                FS.point(locator, out var point);
                record.Location = point.Location;
                record.Expr = asm.expr(body);
                record.Syntax = syntax;
                record.Source = point.Path;
                dst.Add(record);
            }
            return counter;
        }
   }
}