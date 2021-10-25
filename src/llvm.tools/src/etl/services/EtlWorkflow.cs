//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Collections.Generic;

    using Asm;
    using static EtlNames;

    using static core;

    public partial class EtlWorkflow : AppService<EtlWorkflow>
    {
        LlvmPaths LlvmPaths;

        OmniScript OmniScript;

        llvm.LlvmNm Nm;

        llvm.LlvmObjDump ObjDump;

        HashSet<string> ClassExclusions {get;}
            = hashset<string>("Hexagon", "Neon", "PowerPC", "RISCV", "SystemZ", "Hexagom", "AMDGPU");

        public EtlWorkflow()
        {
        }

        protected override void Initialized()
        {
            LlvmPaths = Wf.LlvmPaths();
            OmniScript = Wf.OmniScript();
            Nm = Wf.LlvmNm();
            ObjDump = Wf.LlvmObjDump();
        }

        void IndexLists(ref EtlDatasets ds)
        {
            var index = dict<Identifier,uint>();
            var count = ds.Lists.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var list = ref skip(ds.Lists,i);
                index[list.ListName] = i;
            }
            ds.ListIndex = index;
        }

        public Outcome RunEtl()
        {
            var dst = new EtlDatasets();
            var records = LoadSourceRecords(Datasets.X86);
            dst.Records = records;
            ImportRecordLines(records, Datasets.X86Lined);
            var lists = ImportLists();
            dst.Lists = lists;
            var classes = ImportClassRelations(records);
            dst.ClassRelations = classes;
            var defs = ImportDefRelations(records);
            dst.DefRelations = defs;
            var defMap = EmitLineMap(defs, records, Datasets.X86Defs);
            dst.DefMap = defMap;
            var defFields = LoadFields(records, defMap);
            dst.Defs = defFields;
            EmitFields(defFields, Datasets.X86DefFields);
            var classMap = EmitLineMap(classes, records, Datasets.X86Classes);
            dst.ClassMap = classMap;
            var classFields = LoadFields(records, classMap);
            dst.Classes = classFields;
            EmitFields(classFields, Datasets.X86ClassMembers);
            IndexLists(ref dst);

            ProjectCollect();

            GenCode(dst);
            //GenDocs(dst);

            return true;
        }

        void GenCode(in EtlDatasets src)
        {
            Wf.LlvmEtlCodeGen().Run(src);
        }

        void GenDocs(in EtlDatasets src)
        {
            var dst = LlvmPaths.ImportDir("docs") + FS.folder("instructions");
            dst.Clear();
            var running = Running(string.Format("Emitting instruction docs to {0}", dst));
            var docgen = EtlDocGen.create(Wf,src);
            var count = docgen.GenInsructionDocs(dst);
            Ran(running, string.Format("Emitted docs for {0} instructions", count));
        }

        public void ProjectCollect()
        {
            iter(Projects.ProjectNames, name => ProjectCollect(Ws.Project(name)));
            // ProjectCollect(Ws.Project(Projects.LlvmModels));
            // ProjectCollect(Ws.Project(Projects.ClangModels));
            // ProjectCollect(Ws.Project(Projects.McModels));
            // ProjectCollect(Ws.Project(Projects.Canonical));
        }

        Outcome ProjectCollect(IProjectWs ws)
        {
            var result = Outcome.Success;
            result = ObjDump.Consolidate(ws.Project);
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
                var dst = ws.OutDir(WsAtoms.objhex) + FS.file(id,FileTypes.ext(FileKind.HexDat));
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
            var dst = ws.Table<ObjSymRecord>(ws.Project.Format());
            Write(string.Format("Collecting symbols from {0} files", src.Length));
            var symbols = Nm.Collect(src, dst);
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