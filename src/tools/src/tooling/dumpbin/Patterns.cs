//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static DumpBin.Flag;

    public partial struct DumpBin
    {
        const string Space = " ";

        const PathSeparator PS = PathSeparator.BS;

        public static FS.FileExt ext(Flag f)
            => Z0.FS.ext(f.ToString().ToLower());

        public FS.FileExt OutputExt(CmdId id)
        {
            switch(id)
            {
                case CmdId.EmitAsm:
                    return ext(DISASM) + ext(NOBYTES) + FS.Asm;
                case CmdId.EmitRawData:
                    return ext(RAWDATA) + FS.Log;
                case CmdId.EmitHeaders:
                    return ext(HEADERS) + FS.Log;
                case CmdId.EmitRelocations:
                    return ext(RELOCATIONS) + FS.Log;
                case CmdId.EmitExports:
                    return ext(EXPORTS) + FS.Log;
                case CmdId.EmitLoadConfig:
                    return ext(LOADCONFIG) + FS.Log;
            }

            return FS.Log;
        }

        public static CmdScript script(DumpBin tool, string name, CmdId id, FileModule[] src, FS.FolderPath outdir)
            => ToolCmd.script(name, src.Map(file => tool.Command(id, file.Path, outdir)));

        public CmdScript Script(string name, CmdId id, FileModule[] src, FS.FolderPath outdir)
            => script(this, name, id, src, outdir);

        public ScriptExpr Command(CmdId id, FS.FilePath src, FS.FolderPath outdir)
        {
            var subdir = outdir + FS.folder(src.FileName.WithoutExtension.Name);
            subdir.Create();
            var x = OutputExt(id);
            var output = subdir + src.FileName.ChangeExtension(x);
            var source = src.Format(PS);
            var target = output.Format(PS);
            var pattern = ScriptPattern.Empty;
            switch(id)
            {
                case CmdId.EmitAsm:
                    pattern = ToolCmd.pattern("dumpbin.disasm", string.Format("dumpbin /DISASM:{2} /OUT:{1} {0}", source, target, "NOBYTES"));
                    break;
                case CmdId.EmitRawData:
                    pattern = ToolCmd.pattern("dumpbin.rawdata", string.Format("dumpbin /RAWDATA:1,32 /OUT:{1} {0}", source, target));
                    break;
                case CmdId.EmitHeaders:
                    pattern = ToolCmd.pattern("dumpbin.headers", string.Format("dumpbin /HEADERS /OUT:{1} {0}", source, target));
                    break;
                case CmdId.EmitRelocations:
                    pattern = ToolCmd.pattern("dumpbin.relocations", string.Format("dumpbin /RELOCATIONS /OUT:{1} {0}", src.Format(PS), output.Format(PS)));
                    break;
                case CmdId.EmitExports:
                    pattern = ToolCmd.pattern("dumpbin.exports", string.Format("dumpbin /EXPORTS /OUT:{1} {0}", source, target));
                    break;
                case CmdId.EmitLoadConfig:
                    pattern = ToolCmd.pattern("dumpbin.loadconfig", string.Format("dumpbin /LOADCONFIG /OUT:{1} {0}", src.Format(PS), output.Format(PS)));
                    break;
            }
            return ToolCmd.expr(pattern);
        }
    }
}