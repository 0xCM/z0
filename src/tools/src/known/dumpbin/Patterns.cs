//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static DumpBin.Flag;

    using X = ArchiveFileKinds;

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
                    return ext(DISASM) + ext(NOBYTES) + X.Asm;
                case CmdId.EmitRawData:
                    return ext(RAWDATA) + X.Log;
                case CmdId.EmitHeaders:
                    return ext(HEADERS) + X.Log;
                case CmdId.EmitRelocations:
                    return ext(RELOCATIONS) + X.Log;
                case CmdId.EmitExports:
                    return ext(EXPORTS) + X.Log;
                case CmdId.EmitLoadConfig:
                    return ext(LOADCONFIG) + X.Log;
            }

            return X.Log;
        }

        public static CmdScript script(DumpBin tool, string name, CmdId id, FileModule[] src)
            => Scripts.create(name,src.Map(file => tool.Command(id, file.Path)));

        public CmdScript Script(string name, CmdId id, FileModule[] src)
            => script(this, name, id, src);

        public CmdScriptExpr Command(CmdId id, FS.FilePath src)
        {
            var subdir = OutputDir + FS.folder(src.FileName.WithoutExtension.Name);
            subdir.Create();
            var x = OutputExt(id);
            var output = subdir + src.FileName.ChangeExtension(x);
            var source = src.Format(PS);
            var target = output.Format(PS);
            var pattern = CmdPattern.Empty;
            switch(id)
            {
                case CmdId.EmitAsm:
                    pattern = Scripts.pattern("dumpbin.disasm", string.Format("dumpbin /DISASM:{2} /OUT:{1} {0}", source, target, "NOBYTES"));
                    break;
                case CmdId.EmitRawData:
                    pattern = Scripts.pattern("dumpbin.rawdata", string.Format("dumpbin /RAWDATA:1,32 /OUT:{1} {0}", source, target));
                    break;
                case CmdId.EmitHeaders:
                    pattern = Scripts.pattern("dumpbin.headers", string.Format("dumpbin /HEADERS /OUT:{1} {0}", source, target));
                    break;
                case CmdId.EmitRelocations:
                    pattern = Scripts.pattern("dumpbin.relocations", string.Format("dumpbin /RELOCATIONS /OUT:{1} {0}", src.Format(PS), output.Format(PS)));
                    break;
                case CmdId.EmitExports:
                    pattern = Scripts.pattern("dumpbin.exports", string.Format("dumpbin /EXPORTS /OUT:{1} {0}", source, target));
                    break;
                case CmdId.EmitLoadConfig:
                    pattern = Scripts.pattern("dumpbin.loadconfig", string.Format("dumpbin /LOADCONFIG /OUT:{1} {0}", src.Format(PS), output.Format(PS)));
                    break;
            }
            return Cmd.expr(pattern);
        }
    }
}