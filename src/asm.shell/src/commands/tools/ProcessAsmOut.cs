//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static Root;

    using static AsmTools;
    using static AsmTools.AsmToolKind;
    using static WsAtoms;

    partial class AsmCmdService
    {
        FS.FileName ObjDumpFile(string srcid)
            => FS.file(string.Format("{0}.{1}", srcid, obj), FS.Asm);
        FS.FilePath ObjDumpPath(string srcid)
            => AsmWs.DumpOut() + ObjDumpFile(srcid);

        FS.Files AsmOutFiles()
            => AsmWs.OutDir().Files(true);

        FS.Files AsmOutFiles(string srcid)
        {
            var pattern = string.Format("{0}*.*", srcid);
            return AsmWs.OutDir().Files(pattern,true);
        }

        void ProcessAsmOut(string srcid)
        {
            var paths = AsmOutFiles(srcid).View;
            var count = paths.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                var name = path.FileName;
            }
        }

        void ProcessObjDump(string srcid)
        {
            var path = ObjDumpPath(srcid);
            if(path.Exists)
            {
                Write(RP.attrib("ObjDumpPath", path.ToUri()));
            }
        }

        void ParseObjDump(FS.FilePath src)
        {
            const string SectionMarker = "Disassembly of section ";
            using var reader = src.Utf8LineReader();
            var section = EmptyString;
            var i=-1;
            while(reader.Next(out var line))
            {
                var content = line.Content.Trim();
                if(empty(content))
                    continue;

                i = text.index(content,SectionMarker);
                if(i >=0)
                {
                    section = text.left(content, i+SectionMarker.Length);
                    Write(RP.attrib("section",section));
                }
            }
        }
    }
}