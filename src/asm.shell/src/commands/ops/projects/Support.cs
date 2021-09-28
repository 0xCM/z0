//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    using Z0.llvm;

    using static core;
    using static Root;
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

        Outcome LoadProjectSources(ProjectId id, Scope? scope)
        {
            if(scope != null)
                Files(Ws.Projects().SrcFiles(id, scope.Value));
            else
                Files(Ws.Projects().SrcFiles(id));
            return true;
        }

        FS.Files ProjectSources(Scope? scope = null)
            => scope != null ? Ws.Projects().SrcFiles(State.Project(), scope.Value) : Ws.Projects().SrcFiles(State.Project());

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

        Outcome RunProjectScript(CmdArgs args, ScriptId script, Scope? scope = null)
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
            result = Wf.LlvmObjDump().Consolidate(State.Project());
            if(result.Fail)
                return result;

            result = CollectSyms();
            if(result.Fail)
                return result;

            result = CollectObjHex();
            if(result.Fail)
                return result;

            result = CollectAsmSyntax();

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

        Outcome CollectAsmSyntax()
        {
            var result = CollectAsmParseLogs();
            result = CollectAsmSyntaxTrees();
            return result;
        }

        Outcome CollectAsmParseLogs()
        {
            var project = State.Project();
            var logs = Ws.Projects().OutFiles(project, FileTypes.ext(FileKind.AsmSyntaxLog)).View;
            var dst = Ws.Projects().TableOut<AsmSyntaxRow>(project);
            var count = logs.Length;
            var buffer = list<AsmSyntaxRow>();
            for(var i=0; i<count; i++)
                ParseSyntaxLogRows(skip(logs,i), buffer);
            TableEmit(buffer.ViewDeposited(), AsmSyntaxRow.RenderWidths, dst);
            return true;
        }

        Outcome CollectAsmSyntaxTrees()
        {
            var result = Outcome.Success;
            var project = Ws.Project(State.Project());
            var src = project.OutFiles(FileKind.AsmSyntax).View;
            var count = src.Length;
            var dst = project.OutDir() + FS.file(project.Name.Format(), FileKind.AsmSyntax.Ext());
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
                ref readonly var a = ref skip(lines,i).Content;
                ref readonly var b = ref skip(lines,i+1).Content;

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

        FS.FilePath OutPath(Scope scope, string id, FileKind kind)
            =>  Ws.Projects().Out(State.Project(), scope) + FS.file(id,FileTypes.ext(kind));

        FS.Files OutFiles(params FileKind[] kinds)
            => Ws.Projects().OutFiles(State.Project(), kinds);
   }
}