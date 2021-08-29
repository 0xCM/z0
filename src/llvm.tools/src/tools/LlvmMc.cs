//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public sealed class LlvmMc : ToolService<LlvmMc>
    {
        public override ToolId Id
            => Toolspace.llvm_mc;

        public static ToolScript mcdisasm(FS.FolderPath SrcDir, FS.FileName SrcFile, FS.FolderPath DstDir)
        {
            const string ScriptId = "disasm";
            var result = Outcome.Success;
            return Cmd.toolscript(Toolspace.llvm_mc, ScriptId, vars(SrcDir,SrcFile,DstDir));
        }

        public static ToolScript assemble(FS.FolderPath SrcDir, FS.FileName SrcFile, FS.FolderPath DstDir)
        {
            const string ScriptId = "assemble";
            var result = Outcome.Success;
            return Cmd.toolscript(Toolspace.llvm_mc, ScriptId, vars(SrcDir,SrcFile,DstDir));
        }

        static CmdVars vars(FS.FolderPath SrcDir, FS.FileName SrcFile, FS.FolderPath DstDir)
            => Cmd.vars(
                ("SrcDir", SrcDir.Format(PathSeparator.BS)),
                ("SrcFile", SrcFile.Format()),
                ("DstDir", DstDir.Format(PathSeparator.BS))
                );
    }
}